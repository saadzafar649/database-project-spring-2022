using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Oracle.ManagedDataAccess.Client;
using Hendriz_app.Models;
namespace Hendriz_app.Pages.User
{
    public class ProfileModel : PageModel
    {
        public List<CartItem> items = new();
        public Person userdetails = new();
        public void OnGet()
        {
            if (Data.Auth.isLoggedin() == -1 && Data.Auth.type != "user")
            {
                Response.Redirect("/Auth/Login");
            }

            OracleConnection con = new OracleConnection(Data.Connection.connection_string);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = string.Format("select * from Cart Where Userid = {0}", Data.Auth.isLoggedin());
            cmd.Connection = con;
            con.Open();
            int cartid=0;
            OracleDataReader reader = cmd.ExecuteReader(); 
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    cartid = int.Parse(reader["cartId"].ToString());
                }
            }

            con.Close();
            con.Open();
            Console.WriteLine(cartid);
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = string.Format("select * from CartItem C LEFT JOIN Product P ON P.productId = C.productId Where cartId = {0}", cartid);
            OracleDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    CartItem temp = new CartItem();
                    temp.ItemId = int.Parse(reader2["Itemid"].ToString());
                    temp.productId = int.Parse(reader2["productId"].ToString());
                    temp.name = (reader2["productName"].ToString());
                    temp.image = (reader2["imageLink"].ToString());
                    temp.price = int.Parse(reader2["price"].ToString());
                    temp.quantity = int.Parse(reader2["quantity"].ToString());
                    temp.discount = int.Parse(reader2["Discount"].ToString());
                    temp.color = (reader2["ColorName"].ToString());
                    items.Add(temp);
                }
            }
            else
            {
            }
            con.Close();
            GetUserDetails();
        }
        void GetUserDetails()
        {
            try
            {
                OracleConnection con = new OracleConnection(Data.Connection.connection_string);
                con.Close();
                con.Open();
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                cmd2.CommandText = string.Format("select * from Person Where personId = {0}", Data.Auth.isLoggedin());
                OracleDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        userdetails.name = (reader2["personName"].ToString());
                        userdetails.email = (reader2["email"].ToString());
                        userdetails.phoneNo = (reader2["phoneNo"].ToString());
                        userdetails.address = (reader2["address"].ToString());
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


        public JsonResult OnGetRemoveItem(int itemid)
        {
            try
            {
                OracleConnection con = new OracleConnection(Data.Connection.connection_string);
                con.Close();
                con.Open();
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                cmd2.CommandText = string.Format("Delete CartItem Where Itemid = {0}", itemid);
                cmd2.ExecuteNonQuery();
                
                cmd2.CommandText = "commit";
                cmd2.ExecuteNonQuery();

                con.Close();
            }
            catch
            {
                return new JsonResult("{status:0,redirect:/Auth/Login}", System.Net.HttpStatusCode.InternalServerError);
            }

            return new JsonResult("{status:1}");
        }
        public JsonResult OnGetLogOut()
        {
            try
            {
                Data.Auth.Logout();
            }
            catch
            {
                return new JsonResult("{status:0,redirect:/Auth/Login}", System.Net.HttpStatusCode.InternalServerError);
            }
            return new JsonResult("{status:1}");

        }
    }
}
