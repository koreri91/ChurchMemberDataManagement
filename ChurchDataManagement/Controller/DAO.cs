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
        private string DBName = "datasource.db";

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

        #region EducationFunctionSQL
        public List<Education> getEducations()
        {
            List<Education> categories = new List<Education>();
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "SELECT * FROM t_education ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                trans.Commit();
                SQLiteDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Education(reader.GetInt32(0),
                        reader.GetString(1), reader.GetString(2)));
                }
            }
            return categories;
        }

        public bool InsertEducation(Education edu)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "INSERT INTO t_education(education_level,description) " +
                    " VALUES (@edu,@desc)";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@edu",edu.EducationLevel);
                comm.Parameters.AddWithValue("@desc", edu.Description);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateEducation(Education edu, int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "UPDATE t_education SET education_level=@edu,description=@desc WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@edu", edu.EducationLevel);
                comm.Parameters.AddWithValue("@desc", edu.Description);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteEducation(int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "DELETE FROM t_education WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        #endregion

        #region ProfessionFunctionSQL
        public List<Profession> getProfessions()
        {
            List<Profession> categories = new List<Profession>();
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "SELECT * FROM t_profession ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                trans.Commit();
                SQLiteDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Profession(reader.GetInt32(0),
                        reader.GetString(1), reader.GetString(2)));
                }
            }
            return categories;
        }

        public bool InsertProfession(Profession profession)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "INSERT INTO t_profession(title,description) " +
                    " VALUES (@title,@desc)";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@title", profession.Title);
                comm.Parameters.AddWithValue("@desc", profession.Description);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateProfession(Profession profession, int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "UPDATE t_profession SET title=@edu,description=@desc WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@edu", profession.Title);
                comm.Parameters.AddWithValue("@desc", profession.Description);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteProfession(int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "DELETE FROM t_profession WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        #endregion

        #region StatusInFamilyFunctionSQL
        public List<StatusInFamily> getStatusInFamily()
        {
            List<StatusInFamily> categories = new List<StatusInFamily>();
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "SELECT * FROM t_statusinfamily ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                trans.Commit();
                SQLiteDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new StatusInFamily(reader.GetInt32(0),
                        reader.GetString(1), reader.GetString(2)));
                }
            }
            return categories;
        }

        public bool InsertStatusInFamily(StatusInFamily status)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "INSERT INTO t_statusinfamily(status_name,description) " +
                    " VALUES (@status_name,@desc)";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@status_name", status.StatusName);
                comm.Parameters.AddWithValue("@desc", status.Description);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateStatusInFamily(StatusInFamily status, int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "UPDATE t_statusinfamily SET status_name=@status,description=@desc WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@status_name", status.StatusName);
                comm.Parameters.AddWithValue("@desc", status.Description);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteStatusInFamily(int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "DELETE FROM t_statusinfamily WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        #endregion


        #region PositionInChurchFunctionSQL
        public List<PositionInChurch> getPositionsInChurch()
        {
            List<PositionInChurch> categories = new List<PositionInChurch>();
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "SELECT * FROM t_positioninchurch ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                trans.Commit();
                SQLiteDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new PositionInChurch(reader.GetInt32(0),
                        reader.GetString(1), reader.GetString(2)));
                }
            }
            return categories;
        }

        public bool InsertPositionInChurch(PositionInChurch position)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "INSERT INTO t_positioninchurch(position_name,description) " +
                    " VALUES (@status_name,@desc)";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@status_name", position.PositionName);
                comm.Parameters.AddWithValue("@desc", position.Description);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdatePositionInChurch(PositionInChurch position, int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "UPDATE t_positioninchurch SET position_name=@position_name,description=@desc WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@position_name", position.PositionName);
                comm.Parameters.AddWithValue("@desc", position.Description);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        public bool DeletePositionInChurch(int id)
        {
            using (SQLiteTransaction trans = sqliteConn.BeginTransaction())
            {
                string query = "DELETE FROM t_positioninchurch WHERE id=@id ";
                SQLiteCommand comm = new SQLiteCommand(query, sqliteConn);
                comm.Parameters.AddWithValue("@id", id);
                trans.Commit();
                return comm.ExecuteNonQuery() > 0;
            }
        }
        #endregion


    }
}
