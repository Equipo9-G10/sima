using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sima.App.Frontend.Pages;

public class CarRegistrationModel : PageModel
{
    private readonly ILogger<CarRegistrationModel> _logger;

    public CarRegistrationModel(ILogger<CarRegistrationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

