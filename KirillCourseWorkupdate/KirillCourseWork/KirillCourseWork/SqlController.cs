using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KirillCourseWork
{
  public   class SqlController
    {

        protected MySqlConnection Connection;

        public   SqlController()
        {
            //PASSWORD
            //PASSWORD
            //PASSWORD
            string PASSWORD = "root";
            //PASSWORD
            //PASSWORD
            //PASSWORD
            string connectionString = "Server=127.0.0.1;Database=library;port=3306;User Id=root;password="+PASSWORD;
            SetDbConnection(connectionString);
        }

        public  SqlController(string connectionString)
        {
            SetDbConnection(connectionString);
        }

        public void SetDbConnection(string connectionString)
        {
            try
            {
               Connection = new MySqlConnection(connectionString);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                Connection = null;
            }
           
        }

        public List<List<string>> Query(string request)
        {
            if (Connection != null)
            {
                MySqlCommand command = new MySqlCommand(request,Connection);
                return GetQueryDate(command);
            }
            else
                return new List<List<string>>();
        }

        public List<Dictionary<string, string>> QueryWithNames(string request)
        {
            if (Connection != null)
            {
                MySqlCommand command = new MySqlCommand(request,Connection);
                return GetQueryDateWithNames(command);
            }
            else
                return new List<Dictionary<string, string>>();
        }

        public bool Request(string request)
        {
            if (Connection != null)
            {
                MySqlCommand command = new MySqlCommand(request, Connection);
                return RequestCommand(command);
            }
            else
                return false;
        }

        protected List<List<string>> GetQueryDate(MySqlCommand command)
        {
            command.Connection.Open();
            List<List<string>> result = new List<List<string>>();
            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new List<string>());
                        for (int i = 0; i < reader.FieldCount; i++)
                            result.Last().Add(reader[i].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                result.Clear();
            }
            command.Connection.Close();
            return result;
        }

        protected  List<Dictionary<string, string>> GetQueryDateWithNames(MySqlCommand command)
        {
            command.Connection.Open();
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            try { 
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                    while (reader.Read())
                    {
                        result.Add(new Dictionary<string, string>());
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result.Last().Add(reader.GetName(i).ToString(), reader[i].ToString());
                        }
                    }
            }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                result.Clear();
            }
            command.Connection.Close();
            return result;
        }

        protected bool RequestCommand(MySqlCommand command)
        {
            command.Connection.Open();
            bool result = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                result = false;
            }
            command.Connection.Close();
            return result;
        }

    }
}
