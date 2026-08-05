using Microsoft.Playwright;
using SFA.DAS.TransferMatching.UITests.Project.PageObjects;

namespace SFA.DAS.TransferMatching.UITests.Project.Helper;

public class ObjectContext
{
    public IBrowserContext? BrowserContext { get; set; }
    public IPage? Page { get; set; }

    // page object factory using existing Page
    public TPage GetPage<TPage>() where TPage : class
    {
        if (Page == null) return Activator.CreateInstance<TPage>();
        return (TPage)Activator.CreateInstance(typeof(TPage), Page)!;
    }
}
