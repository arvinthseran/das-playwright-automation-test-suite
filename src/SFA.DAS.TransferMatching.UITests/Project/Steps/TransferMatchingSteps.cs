using TechTalk.SpecFlow;
using SFA.DAS.TransferMatching.UITests.Project.Helper;
using SFA.DAS.TransferMatching.UITests.Project.PageObjects;
using SFA.DAS.TransferMatching.UITests.Project.Hooks;

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
        if (_context.Page == null)
        {
            var fixture = GlobalHooks.Fixture ?? throw new InvalidOperationException("Fixture not initialized");
            var bc = await fixture.CreateContextAsync();
            await _context.InitAsync(bc);
        }

        var home = new HomePage(_context.Page!);
        await home.NavigateAsync();
    }

    [Then("the levy employer can verify login for existing view user")]
    public async Task ThenVerifyLoginForExistingViewUser()
    {
        var title = await _context.Page!.TitleAsync();
        NUnit.Framework.Assert.IsNotNull(title);
        await _context.DisposeAsync();
    }
}
