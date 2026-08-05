using Microsoft.Playwright;
using System;

namespace SFA.DAS.TransferMatching.UITests.Project.Helper;

public class ObjectContext : IAsyncDisposable
{
    public IBrowserContext? BrowserContext { get; private set; }
    public IPage? Page { get; private set; }

    public async Task InitAsync(IBrowserContext context)
    {
        BrowserContext = context;
        Page = await BrowserContext.NewPageAsync();
    }

    public TPage GetPage<TPage>() where TPage : class
    {
        if (Page == null)
        {
            // fallback to parameterless constructor
            return Activator.CreateInstance<TPage>();
        }
        return (TPage)Activator.CreateInstance(typeof(TPage), Page)!;
    }

    public async ValueTask DisposeAsync()
    {
        if (Page != null) await Page.CloseAsync();
        if (BrowserContext != null) await BrowserContext.CloseAsync();
    }
}
