using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Net
{
    internal class Database
    {
        static readonly string server = "127.0.0.1";
        static readonly string user = "root";
        static readonly string password = "";
        static readonly string database = "bookingdata";
        public static string connection_string = "server='" + server + "'; user='"+user+"';database='"+database+"';password='"+password+"'";

        public MySqlConnection mysqlconnection = new MySqlConnection(connection_string);
        public bool connect_db()
        {
            try
            {
                mysqlconnection.Open();
                return true;

            }
            catch(Exception e) 
            {
                return false;
            }
        }

        public bool close_db()
        {
            try
            {
                mysqlconnection.Close();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
        
    }
    

}
