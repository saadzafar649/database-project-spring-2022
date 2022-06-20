using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Oracle.ManagedDataAccess.Client;
namespace Hendriz_app.Pages.Auth
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {

        }


        public void OnPostAuthenticate(string username,string password) {
        }
    }
}
