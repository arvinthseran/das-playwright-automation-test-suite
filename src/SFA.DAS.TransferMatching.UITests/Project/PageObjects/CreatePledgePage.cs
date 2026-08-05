using Microsoft.Playwright;
namespace SFA.DAS.TransferMatching.UITests.Project.PageObjects;

public class CreatePledgePage
{
    private readonly IPage _page;
    public CreatePledgePage(IPage page) => _page = page;

    public async Task FillAmountAsync(string amount) => await _page.FillAsync("#amount", amount);
    public async Task SubmitAsync() => await _page.ClickAsync("#submit-pledge");
}
