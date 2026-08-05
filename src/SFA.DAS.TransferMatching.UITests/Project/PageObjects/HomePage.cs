using Microsoft.Playwright;
namespace SFA.DAS.TransferMatching.UITests.Project.PageObjects;

public class HomePage
{
    private readonly IPage _page;
    public HomePage(IPage page) => _page = page;

    public string Url => "/transfer-matching";
    public async Task NavigateAsync() => await _page.GotoAsync(Url);
    public async Task ClickCreatePledgeAsync() => await _page.ClickAsync("#create-pledge");
}
