using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Hendriz_app.Models;
using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;

namespace Hendriz_app.Pages.Admin
{
    public class OrdersModel : PageModel
    {
        public void OnGet()
        {
            orders = new LinkedList<Order>();
            pending = new LinkedList<Order>();
            cancelled = new LinkedList<Order>();
            delivered = new LinkedList<Order>();
            shipped = new LinkedList<Order>();

            getOrders();
        }

        void getOrders()
		{
            {
                OracleConnection con = new OracleConnection(Data.Connection.connection_string);
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from OrderTable ORDER BY OrderDate DESC";
                cmd.Connection = con;
                con.Open();
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Order temp = new Order();
                        temp.orderid = int.Parse(reader["OrderID"].ToString());
                        temp.userid = int.Parse(reader["USERID"].ToString());
                        temp.status = getStatus(int.Parse(reader["Status"].ToString()));

                        string orderDate;
                        orderDate = reader["ORDERDATE"].ToString();
                        orderDate = truncateDate(orderDate);
                        
                        temp.orderDate = orderDate;

                        orders.AddLast(temp);

                        switch (temp.status)
                        {
                            case "Pending":
                                pending.AddLast(temp);
                                break;

                            case "Delivered":
                                delivered.AddLast(temp);
                                break;

                            case "Cancelled":
                                cancelled.AddLast(temp);
                                break;

                            case "Shipped":
                                shipped.AddLast(temp);
                                break;
                        }


                    }
                }
                else
                {
					for (int i = 0; i < 100; i++)
					{
                        Debug.WriteLine("No Data");
                    }
                }
                con.Close();
                
            }
        }
        public LinkedList<Order> orders, pending, cancelled, delivered, shipped;

        //interpret status code in te
        string getStatus(int code)
		{
            switch(code)
			{
                case 1:
                    return "Delivered";
                case 2:
                    return "Shipped";
                case 3:
                    return "Pending";
                case 4:
                    return "Cancelled";
                default:
                    //program should never come here
                    return "";
			}
		}

        string truncateDate(string input)
        {
            string dateOnly = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    break;
                }
                dateOnly = dateOnly + input[i];
            }
            return dateOnly;
        }
        public JsonResult OnGetSetShipped(int id,string status)
        {

            for (int i = 0; i < 100; i++)
            {
                Debug.WriteLine(status + ", " + id);
            }

            OracleConnection con = new OracleConnection(Data.Connection.connection_string);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE OrderTable SET status=2 WHERE OrderId=" + id;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return new JsonResult("{status:1,type:" + Data.Auth.type + "}");
            
        }

        public JsonResult OnGetSetCancelled(int id, string status)
        {

            for (int i = 0; i < 100; i++)
            {
                Debug.WriteLine(status + ", " + id);
            }



            OracleConnection con = new OracleConnection(Data.Connection.connection_string);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE OrderTable SET status=4 WHERE OrderId=" + id;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return new JsonResult("{status:1,type:" + Data.Auth.type + "}");

        }

        public JsonResult OnGetSetDelivered(int id, string status)
        {

            for (int i = 0; i < 100; i++)
            {
                Debug.WriteLine(status + ", " + id);
            }

            OracleConnection con = new OracleConnection(Data.Connection.connection_string);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE OrderTable SET status=1 WHERE OrderId=" + id;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return new JsonResult("{status:1,type:" + Data.Auth.type + "}");

        }
    }
}
