using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sima.App.Frontend.Pages;

public class  SparePartsModel : PageModel
{
    private readonly ILogger<SparePartsModel> _logger;

    public SparePartsModel(ILogger<SparePartsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

