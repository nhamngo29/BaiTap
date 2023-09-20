using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConections
{
    public class SQL
    {
        public static SqlConnection cnn;
        private string ConnectionString { get; set; }
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public SQL(string ConnectionString)
        {
            this.ConnectionString= ConnectionString;
        }
        public SQL(string SeverName,string DatabaseName)
        {
            builder.IntegratedSecurity = true;
            builder.DataSource = SeverName;
            builder.InitialCatalog = DatabaseName;

        }
        public SQL(string SeverName, string DatabaseName,string User,string Password) 
        {
            builder.DataSource = SeverName;
            builder.InitialCatalog = DatabaseName;
            builder.UserID = User;
            builder.Password = Password;
        }
        public void Open()
        {
            ConnectionString = builder.ConnectionString;
            cnn = new SqlConnection(ConnectionString);
            if(cnn.State!=ConnectionState.Open)
            {
                cnn.Open();
            }    
        }
        public void Close()
        {
            ConnectionString = builder.ConnectionString;
            cnn = new SqlConnection(ConnectionString);
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public bool TestConnection()
        {
            try
            {
                Open();
                Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
