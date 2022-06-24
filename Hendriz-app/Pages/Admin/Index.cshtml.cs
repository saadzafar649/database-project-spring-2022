using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Oracle.ManagedDataAccess.Client;
namespace Hendriz_app.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public List<int> id= new List<int>();
        public List<string> name= new List<string>();

        public IActionResult OnGet()
        {
            string url = "/Admin/Dashboard";

            return Redirect(url);
        }
    }
}
