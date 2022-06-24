using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hendriz_app.Models;
using Oracle.ManagedDataAccess.Client;
namespace Hendriz_app.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public List<ProductCard> Latestproducts = new List<ProductCard>();
        public void OnGet()
        {
            getProductCards();
        }
        void getProductCards()
        {
            try
            {
                OracleConnection con = new OracleConnection(Data.Connection.connection_string);
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from ProductCard";
                cmd.Connection = con;
                con.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductCard temp = new ProductCard();
                        temp.Id = int.Parse(reader["ProductId"].ToString());
                        temp.name = (reader["productName"].ToString());
                        temp.title = (reader["productTitle"].ToString());
                        temp.image = (reader["imageLink"].ToString());
                        temp.watchcount = int.Parse(reader["watchCount"].ToString());
                        temp.price = int.Parse(reader["price"].ToString());
                        temp.stars = Convert.ToInt32(float.Parse(((reader["Stars"].ToString() == "") ? "0" : reader["Stars"].ToString())));
                        temp.reviewCount = int.Parse(((reader["Stars"].ToString() == "") ? "0" : reader["reviewcount"].ToString()));
                        Latestproducts.Add(temp);
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
