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
    public partial class AddAuthorForm : MainController
    {

        int Id;
    
        public AddAuthorForm():base()
        {
            InitializeComponent();
            Id = 0;

            Personalization();
        }

        public AddAuthorForm(Dictionary<string, string> info):base()
        {
            InitializeComponent();
            Personalization();
            this.Text = "Изменить";
            Add.Text = "Изменить";
            Id = Convert.ToInt32(info["Id"]);
            FnameText.Text = info["Fname"];
            LnameText.Text = info["Lname"];
            BornText.Value = Convert.ToDateTime( info["Born"]).Year;
            AdresText.Text = info["Adres"];
        }

        private void Done_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (FnameText.Text.Length < 1) { Error("Не правильно введено имя"); return true; }; return false; });
            tests.Add(delegate () { if (LnameText.Text.Length < 1) { Error("Не правильно введена фамилия"); return true; }; return false; });
           tests.Add(delegate () { if (AdresText.Text.Length < 3) { Error("Не правильно введен адрес"); return true; }; return false; });
            if (CheckTest(tests.ToArray()))
            {
                if (Id != 0)
                    Controller.UpdateIn(SpecialSqlController.Tables.authors, new List<string> { LnameText.Text, FnameText.Text, AdresText.Text, BornText.Text+"-01-01"},Id.ToString());

                else
                    Controller.InsertIn(SpecialSqlController.Tables.authors, new List<string> { LnameText.Text, FnameText.Text, AdresText.Text, BornText.Text + "-01-01" });
                this.Close();
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
