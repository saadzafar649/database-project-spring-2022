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


        public JsonResult OnGetAuthenticate(string username,string password) {
            if (!Data.Auth.Login(username, password))
            {
                return new JsonResult("{status:0,redirect:/Auth/Login}", System.Net.HttpStatusCode.Forbidden);
            }
            else
            {
                return new JsonResult("{status:1,type:"+ Data.Auth.type+"}");
            }
        }
    }
}
