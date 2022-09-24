using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sima.App.Frontend.Pages;

public class  EmployeeRegistrationModel : PageModel
{
    private readonly ILogger<EmployeeRegistrationModel> _logger;

    public EmployeeRegistrationModel(ILogger<EmployeeRegistrationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

