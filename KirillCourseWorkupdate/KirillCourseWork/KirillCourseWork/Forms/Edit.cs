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
    public partial class Edit : MainController
    {
        SpecialSqlController.Tables Table;
 

        public Edit() : base() => InitializeComponent();
        

        public Edit(SpecialSqlController.Tables table) : base()
        {
            InitializeComponent();
            Table = table;
            Actions();
            Personalization();
        }

        public override void MainAction()
        {
            GetData(Table);
        }

        public override void Actions()
        {
            MainAction();
            ChangeText.Text = "";
            Print(ref Rows);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Hiding(Rows, Table);       
        }

        private void Add_Click(object sender, EventArgs e)
        {

            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate(){ if (AddText.Text.Length < 3) { Error("Не правильное название"); return true; } return false; });
            if (CheckTest(tests.ToArray()))
            if (Controller.BackFromHistory(Table, AddText.Text))
            {
                Actions();
                AddText.Clear();
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Rows))
            {
               
                string id = GetId(Rows);
                List<TestValid> tests = new List<TestValid>();
                tests.Add(delegate () { if (ChangeText.Text.Length < 5) { Error("Не правильное название"); return true; } return false; });
                if (CheckTest(tests.ToArray()))
                    if (Controller.BackFromHistory(Table, id, ChangeText.Text))
                {
                    Actions();
                    ChangeText.Clear();
                }
            }

        }

        private void Rows_Click(object sender, EventArgs e)
        {
            if (RowTest(Rows,false))
            {
                ChangeText.Text = Rows[1, Rows.SelectedRows[0].Index].Value.ToString();
            }
            else
            {
                ChangeText.Text = "";
            }
        }
    }
}
