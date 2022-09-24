using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sima.App.Frontend.Pages;

public class  CustomerRegistrationModel : PageModel
{
    private readonly ILogger<CustomerRegistrationModel> _logger;

    public CustomerRegistrationModel(ILogger<CustomerRegistrationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

