using Microsoft.Playwright;
using System.Threading.Tasks;

namespace SFA.DAS.TransferMatching.UITests.Project.Helper;

public class PlaywrightAdapter
{
    private readonly ObjectContext _context;
    public PlaywrightAdapter(ObjectContext context) => _context = context;

    public async Task NavigateAsync(string url)
    {
        if (_context.Page == null) throw new InvalidOperationException("Page not initialized");
        await _context.Page.GotoAsync(url);
    }

    public async Task FillAsync(string selector, string text)
    {
        if (_context.Page == null) throw new InvalidOperationException("Page not initialized");
        await _context.Page.FillAsync(selector, text);
    }

    public async Task ClickAsync(string selector)
    {
        if (_context.Page == null) throw new InvalidOperationException("Page not initialized");
        await _context.Page.ClickAsync(selector);
    }
}
