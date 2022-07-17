using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ITMO.WinForms.FinalTest
{
    internal class clsDataBaseMSSQL
    {
        SqlConnection sqlConn = new SqlConnection("Integrated Security = SSPI; Persist Security Info=False; " +
                "Initial Catalog = test_block; Data Source =.");
        // open connection having checked if it is closed
        public void openConnection()
        {
            if(sqlConn.State == System.Data.ConnectionState.Closed) 
            { 
                sqlConn.Open(); 
            }
        }
        // close connection if it is open
        public void closeConnection()
        {
            if (sqlConn.State == System.Data.ConnectionState.Open) 
            {
                sqlConn.Close();
            }
        }
        // return a connection string
        public SqlConnection getConnection()
        {
            return sqlConn;
        }
    }
}
