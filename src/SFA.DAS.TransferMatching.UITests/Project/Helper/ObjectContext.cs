using Microsoft.Playwright;

namespace SFA.DAS.TransferMatching.UITests.Project.Helper;

public class ObjectContext
{
    public IBrowserContext? BrowserContext { get; set; }
    public IPage? Page { get; set; }

    // simple page factory placeholder
    public TPage GetPage<TPage>() where TPage : class, new()
    {
        return new TPage();
    }
}
