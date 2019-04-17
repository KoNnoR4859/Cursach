using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KirillCourseWork;

namespace KirillCourseWork
{
    public partial class LibraryForm : MainController
    {
        public LibraryForm() : base()
        {
            InitializeComponent();
            Actions();

            Personalization();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.books, delegate (ref List<Dictionary<string, string>> data)
            {
                for (int g = 0; g < data.Count; g++)
                {
                    var aut = Controller.GetAllFrom(SpecialSqlController.Tables.authors_books,$" `Book`={data[g]["Id"]}");
                    string authors = "";
                    foreach(var a in aut)
                    {
                        authors += Controller.TakeRowById(SpecialSqlController.Tables.authors, int.Parse(a[2]))[1]+"  ";
                    }
                    data[g].Add("Authors", authors);

                    aut = Controller.GetAllFrom(SpecialSqlController.Tables.jenres_books, $" `Book`={data[g]["Id"]}");
                    string jenres = "";
                    foreach (var a in aut)
                    {
                        jenres += Controller.TakeRowById(SpecialSqlController.Tables.jenres, int.Parse(a[2]))[1] + "  ";
                    }
                    data[g].Add("Jenres", jenres);

                     aut = Controller.GetAllFrom(SpecialSqlController.Tables.themes_books, $" `Book`={data[g]["Id"]}");
                    string cat = "";
                    foreach (var a in aut)
                    {
                        cat += Controller.TakeRowById(SpecialSqlController.Tables.themes, int.Parse(a[2]))[1] + "  ";
                    }
                    data[g].Add("Category", cat);
               
                    string[] s = data[g]["DateP"].Split(' ')[0].Split('.');
                    data[g]["DateP"] = s[2] + "." + s[1] + "." +s[0];
                    data[g]["Publisher"] = Controller.TakeRowById(SpecialSqlController.Tables.publishers, Convert.ToInt32(data[g]["Publisher"]))[1];
                }
            });
        }

        public override void Actions()
        {

            JenreFiltr.Items.Clear();
            //CategoryList.Items.Clear();
            //List<List<string>> cat = Controller.GetAllFrom(SpecialSqlController.Tables.categoryeat, "Enable=1");
            //foreach (var c in cat)
            //    CategoryList.Items.Add(c[1]);
           AuthorsFiltr.Items.Clear();
            List<List<string>> data = Controller.GetAllFrom(SpecialSqlController.Tables.authors);
            foreach (var a in data)
               AuthorsFiltr.Items.Add(a[1]);

            JenreFiltr.Items.Clear();
            data = Controller.GetAllFrom(SpecialSqlController.Tables.jenres);
            foreach (var a in data)
                JenreFiltr.Items.Add(a[1]);

           ThemesFiltr.Items.Clear();
            data = Controller.GetAllFrom(SpecialSqlController.Tables.themes);
            foreach (var a in data)
              ThemesFiltr.Items.Add(a[1]);

           PublishersFiltr.Items.Clear();
            data = Controller.GetAllFrom(SpecialSqlController.Tables.publishers);
            foreach (var a in data)
                PublishersFiltr.Items.Add(a[1]);
            Search.Text = "";
            CountFrom.Minimum = CountTo.Minimum = (Controller.Minimum(SpecialSqlController.Tables.books, "Count"));
            CountFrom.Maximum = CountTo.Maximum = (Controller.Maximum(SpecialSqlController.Tables.books, "Count"));
            CountTo.Value = CountTo.Maximum;
            MainAction();
            PlaceNum.Maximum = Controller.Maximum(SpecialSqlController.Tables.books,"PlaceNumber");
            PlaceNum.Minimum = Controller.Minimum(SpecialSqlController.Tables.books,"PlaceNumber");
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 9;
            Print(ref Dishes);
        }

        private void Add_Click(object sender, EventArgs e)
        {
           OpenForm( new AddBooks());
            Actions();
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (SortPanel.SelectedIndex)
            {
                case 0:
                    Sort("Authors", -1);
                    break;
                case 1:
                    Sort("Authors", 1);
                    break;
                case 2:
                    Sort("DateP", -1);
                    break;
                case 3:
                    Sort("DateP", 1);
                    break;
                case 4:
                    Sort("Jenres", -1);
                    break;
                case 5:
                    Sort("Jenres", 1);
                    break;
                case 8:
                    Sort("Names", -1);
                    break;
                case 9:
                    Sort("Names", 1);
                    break;
                case 6:
                    Sort("Count", -1);
                    break;
                case 7:
                    Sort("Count", 1);
                    break;
            }
            Print(ref Dishes);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Hiding(Dishes, SpecialSqlController.Tables.books,Dishes.SelectedRows.Count);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Dishes))
            {
                string id = GetId(Dishes);
                OpenForm(new AddBooks(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.books, Convert.ToInt32(id))));
                Actions();
            }
        }



        private void CostFrom_ValueChanged(object sender, EventArgs e)
        {
            CountTo.Minimum = CountFrom.Value;
            CountFrom.Maximum = CountTo.Value;
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !PublishersFiltr.CheckedItems.Contains(row["Publisher"]) && PublishersFiltr.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return  PlaceNum.Value.ToString()!=row["PlaceNumber"]; });
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Count"]) >= Convert.ToInt32(CountFrom.Value) && Convert.ToInt32(row["Count"]) <= Convert.ToInt32(CountTo.Value)); });
         tags.Add(delegate (Dictionary<string, string> row) {

                for (int i = 0; i < AuthorsFiltr.CheckedItems.Count; i++)
                    if (!row["Authors"].ToLower().Contains(AuthorsFiltr.CheckedItems[i].ToString().ToLower()))
                        return true;
                    return false;
            });

            tags.Add(delegate (Dictionary<string, string> row) {

                for (int i = 0; i < JenreFiltr.CheckedItems.Count; i++)
                    if (!row["Jenres"].ToLower().Contains(JenreFiltr.CheckedItems[i].ToString().ToLower()))
                        return true;
                return false;
            });

            tags.Add(delegate (Dictionary<string, string> row) {

                for (int i = 0; i < ThemesFiltr.CheckedItems.Count; i++)
                    if (!row["Category"].ToLower().Contains(ThemesFiltr.CheckedItems[i].ToString().ToLower()))
                        return true;
                return false;
            });

            tags.Add(delegate (Dictionary<string, string> row) {
             return   (row["Names"].Replace(" ", "").ToLower() != Search.Text.Replace(" ", "").ToLower()&& Search.Text.Replace(" ", "").Length>0);
            });

            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 9;
            Print(ref Dishes);
            if (DataList.Count == 0)
                Error("Книг с такими критериями в библиотеке нет");
        }

        private void AuthorsEdit_Click(object sender, EventArgs e)
        {
            OpenForm(new AuthorsForm());
            Actions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.jenres));
            Actions();
        }

        private void ThemesChange_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.themes));
            Actions();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.publishers));
            Actions();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
