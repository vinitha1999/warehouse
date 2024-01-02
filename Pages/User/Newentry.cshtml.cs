using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Warehouse.Model;

namespace Warehouse.Pages.User
{
    public class NewentryModel : PageModel
    {
        private readonly ILogger<NewentryModel> _logger;

        public NewentryModel(ILogger<NewentryModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        [BindProperty]
        public string Entry { get; set; }
       

    }
}

