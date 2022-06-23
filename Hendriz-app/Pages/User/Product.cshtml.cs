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
        public List<Review> reviews = new();
        public bool haveReviewed=false;
        public void OnGet(int id)
        {
            getProduct(id);
            getReviews(id);
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
                Console.WriteLine(reader.HasRows);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Color itemcolor = new ();
                        itemcolor.color = reader["ColorName"].ToString();
                        itemcolor.quantity = int.Parse(reader["quantitysold"].ToString());
                        item.colors.Add(itemcolor);
                        Console.WriteLine(itemcolor.color);
                    }
                }
                else
                {
                }
                con.Close();
            }
            catch
            {
                Response.Redirect("/User/AllProducts");
            }

        }

        void getReviews(int id)
        {
            
            {

                OracleConnection con = new OracleConnection(Data.Connection.connection_string);

                if (Data.Auth.isLoggedin()==-1)
                {
                    haveReviewed = true;
                }
                //reading colors of particular product of id
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = string.Format("select * from Review R Left Join Person P on R.personid = P.personid where ProductId = {0}", id);
                cmd.Connection = con;
                con.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(reader.HasRows);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Review review = new();
                        review.name = reader["personname"].ToString();
                        review.timestamp = reader["reviewtime"].ToString();
                        review.review = reader["review"].ToString();
                        review.stars = int.Parse(reader["stars"].ToString());
                        if(int.Parse(reader["personId"].ToString())== Data.Auth.isLoggedin())
                        {
                            haveReviewed = true;
                        }
                        reviews.Add(review);
                    }
                }
                else
                {
                }
                con.Close();
            }
            Console.WriteLine(reviews.Count.ToString()+"e");
            
            {
                //Response.Redirect("/User/AllProducts");
            }
        }
        public JsonResult OnGetAddToCart(string color, int quantity, int productid)
        {
            if (Data.Auth.isLoggedin() == -1)
            {
                return new JsonResult("{status:0,redirect:/Auth/Login}", System.Net.HttpStatusCode.Forbidden);
            }
            try
            {
                OracleConnection con = new OracleConnection(Data.Connection.connection_string);
                //adding item to cart
                OracleCommand cartprocedure = new OracleCommand("AddItemToCart", con);
                cartprocedure.Parameters.Add("Productid", OracleDbType.Int32, System.Data.ParameterDirection.Input).Value = productid;
                cartprocedure.Parameters.Add("Userid", OracleDbType.Int32, System.Data.ParameterDirection.Input).Value = Data.Auth.isLoggedin();
                cartprocedure.Parameters.Add("ColorName", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = color;
                cartprocedure.Parameters.Add("quantity", OracleDbType.Int32, System.Data.ParameterDirection.Input).Value = quantity;
                con.Open();
                cartprocedure.CommandType = System.Data.CommandType.StoredProcedure;

                cartprocedure.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }

            return new JsonResult("{status:1}");
        }
        public JsonResult OnGetAddReview(string review, int stars, int productid)
        {
            if (Data.Auth.isLoggedin() == -1)
            {
                return new JsonResult("{status:0,redirect:/Auth/Login}", System.Net.HttpStatusCode.Forbidden);
            }
            try
            {
                OracleConnection con = new OracleConnection(Data.Connection.connection_string);
                //adding item to cart
                OracleCommand addReview = new OracleCommand();
                addReview.CommandText = string.Format("INSERT INTO Review(ProductId, personId, Review, Stars) VALUES({0}, {1}, '{2}', {3})",
                    productid,
                    Data.Auth.isLoggedin(),
                    review,
                    stars
                    );
                addReview.Connection = con;
                con.Open();
                addReview.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }

            return new JsonResult("{status:1}");
        }
    }
}
