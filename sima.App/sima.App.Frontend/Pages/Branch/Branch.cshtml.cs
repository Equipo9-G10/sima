using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sima.App.Frontend.Pages;

public class  BranchModel : PageModel
{
    private readonly ILogger<BranchModel> _logger;

    public BranchModel(ILogger<BranchModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

