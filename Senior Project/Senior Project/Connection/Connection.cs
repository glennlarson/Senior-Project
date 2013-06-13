//Glenn Larson
//CIS591 Senior Project
//Connection Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Senior_Project
{
    class Connection
    {
        //variable declerations
        private static OleDbDataAdapter dbAdapter;
        private static OleDbCommand command;
        private static OleDbConnection dbConnection;
        private static string connection = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source=seniorproject.accdb";
        // create connection
        public static void CreateConnection()
        {
            // create connection
            dbConnection = new OleDbConnection(connection);
        }
        // setup connection method
        public static OleDbDataAdapter SetupConnection(string sql)
        {
            // create connection
            // sql statement

            // create command
            command = new OleDbCommand();
            command.CommandText = sql;
            command.Connection = dbConnection;
            // database adapter
            dbAdapter = new OleDbDataAdapter(sql, dbConnection);
            dbAdapter.SelectCommand = command;

            return dbAdapter;

        }
        // create insert command method
        public static OleDbCommand InsertCommand(string sql)
        {
            // check db connection state
            string connectionState = dbConnection.State.ToString();
            if (connectionState == "Closed")
            {
                dbConnection.Open();
            }
            
            // create command
            command = new OleDbCommand(sql, dbConnection);
            return command;

        }
        // close db connection method
        public static void CloseConnection()
        {
            dbConnection.Close();
        }
        // Update sql command setup
        public static OleDbCommand UpdateCommand(string updateSQL)
        {
            // check db connection state
            string connectionState = dbConnection.State.ToString();
            if (connectionState == "Closed")
            {
                dbConnection.Open();
            }

            // create command
            command = new OleDbCommand(updateSQL, dbConnection);
            return command;

        }
    }
}
