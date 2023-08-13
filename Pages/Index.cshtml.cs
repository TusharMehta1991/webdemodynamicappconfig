using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using webdemodynamicappconfig.Model;

namespace webdemodynamicappconfig.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public AppSetting Settings { get; }

    public IndexModel(ILogger<IndexModel> logger, IOptions<AppSetting> options)
    {
        _logger = logger;
        Settings = options.Value;
    }

    public void OnGet()
    {

    }
}
