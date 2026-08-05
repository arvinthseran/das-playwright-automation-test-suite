using Microsoft.Playwright;
namespace SFA.DAS.TransferMatching.UITests.Project.PageObjects;

public class PledgeListPage
{
    private readonly IPage _page;
    public PledgeListPage(IPage page) => _page = page;

    public async Task<bool> HasPledgeWithAmountAsync(string amount)
    {
        var text = await _page.InnerTextAsync("#pledge-list");
        return text.Contains(amount);
    }
}
