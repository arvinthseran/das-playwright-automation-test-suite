using System.Threading.Tasks;
using Microsoft.Playwright;

namespace SFA.DAS.TransferMatching.UITests.Project.Helper;

public static class PlaywrightAdapterExtensions
{
    public static async Task<IPage> NewPageForContextAsync(this IBrowser browser)
    {
        var ctx = await browser.NewContextAsync();
        return await ctx.NewPageAsync();
    }
}
