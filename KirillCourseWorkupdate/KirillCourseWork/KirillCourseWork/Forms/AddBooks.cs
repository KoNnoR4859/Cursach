using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirillCourseWork
{
    public partial class AddBooks :MainController
    {
        List<List<string>> Publishers;
        List<List<string>> Authors;
        List<List<string>> Jenres;
        List<List<string>> Themes;
        int Id;
        public AddBooks():base()
        {
            InitializeComponent();
            Id = 0;
            Jenres = new List<List<string>>();
            Themes = new List<List<string>>();
            Authors = new List<List<string>>();
            Publishers = new List<List<string>>();
            PublisherText.DropDownStyle = ComboBoxStyle.DropDownList;
            Actions();
            Personalization();
        }

        public AddBooks(Dictionary<string,string> info):base()
        {
            InitializeComponent();
            Jenres = new List<List<string>>();
            Themes = new List<List<string>>();
            Authors = new List<List<string>>();
            Publishers = new List<List<string>>();
            PublisherText.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Text = Add.Text = "Изменить";
            Id = Convert.ToInt32(info["Id"]);
            Actions();
            NameText.Text = info["Names"];
            CountText.Value = Convert.ToInt32( info["Count"]);
            CountText.Value = Convert.ToInt32( info["Count"]);
            DateText.Value = Convert.ToDateTime(info["DateP"]);
            if (!Publishers.Any(x => x[0] == info["Publisher"]))
                Publishers.Add(Controller.TakeRowById(SpecialSqlController.Tables.publishers, Convert.ToInt32(info["Publisher"])));
                PublisherText.SelectedIndex = Publishers.IndexOf(Publishers.First(x => x[0] == info["Publisher"]));

           var d = Controller.GetAllFrom(SpecialSqlController.Tables.authors_books, "Book=" + Id.ToString());
            foreach(var i in d)
            {
                if (!Authors.Any(x => x[0] == i[2]))
                    Authors.Add(Controller.TakeRowById(SpecialSqlController.Tables.authors, Convert.ToInt32(i[2])));
               AuthorsFiltr.SetItemChecked(Authors.IndexOf(Authors.First(x => x[0] == i[2])),true) ;
            }

            d = Controller.GetAllFrom(SpecialSqlController.Tables.jenres_books, "Book=" + Id.ToString());
            foreach (var i in d)
            {
                if (!Jenres.Any(x => x[0] == i[2]))
                    Jenres.Add(Controller.TakeRowById(SpecialSqlController.Tables.jenres, Convert.ToInt32(i[2])));
                JenreFiltr.SetItemChecked(Jenres.IndexOf(Jenres.First(x => x[0] == i[2])), true);
            }

            d = Controller.GetAllFrom(SpecialSqlController.Tables.themes_books, "Book=" + Id.ToString());
            foreach (var i in d)
            {
                if (!Themes.Any(x => x[0] == i[2]))
                    Themes.Add(Controller.TakeRowById(SpecialSqlController.Tables.themes, Convert.ToInt32(i[2])));
                ThemesFiltr.SetItemChecked(Themes.IndexOf(Themes.First(x => x[0] == i[2])), true);
            }
            Personalization();
        }
        public override void  Actions()
        {
            DateText.MaxDate = DateTime.Now;
            Jenres.Clear();
            Authors.Clear();
            Publishers.Clear();
            Themes.Clear();
            AuthorsFiltr.Items.Clear();
            List<List<string>> data = Controller.GetAllFrom(SpecialSqlController.Tables.authors);
            foreach (var a in data)
                AuthorsFiltr.Items.Add(a[1]);
            Authors.AddRange(data);
            JenreFiltr.Items.Clear();
            data = Controller.GetAllFrom(SpecialSqlController.Tables.jenres);
            foreach (var a in data)
                JenreFiltr.Items.Add(a[1]);
            Jenres.AddRange(data);
            ThemesFiltr.Items.Clear();
            data = Controller.GetAllFrom(SpecialSqlController.Tables.themes);
            foreach (var a in data)
                ThemesFiltr.Items.Add(a[1]);
            Themes.AddRange(data);
           PublisherText.Items.Clear();
            data = Controller.GetAllFrom(SpecialSqlController.Tables.publishers);
            foreach (var a in data)
                PublisherText.Items.Add(a[1]);
            Publishers.AddRange(data);
   
        }



        private void Add_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (NameText.Text.Length < 1) { Error("Не правильно введено название"); return true; }; return false; });
            tests.Add(delegate () { if (PublisherText.SelectedIndex < 0) { Error("Издательство не выбрано "); return true; }; return false; });
            tests.Add(delegate () { if (JenreFiltr.CheckedItems.Count == 0) { Error("Жанры не выбраны "); return true; }; return false; });
            tests.Add(delegate () { if (AuthorsFiltr.CheckedItems.Count == 0) { Error("Авторы не выбраны "); return true; }; return false; });
            tests.Add(delegate () { if (ThemesFiltr.CheckedItems.Count == 0) { Error("Темы не выбраны "); return true; }; return false; });
            if (CheckTest(tests.ToArray()))
            {
                List<string> a = new List<string>();
                foreach (int i in AuthorsFiltr.CheckedIndices)
                    a.Add(Authors[i][0]);

                List<string> j = new List<string>();
                foreach (int i in JenreFiltr.CheckedIndices)
                    j.Add(Jenres[i][0]);

                List<string> t = new List<string>();
                foreach (int i in ThemesFiltr.CheckedIndices)
                    t.Add(Themes[i][0]);
                if (Id == 0)
                {
                  
                    Controller.InsertIn(SpecialSqlController.Tables.books, new List<string> { NameText.Text, CountText.Value.ToString(), Publishers[PublisherText.SelectedIndex][0], PlaceText.Value.ToString(), DateText.Text },a,j,t);
                }
                else
                {
                    Controller.UpdateMenu(SpecialSqlController.Tables.books, Id.ToString(), new List<string> { NameText.Text, CountText.Value.ToString(), Publishers[PublisherText.SelectedIndex][0], PlaceText.Value.ToString(),DateText.Text }, a, j, t);
                }
                this.Close();
            }
        }






        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Categoryes_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.publishers));
            Publishers.Clear();
            PublisherText.Items.Clear();
            List<List<string>> data = Controller.GetAllFrom(SpecialSqlController.Tables.publishers);
            foreach (var a in data)
                PublisherText.Items.Add(a[1]);
            Publishers.AddRange(data);
        }

        private void AuthorsEdit_Click(object sender, EventArgs e)
        {
            OpenForm(new AuthorsForm());

            Authors.Clear();
            AuthorsFiltr.Items.Clear();
            List<List<string>> data = Controller.GetAllFrom(SpecialSqlController.Tables.authors);
            foreach (var a in data)
                AuthorsFiltr.Items.Add(a[1]);
            Authors.AddRange(data);
        }

        private void JenreEdit_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.jenres));
            Jenres.Clear();
            JenreFiltr.Items.Clear();
            List<List<string>> data = Controller.GetAllFrom(SpecialSqlController.Tables.jenres);
            foreach (var a in data)
                JenreFiltr.Items.Add(a[1]);
            Jenres.AddRange(data);
        }

        private void ThemesChange_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.themes));
            Themes.Clear();
            ThemesFiltr.Items.Clear();
            List<List<string>> data = Controller.GetAllFrom(SpecialSqlController.Tables.themes);
            foreach (var a in data)
                ThemesFiltr.Items.Add(a[1]);
            Themes.AddRange(data);
        }
    }
}
