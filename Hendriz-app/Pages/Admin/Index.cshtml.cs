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

        public void OnGet()
        {

            OracleConnection con = new OracleConnection(Data.Connection.connection_string);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from temp";
            cmd.Connection = con;
            con.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine(dr["s"].ToString());
                    string jj = dr["s"].ToString();
                    name.Add(jj);
                    id.Add(int.Parse(dr["i"].ToString()));
                }
            }
            else
            {
            }
            con.Close();
        }
    }
}
