using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Warehouse.Data;
using Warehouse.Model;

namespace Warehouse.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly Warehouse.Data.WarehouseContext _context;

        public IndexModel(Warehouse.Data.WarehouseContext context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
