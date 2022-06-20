using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Hendriz_app.Data
{
    public static class Auth
    {
        static int id = -1;
        public static string type = "";

        public static bool Login(string username,string password)
        {
            try
            {

                OracleConnection con = new OracleConnection(Data.Connection.connection_string);

                //checking username and password
                OracleCommand checkuserpass = new OracleCommand("authuser", con);
                checkuserpass.Parameters.Add("username", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = username;
                checkuserpass.Parameters.Add("pass", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = password;

                checkuserpass.CommandText = "Declare ret INT; BEGIN ret := authuser(:username, :pass); :ret:=ret; END;";
                con.Open();

                checkuserpass.CommandType = System.Data.CommandType.Text;
                OracleParameter retval = new OracleParameter("ret", OracleDbType.Int32);
                retval.Direction = System.Data.ParameterDirection.ReturnValue;
                checkuserpass.Parameters.Add(retval);


                checkuserpass.ExecuteNonQuery();
                String returnValue = checkuserpass.Parameters["ret"].Value.ToString();
                con.Close();


                if (retval.Value.ToString() != "")
                {
                    Auth.id = int.Parse(retval.Value.ToString());

                    OracleCommand checkusertype = new OracleCommand("usertype", con);
                    checkusertype.Parameters.Add("userid", OracleDbType.Int32, System.Data.ParameterDirection.Input).Value = id.ToString();
                    checkusertype.CommandText = "Declare ret VARCHAR2(20); BEGIN ret := usertype(:userid); :ret:=ret; END;";
                    checkusertype.CommandType = System.Data.CommandType.Text;
                    con.Open();
                    OracleParameter type = new OracleParameter("ret", OracleDbType.Varchar2, 20);
                    type.Direction = System.Data.ParameterDirection.ReturnValue;
                    checkusertype.Parameters.Add(type);
                    checkusertype.ExecuteNonQuery();
                    con.Close();
                    Auth.type = type.Value.ToString();

                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static void Logout()
        {
            id = -1;
            type = "";
        }

        public static int isLoggedin()=> id;
    }
}
