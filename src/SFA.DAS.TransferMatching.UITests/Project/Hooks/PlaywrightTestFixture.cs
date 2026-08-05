using NUnit.Framework;
using Microsoft.Playwright;

namespace SFA.DAS.TransferMatching.UITests.Project.Hooks;

public class PlaywrightTestFixture
{
    public IPlaywright? Playwright { get; private set; }
    public IBrowser? Browser { get; private set; }

    [OneTimeSetUp]
    public async Task GlobalSetup()
    {
        Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
        Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
    }

    [OneTimeTearDown]
    public async Task GlobalTeardown()
    {
        if (Browser != null) await Browser.CloseAsync();
        Playwright?.Dispose();
    }

    public async Task<IBrowserContext> CreateContextAsync()
    {
        if (Browser == null) throw new InvalidOperationException("Browser not initialized");
        return await Browser.NewContextAsync();
    }
}
