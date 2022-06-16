﻿using Microsoft.AspNetCore.Mvc;
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
                    //temp.stars = int.Parse(reader["Stars"].ToString());
                    Latestproducts.Add(temp);

                }
            }
            else
            {
            }
            con.Close();
        }
        public async Task<IActionResult> OnPostGenerateWebName(string returnUrl = null)
        {
            CreateWebName();
            
            // all  done
            return Page();
        }


        private void CreateWebName()
        {
            ModelState.Clear();
            getProductCards();
            Latestproducts[0].title = "asdasdsad";
            Response.Redirect(Request.Path);
        }

    }
}
