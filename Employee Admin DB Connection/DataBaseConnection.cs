using System;
using System.Data;
using System.Data.SqlClient;


namespace Employee_Admin_DB_Connection
{
    public class DataBaseSqlConnection
    {
        //Objects
        /// <summary>
        /// Object to create the connection to the database
        /// </summary>
        private SqlConnection SqlConn = new SqlConnection();
        /// <summary>
        /// This object run the SQL Sentence
        /// </summary>
        private SqlCommand Sqlcmd = new SqlCommand();
        /// <summary>
        /// This object read the SQL Data
        /// </summary>
        private SqlDataReader SqlReader;
        /// <summary>
        /// This object sabe the information of the table of the database
        /// </summary>
        private DataTable Table = new DataTable("Empleados");
        
        //Variables
        /// <summary>
        /// This variable have the connection string information
        /// </summary>        
        private string Connection = "Data Source=FRANK-PC;Initial Catalog=EmployeeAdmon;Integrated Security=True";
        /// <summary>
        /// 
        /// </summary>
        //private string SqlSentence;
        
        //Functions
        /// <summary>
        /// This Function return the information of the information searched on the database
        /// </summary>
        /// <param name="DataSearched"></param>
        /// <returns>Table</returns>
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
