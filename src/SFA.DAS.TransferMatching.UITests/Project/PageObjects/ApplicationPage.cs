using Microsoft.Playwright;
namespace SFA.DAS.TransferMatching.UITests.Project.PageObjects;

public class ApplicationPage
{
    private readonly IPage _page;
    public ApplicationPage(IPage page) => _page = page;

    public async Task ApplyForPledgeAsync() => await _page.ClickAsync("#apply-for-pledge");
}
