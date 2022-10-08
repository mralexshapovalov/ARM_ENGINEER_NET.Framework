using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ARM_Engineer.Catalog_Parts
{
    class Connection_in_DataBase
    {
        SqlConnection sqlConnection_Parts = new SqlConnection(@"Data Source = DESKTOP-03FRQ5P;Initial catalog = DataBase;Integrated Security=true");

        public void oppenConnection()
        {
            if (sqlConnection_Parts.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection_Parts.Open();
            }
        }

        public void clouseConnection()
        {
            if (sqlConnection_Parts.State == System.Data.ConnectionState.Open)
            {
                sqlConnection_Parts.Close();
            }
        }


        public SqlConnection GetConnection()
        {
            return sqlConnection_Parts;
        }
    }
}
