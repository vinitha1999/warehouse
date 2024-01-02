using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Warehouse.Pages.User
{
    public class List_priceModel : PageModel
    {
        private readonly ILogger<List_priceModel> _logger;

        public List_priceModel(ILogger<List_priceModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

    }
}
