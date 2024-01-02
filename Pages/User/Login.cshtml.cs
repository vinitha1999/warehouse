using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Pages.User
{
    public class LoginModel : PageModel
    {

        Data.WarehouseContext _context;
        public LoginModel(Data.WarehouseContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string Email { get; set; }
        //[BindProperty]
        //public LoginModel login { get; set; } = default!;

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (Email == null)
            {
                Response.WriteAsync("<script>alert('Please enter email ID');</script>");
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.Email ==Email);
            if (user == null)
            {
                Response.WriteAsync("<script>alert('User not found in DB');</script>");

            }
            else
            {
                if (user.Password == Password)
                {
                    return RedirectToPage("LoginIndex");
                }
                else
                {
                    Response.WriteAsync("<script>alert('Wrong password');</script>");
 
                }
            }
            return RedirectToPage("Index");
        }
    }
}
  