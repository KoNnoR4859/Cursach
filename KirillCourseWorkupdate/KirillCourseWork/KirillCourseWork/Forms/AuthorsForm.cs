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
    public partial class AuthorsForm : MainController
    {
        int UserId;


        public AuthorsForm() : base()
        {
            InitializeComponent();
   
            Actions();
            Personalization();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.authors, delegate (Dictionary<string, string> row)
            {
                Dictionary<string, string> newRow = new Dictionary<string, string>();
                newRow.Add("Id", row["Id"]);
                newRow.Add("FLName", row["Lname"] + " " + row["Fname"]);
                newRow.Add("Adres", row["Adres"]);
                newRow.Add("Born",Convert.ToDateTime( row["Born"]).Year.ToString());
                return newRow;
            });
        }

        public override void Actions()
        {
            MainAction();
            Job_Filtr.Items.Clear();
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 3;
            List<List<string>> jobs = Controller.Query("select distinct `Adres` from authors");
                foreach (var j in jobs)
            {
                Job_Filtr.Items.Add(j[0]);
            }
           YearFrom.Minimum = YearTo.Minimum =Convert.ToDateTime (Controller.Query("select min(`Born`) from authors")[0][0]).Year;
            YearFrom.Maximum = YearTo.Maximum = Convert.ToDateTime(Controller.Query("select max(`Born`) from authors")[0][0]).Year;
            YearTo.Value = YearTo.Maximum;
            Print(ref Employeers);
        }

        private void Add_Click(object sender, EventArgs e)
        {
       OpenForm (new AddAuthorForm());
            Actions();
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {
                case 0:
                    Sort("Born", -1);
                    break;
                case 1:
                    Sort("Born", 1);
                    break;
                case 2:
                    Sort("FLName", -1);
                    break;
                case 3:
                    Sort("FLName", 1);
                    break;
            }
            Print(ref Employeers);
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !Job_Filtr.CheckedItems.Contains(row["Adres"]) && Job_Filtr.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Born"]) >= Convert.ToInt32(YearFrom.Value) && Convert.ToInt32(row["Born"]) <= Convert.ToInt32(YearTo.Value)); });

            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 3;
            Print(ref Employeers);
        }


        private void Update_Click(object sender, EventArgs e)
        {
            if (RowTest(Employeers))
            {
                string id =GetId(Employeers);
            OpenForm( new AddAuthorForm(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.authors,Convert.ToInt32(id))));
                Actions();
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(GetId(Employeers)) != UserId)
         Hiding(Employeers, SpecialSqlController.Tables.authors);

        }

        private void YearTo_ValueChanged(object sender, EventArgs e)
        {
            YearTo.Minimum = YearFrom.Value;
            YearFrom.Maximum = YearTo.Value;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }
    }
}
