using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sima.App.Frontend.Pages;

public class  ServiceOrderModel : PageModel
{
    private readonly ILogger<ServiceOrderModel> _logger;

    public ServiceOrderModel(ILogger<ServiceOrderModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

