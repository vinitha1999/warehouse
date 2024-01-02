using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Warehouse.Model;

namespace Warehouse.Pages.User
{
    public class WMlocationModel : PageModel
    {
        private readonly ILogger<WMlocationModel> _logger;

        public WMlocationModel(ILogger<WMlocationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        [BindProperty]
      public WHlocation field { get; set; }       
    }
}
