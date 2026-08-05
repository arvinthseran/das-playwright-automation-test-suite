using NUnit.Framework;
using Microsoft.Playwright;

namespace SFA.DAS.TransferMatching.UITests.Project.Hooks;

[SetUpFixture]
public class GlobalHooks
{
    public static PlaywrightTestFixture? Fixture { get; private set; }

    [OneTimeSetUp]
    public async Task Init()
    {
        Fixture = new PlaywrightTestFixture();
        await Fixture.GlobalSetup();
    }

    [OneTimeTearDown]
    public async Task Shutdown()
    {
        if (Fixture != null) await Fixture.GlobalTeardown();
    }
}
