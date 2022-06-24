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
    public class AllProductsModel : PageModel
    {
        public List<ProductCard> allProducts = new();
        public Dictionary<string, string> allCategories = new();
        public void OnGet()
        {
            
            {

                OracleConnection con = new OracleConnection(Data.Connection.connection_string);


                //reading data of all products
                OracleCommand cmd = new OracleCommand(); 
                cmd.CommandText = string.Format("select * from ProductCard P Left Join CategoryTable C on P.productCategory = C.CategoryId");
                cmd.Connection = con;
                con.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductCard item= new ProductCard ();
                        item.Id = int.Parse(reader["ProductId"].ToString());
                        item.name = (reader["productName"].ToString());
                        item.title = (reader["productTitle"].ToString());
                        item.image = (reader["imageLink"].ToString());
                        item.category = (reader["productCategory"].ToString());
                        item.watchcount = int.Parse(reader["watchCount"].ToString());
                        item.price = int.Parse(reader["price"].ToString());
                        item.stars = Convert.ToInt32(float.Parse(((reader["Stars"].ToString() == "") ? "0" : reader["Stars"].ToString())));
                        item.reviewCount = int.Parse(((reader["Stars"].ToString() == "") ? "0" : reader["reviewcount"].ToString()));
                        allProducts.Add(item);

                        allCategories[reader["productCategory"].ToString()] = reader["CategoryName"].ToString();
                    }
                }
                else
                {
                }
                con.Close();
            }
            
            {
                Console.WriteLine(allProducts.Count);

            }
        }
    }
}
