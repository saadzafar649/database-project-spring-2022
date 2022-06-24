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
    public class SearchModel : PageModel
    {
        public void OnGet()
        {
        }

        public JsonResult OnGetSearchItems(string searchQuery)
        {
            List<ProductCard> searchresult = new();
            try
            {
                OracleConnection con = new OracleConnection(Data.Connection.connection_string);
                string tempinp = "";
                try
                {
                    int price = int.Parse(searchQuery);
                    tempinp = "OR price = " + price.ToString();
                }
                catch
                {

                }
                //search for all items
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = string.Format("select * from ProductCard Where productName = '%{0}%' OR productTitle Like '%{0}%' {1} ORDER BY Stars ASC", searchQuery, tempinp);
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
                        temp.reviewCount = int.Parse(((reader["Stars"].ToString() == "") ? "0" : reader["reviewcount"].ToString()));
                        temp.price = int.Parse(reader["price"].ToString());
                        temp.stars = Convert.ToInt32(float.Parse(((reader["Stars"].ToString() == "") ? "0" : reader["Stars"].ToString())));
                        searchresult.Add(temp);
                    }
                }
                else
                {
                }
            }
            catch
            {
                return new JsonResult("{status:0,redirect:/Auth/Login}", System.Net.HttpStatusCode.InternalServerError);
            }


            string returnjson = "{ \"status\" : 1 , " +
                "\"items\":[";
            int count = 0;
            foreach(var i in searchresult)
            {
                returnjson += "{"; 
                returnjson += "\"id\" : " + i.Id + " , ";
                returnjson += "\"image\" : \"" + i.image + "\" , ";
                returnjson += "\"name\" : \"" + i.name + "\" , ";
                returnjson += "\"price\" : " + i.price + " , ";
                returnjson += "\"reviewCount\" : " + i.reviewCount + " , ";
                returnjson += "\"Stars\" : " + i.stars + " , ";
                returnjson += "\"title\" : \"" + i.title + "\" , ";
                returnjson += "\"watchcount\" : " + i.watchcount + " , ";
                returnjson += "\"category\" : \"" + i.category + "\" ";
                returnjson += "}";
                count++;
                if(count< searchresult.Count)returnjson += ",";
            }
            returnjson += " ] }";
            return new JsonResult(returnjson);

        }
    }
}
