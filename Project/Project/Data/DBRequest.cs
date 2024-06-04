using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace Project.Data
{
    public class DBRequest
    {
        private static string connectionString= "Server=DESKTOP-CR4D2CM\\SQLEXPRESS;Database=DiplomProject;Trusted_Connection=True;";
        private static SqlConnection connection= new SqlConnection(connectionString);
        public string ConnectiongString { set { connectionString = value; } }
        public DBRequest(string connString)
        {
            ConnectiongString = connString;
            connection = new SqlConnection(connString);
        }
        public static List<T> Select<T>(string TableName)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query= QueryCreator.CreateSelect(TableName);
            var select = connection.Query<T>(query).ToList();
            connection.Close();
            if (select != null)
                return select;
            else
                return new List<T>();
        }
        public static List<T> Select<T>(string TableName, string OrderParam)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = QueryCreator.CreateSelect(TableName, OrderParam);
            var select = connection.Query<T>(query).ToList();
            connection.Close();
            if (select != null)
                return select;
            else
                return new List<T>();
        }
        public static List<T> Select<T>(string TableName, List<QueryParametr> param)
        {
            connection=new SqlConnection(connectionString);
            connection.Open();
            string query = QueryCreator.CreateSelect(TableName, param);
            var select = connection.Query<T>(query).ToList();
            connection.Close();
            return select;
        }
        public static List<T> Select<T>(string TableName, List<QueryParametr> param, string OrderParam)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = QueryCreator.CreateSelect(TableName, param,OrderParam);
            var select = connection.Query<T>(query).ToList();
            connection.Close();
            return select;
        }
        public static void Insert(string TableName, BDItem item) 
        {
            connection = new SqlConnection(connectionString);
            using (IDbConnection db = connection)
            {
                var sqlquery = QueryCreator.CreateInsert(TableName, item);
                db.Execute(sqlquery, item);
            }
         }
        public static int Insert(string TableName, BDItem item,bool key)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = QueryCreator.CreateInsert(TableName ,item,key);
            var select = connection.Query<int>(query,item).ToList();
            connection.Close();
            return select[0];
        }
        public static void Update(string TableName, BDItem item)
        {
            connection = new SqlConnection(connectionString);
            using (IDbConnection db = connection)
            {
                var sqlquery = QueryCreator.CreateUpdate(TableName, item);
                db.Execute(sqlquery, item);
            }
        }
        public static void Delete(string TableName, List<QueryParametr> param)
        {
            connection = new SqlConnection(connectionString);
            using (IDbConnection db = connection)
            {
                var sqlquery = QueryCreator.CreateDelete(TableName, param);
                db.Execute(sqlquery);
            }
        }

    }
}
