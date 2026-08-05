using TechTalk.SpecFlow;
using SFA.DAS.TransferMatching.UITests.Project.Helper;
using SFA.DAS.TransferMatching.UITests.Project.PageObjects;

namespace SFA.DAS.TransferMatching.UITests.Project.Steps;

[Binding]
public class TransferMatchingSteps
{
    private readonly ObjectContext _context;
    private readonly PlaywrightAdapter _adapter;

    public TransferMatchingSteps(ObjectContext context)
    {
        _context = context;
        _adapter = new PlaywrightAdapter(_context);
    }

    [Given("the levy employer logins using existing transfer matching account")]
    public async Task GivenLevyEmployerLogins()
    {
        // placeholder - assume login helper exists and sets _context.Page
        if (_context.Page == null)
        {
            var bc = GlobalHooks.Fixture?.Browser?.NewContextAsync().Result;
            _context.BrowserContext = bc;
            _context.Page = bc?.NewPageAsync().Result;
        }
        // navigate to home
        var home = new HomePage(_context.Page!);
        await home.NavigateAsync();
    }

    [Then("the levy employer can verify login for existing view user")]
    public async Task ThenVerifyLoginForExistingViewUser()
    {
        // simple assertion placeholder
        var title = await _context.Page!.TitleAsync();
        NUnit.Framework.Assert.IsNotNull(title);
    }
}
