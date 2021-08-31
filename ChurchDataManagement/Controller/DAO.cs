using ChurchDataManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;

namespace ChurchDataManagement.Controller
{
    public class DAO
    {
        public DAO() {
            
        }

        private SQLiteConnection sqliteConn;
        private String DBName = "datasource.db";

        private bool checkIfDBExists() {            
            return File.Exists(DBName);
        }

        public void open() {
            if (!checkIfDBExists())
            {
                this.createDB();
            }
            else {
                this.sqliteConn = new SQLiteConnection(
               "Data Source=" + DBName + ";");
                this.sqliteConn.Open();
            }
        }
        private SQLiteConnection createDB() {
            // Create a new database connection:
            sqliteConn = new SQLiteConnection(
                "Data Source="+DBName+"; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqliteConn.Open();
                Console.WriteLine("Open database");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally { 
                
            }
            return sqliteConn;
        }

        #region CategoryFunctionSQL
  public List<Category> getCategories() {
            List<Category> categories = new List<Category>();
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "SELECT * FROM t_category ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                trans.Commit();
                SQLiteDataReader reader =  comm.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Category(reader.GetInt32(0),
                        reader.GetString(1), reader.GetString(2)));
                }
            }
            return categories;
        }

        public bool InsertCategory(Category cat)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "INSERT INTO t_category(category_name,description) "+
                    " VALUES (@name,@desc)";
                SQLiteCommand comm= new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@name", cat.CategoryName);
                comm.Parameters.AddWithValue("@desc", cat.Description);
               trans.Commit();
                return comm.ExecuteNonQuery() > 0;                
            }
        }

        public bool UpdateCategory(Category cat,int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "UPDATE t_category SET category_name=@name,description=@desc WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@name", cat.CategoryName);
                comm.Parameters.AddWithValue("@desc", cat.Description);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteCategory(int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "DELETE FROM t_category WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }



        #endregion


    }
}
