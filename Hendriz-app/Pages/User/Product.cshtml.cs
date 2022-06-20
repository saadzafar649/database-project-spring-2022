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
        public string helper = "0";
        public void OnGet(int id)
        {
            getProduct(id);
        }
        void getProduct(int id)
        {
            try
            {

                OracleConnection con = new OracleConnection(Data.Connection.connection_string);

                //increasing watchcount or visits
                OracleCommand visit = new OracleCommand("ADDWATCHCOUNT", con);
                visit.Parameters.Add("ParName", OracleDbType.Int32, System.Data.ParameterDirection.Input).Value = id;
                con.Open();
                visit.CommandType = System.Data.CommandType.StoredProcedure;

                visit.ExecuteNonQuery();
                con.Close();


                //reading data of particular product
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = string.Format("select * from Product Left Join CategoryTable on productCategory = CategoryId Where ProductId = {0}", id);
                cmd.Connection = con;
                con.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        item.Id = int.Parse(reader["ProductId"].ToString());
                        item.name = (reader["productName"].ToString());
                        item.title = (reader["productTitle"].ToString());
                        item.image = (reader["imageLink"].ToString());
                        item.category = (reader["CategoryName"].ToString());
                        item.description = (reader["productDescription"].ToString());
                        item.price = int.Parse(reader["price"].ToString());
                        item.discount = int.Parse(reader["discount"].ToString());
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
            if (item.price == 0)
            {
                Response.Redirect("/User/AllProducts");
            }
            getColor(id);
        }
        
        void getColor(int id)
        {
            try
            {

                OracleConnection con = new OracleConnection(Data.Connection.connection_string);


                //reading colors of particular product of id
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = string.Format("select * from Color Where ProductId = {0}", id);
                cmd.Connection = con;
                con.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Color itemcolor = new ();
                        itemcolor.color = reader["ColorName"].ToString();
                        itemcolor.quantity = int.Parse(reader["quantity"].ToString());
                        item.colors.Add(itemcolor);
                    }
                }
                else
                {
                }
                con.Close();
            }
            catch
            {
                Response.Redirect("/User/Products");
            }

        }

        public void sethelper(string val)=>helper = val;

        public void OnPostAddToCart1(string color, int quantity)
        {
            Console.WriteLine(color);
            Console.WriteLine(quantity);
        }
        public JsonResult OnGetAddToCart(string color,int quantity)
        {
            if (Data.Auth.isLoggedin() == -1)
            {
                return new JsonResult("{status:0,redirect:/Auth/Login}", System.Net.HttpStatusCode.Forbidden);
            }
            else
            {

                Response.Redirect("/");
            }
            return new JsonResult("{status:1}");
        }
    }
}
