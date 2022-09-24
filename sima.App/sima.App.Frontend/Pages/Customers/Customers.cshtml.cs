using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sima.App.Frontend.Pages;

public class  CustomersModel : PageModel
{
    private readonly ILogger<CustomersModel> _logger;

    public CustomersModel(ILogger<CustomersModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

