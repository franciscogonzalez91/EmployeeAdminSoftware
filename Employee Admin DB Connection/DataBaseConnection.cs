using System;
using System.Data;
using System.Data.SqlClient;


namespace Employee_Admin_DB_Connection
{
    public class DataBaseSqlConnection
    {
        /// <summary>
        /// 
        /// </summary>
        private SqlConnection SqlConn = new SqlConnection();
        /// <summary>
        /// 
        /// </summary>
        private SqlCommand Sqlcmd = new SqlCommand();
        /// <summary>
        /// 
        /// </summary>
        private SqlDataReader SqlReader;
        /// <summary>
        /// 
        /// </summary>
        private DataTable Table = new DataTable("Empleados");
        /// <summary>
        /// 
        /// </summary>        
        private string Connection = "Data Source=FRANK-PC;Initial Catalog=EmployeeAdmon;Integrated Security=True";
        /// <summary>
        /// 
        /// </summary>
        private string SqlSentence;
        
        
        public DataTable SearchEmployee(string DataSearched)
        {
            //Connection to the database
            SqlConn.ConnectionString = Connection;
            
            //Here the SQL Command is declared
            Sqlcmd.CommandText = "SELECT EmployeeId, FirstName, LastName FROM Employee WHERE EmployeeId LIKE " + DataSearched + " OR FirstName LIKE '%" + DataSearched + "%' OR LastName LIKE '%" + DataSearched + "%'";
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.Connection = SqlConn;

            //Now open the database after declaring all the connection
            SqlConn.Open();

            //Here we execute the SQL command
            SqlReader = Sqlcmd.ExecuteReader();

            //The information is saved on the Table
            Table.Load(SqlReader);

            return Table;
        }
    }
}
