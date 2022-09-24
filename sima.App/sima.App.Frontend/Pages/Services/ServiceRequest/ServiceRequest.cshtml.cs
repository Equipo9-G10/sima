using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sima.App.Frontend.Pages;

public class  ServiceRequestModel : PageModel
{
    private readonly ILogger<ServiceRequestModel> _logger;

    public ServiceRequestModel(ILogger<ServiceRequestModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

