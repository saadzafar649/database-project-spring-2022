using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hendriz_app.Models;
using Oracle.ManagedDataAccess.Client;
namespace Hendriz_app.Pages.User
{
    public class ProductModel : PageModel
    {

        public Product item = new Product();
        public void OnGet(int id=1)
        {
            item.Id = id;

            try
            {

                OracleConnection con = new OracleConnection(Data.Connection.connection_string);

                //increasing watchcount or visits
                OracleCommand visit =  new OracleCommand("ADDWATCHCOUNT", con);
                visit.Parameters.Add("ParName", OracleDbType.Int32, System.Data.ParameterDirection.Input).Value=id;
                con.Open();
                visit.CommandType = System.Data.CommandType.StoredProcedure;

                visit.ExecuteNonQuery();
                con.Close();


                //reading data of particular product
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from Product";
                cmd.Connection = con;
                con.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        Product temp = new Product();
                        temp.Id = int.Parse(reader["ProductId"].ToString());
                        temp.name = (reader["productName"].ToString());
                        temp.title = (reader["productTitle"].ToString());
                        temp.image = (reader["imageLink"].ToString());
                        temp.category = (reader["productCategory"].ToString());
                        temp.description = (reader["productDescription"].ToString());
                        temp.price = int.Parse(reader["watchCount"].ToString());
                        
                    }
                }
                else
                {
                }
                con.Close();
            }
            catch 
            {

            }
        }
    }
}
