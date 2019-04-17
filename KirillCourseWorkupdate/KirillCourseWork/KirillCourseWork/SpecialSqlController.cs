using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;

namespace KirillCourseWork
{
    public class SpecialSqlController : SqlController
    {
        public SpecialSqlController() : base() { }

        public SpecialSqlController(string connectionString) : base(connectionString) { }

        public enum Tables
        {
            authors=0,
            authors_books=1,
            jenres=2,
            jenres_books,
                publishers,
            themes,
            themes_books,
            books
        }

        public List<string> ColumnsNames(MySqlCommand command)
        {
            command.Connection.Open();
            List<string> result = new List<string>();
            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        result.Add(reader.GetName(i));

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

        public List<string> GetColumnsNames(Tables table)
        {
            if (Connection != null)
            {

                string text = "select * from " + table.ToString() + " limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return ColumnsNames(command);
            }
            else
                return new List<string>();
        }

        public List<List<string>> GetAllFrom(Tables table, string where = "Enable=1")
        {
            if (Connection != null)
            {

                string text = "select * from " + table.ToString() + " where " + where;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return GetQueryDate(command);
            }
            else
                return new List<List<string>>();
        }

        public List<Dictionary<string, string>> GetAllFromWithNames(Tables table, string where = "Enable=1")
        {
            if (Connection != null)
            {
                string text = "select * from " + table.ToString() + " where (" + where + ")";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return GetQueryDateWithNames(command);
            }
            else
                return new List<Dictionary<string, string>>();
        }

        public bool InsertIn(Tables table, List<string> values, string startAfter = "Id",bool deleteLast=true)
        {
            if (Connection != null)
            {
                string columns = "(";
                string value = "(";
                List<string> names = GetColumnsNames(table);
                for (int i = 0; i <= names.IndexOf(startAfter); i++)
                {
                    names.RemoveAt(i);
                    i--;
                }
                if (deleteLast)
                names.Remove(names.Last());
                if (names.Count <= 1)
                    return false;
                for (int i = 0; i < names.Count; i++)
                {
                    columns += "`" + names[i] + "`";
                    if (i != names.Count - 1)
                        columns += ",";
                    else
                        columns += ")";
                }
                if (values.Count < names.Count - 1)
                    return false;
                for (int i = 0; i < values.Count; i++)
                {
                    int type = 0;
                    if (values[i] == null) type = 2;
                    if (type == 2)
                        value += "null";
                    else
                        value += "'" + values[i] + "'";

                    if (i != values.Count - 1)
                        value += ",";
                    else
                        value += ")";
                }
                string text = "Insert into " + "`" + table.ToString() + "`" + " " + columns + " values" + value;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
                return false;

        }

        public bool UpdateIn(Tables table, List<string> values, string id)
        {
            if (Connection != null)
            {
                string value = "";
                List<string> names = GetColumnsNames(table);
                names.RemoveAt(0);
                if (names.Count <= 1)
                    return false;
                for (int i = 0; i < values.Count; i++)
                {
                    value += $"`{names[i]}`=";
                    int type = 0;
                    if (values[i] == null) type = 2;
                    if (type == 2)
                        value += "null";
                    else
                        value += "'" + values[i] + "'";

                    if (i != values.Count - 1)
                        value += ",";
                }
                string text = "UPDATE " + "`" + table.ToString() + "` set " + value + " where Id=" + id;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
                return false;

        }

        public bool DeleteFrom(Tables table, int id)
        {
            if (Connection != null)
            {
                string text = "delete from " + "`" + table.ToString() + "`" + "where Id=" + id;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
            {
                return false;
            }
        }

        public bool DeleteFrom(Tables table, string where)
        {
            if (Connection != null)
            {
                string text = "delete from `" + table.ToString() + "` where(" + where + ")";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
            {
                return false;
            }
        }

        public bool DeleteToHistory(Tables table, int id)
        {
            if (Connection != null)
            {
                string text = "Update " + "`" + table.ToString() + "`  SET `Enable` = '0' WHERE(`Id` = '" + id.ToString() + "')";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
            {
                return false;
            }
        }

        public List<string> TakeRow(Tables table, string where)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where " + where + " limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count != 0)
                    return result.First();
                else
                    return new List<string>();
            }
            else
                return new List<string>();
        }

        public Dictionary<string, string> TakeRowWithNames(Tables table, string where)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where " + where + " limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<Dictionary<string, string>> result = GetQueryDateWithNames(command);
                if (result.Count != 0)
                    return result.First();
                else
                    return new Dictionary<string, string>();
            }
            else
                return new Dictionary<string, string>();
        }

        public Dictionary<string, string> TakeRowWithNamesById(Tables table, int id)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where Id= '" + id + "' limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<Dictionary<string, string>> result = GetQueryDateWithNames(command);
                if (result.Count != 0)
                    return result.First();
                else
                    return new Dictionary<string, string>();
            }
            else
                return new Dictionary<string, string>();
        }

        public List<string> TakeRowById(Tables table, int id)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where Id='" + id + "' limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count != 0)
                    return result.First();
                else
                    return new List<string>();
            }
            else
                return new List<string>();
        }

        public int Maximum(Tables table, string columnname)
        {
            if (Connection != null)
            {
                string text = "select max(" + columnname + ") from " + table.ToString() + " where Enable = 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count > 0 && result[0].Count > 0)
                    try
                    {
                        return Convert.ToInt32(result[0][0]);
                    }
                    catch
                    {
                        return 0;
                    }
                else
                    return 0;
            }
            else
                return 0;
        }

        public int Minimum(Tables table, string columnname)
        {
            if (Connection != null)
            {
                string text = "select min(" + columnname + ") from " + table.ToString() + " where Enable = 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count > 0 && result[0].Count > 0)
                    try
                    {
                        return Convert.ToInt32(result[0][0]);
                    }
                    catch
                    {
                        return 0;
                    }
                else
                    return 0;
            }
            else
                return 0;
        }

        public bool BackFromHistory(Tables table, string name)
        {
            if (Connection != null)
            {
                if (TakeRow(table, "Enable=0 and `Names`='" + name + "'").Count > 0)
                {
                    string text = "Update " + "`" + table.ToString() + "`  SET `Enable` = '1' WHERE(`Names` = '" + name + "')";
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    return RequestCommand(command);
                }
                else
                {

                    string text = "Insert into " + "`" + table.ToString() + "` (`Names`) values ('" + name + "')";
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    return RequestCommand(command);

                }
            }
            else
                return false;
        }

        public bool BackFromHistory(Tables table, string id, string name)
        {
            if (Connection != null)
            {
                string text = "Update " + "`" + table.ToString() + "`  SET `Names` = '" + name + "' WHERE(`Id` = '" + id.ToString() + "' and `Enable` = '1')";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);



            }
            else
                return false;
        }

        public bool UpdateCell(Tables table, string update, string where)
        {
            if (Connection != null)
            {
                string text = "Update " + "`" + table.ToString() + "`  SET " + update+ " WHERE( "+where+" )";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);



            }
            else
                return false;
        }

        public bool InsertIn(Tables table, List<string> values, List<string> a, List<string> j, List<string> t, bool deletelast=true)
        {
            if (Connection != null)
            {
                return InsertIn(table, values, deleteLast: deletelast) && Additional(a, Tables.authors_books) && Additional(t, Tables.themes_books) && Additional(j, Tables.jenres_books);
            }
            else
                return false;

        }

        public bool UpdateMenu(Tables table, string id, List<string> values, List<string> a, List<string> j, List<string> t)
        {
            if (Connection != null)
            {
                return UpdateIn(table, values, id) && Additional(a, Tables.authors_books) && Additional(t, Tables.themes_books) && Additional(j, Tables.jenres_books);
            }
            else
                return false;

        }
        public bool Additional(List<string> ingredients, Tables table, string id = null)
        {
            if (Connection != null)
            {
                Thread.Sleep(500);

                id = id ?? Maximum(Tables.books, "Id").ToString();
                string where = "";
                where = "`Book`=" + id;
                string column = GetColumnsNames(table).Last();
                DeleteFrom(table, where);
                foreach (var i in ingredients)
                {
                    string text = "";
                    text = $"Insert into `{table}`  ( `Book`, `{column}` ) values  " +
                    "('" + id + "', '" + i + "')";
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    if (!RequestCommand(command))
                        return false;
                }
                return true;


            }
            else
                return false;
        }
    }
}

