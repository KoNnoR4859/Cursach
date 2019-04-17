namespace KirillCourseWork
{
    partial class LibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dishes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.JenreFiltr = new System.Windows.Forms.CheckedListBox();
            this.ThemesFiltr = new System.Windows.Forms.CheckedListBox();
            this.JenreLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Filtr = new System.Windows.Forms.Button();
            this.CountFrom = new System.Windows.Forms.NumericUpDown();
            this.CountTo = new System.Windows.Forms.NumericUpDown();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AuthorsFiltr = new System.Windows.Forms.CheckedListBox();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.AuthorsEdit = new System.Windows.Forms.Button();
            this.JenreEdit = new System.Windows.Forms.Button();
            this.ThemesLabel = new System.Windows.Forms.Label();
            this.ThemesChange = new System.Windows.Forms.Button();
            this.PublishersEdit = new System.Windows.Forms.Button();
            this.PublishersLabel = new System.Windows.Forms.Label();
            this.PublishersFiltr = new System.Windows.Forms.CheckedListBox();
            this.PlaceNum = new System.Windows.Forms.NumericUpDown();
            this.PlaceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Dishes
            // 
            this.Dishes.AllowUserToAddRows = false;
            this.Dishes.AllowUserToDeleteRows = false;
            this.Dishes.AllowUserToResizeColumns = false;
            this.Dishes.AllowUserToResizeRows = false;
            this.Dishes.BackgroundColor = System.Drawing.Color.LightBlue;
            this.Dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Count,
            this.PlaceNumber,
            this.Authors,
            this.Category,
            this.Jenres,
            this.Publisher,
            this.DateP});
            this.Dishes.Location = new System.Drawing.Point(20, 246);
            this.Dishes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dishes.Name = "Dishes";
            this.Dishes.RowHeadersVisible = false;
            this.Dishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dishes.Size = new System.Drawing.Size(959, 260);
            this.Dishes.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Название";
            this.Names.Name = "Names";
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Names.Width = 70;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Count.Width = 83;
            // 
            // PlaceNumber
            // 
            this.PlaceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PlaceNumber.HeaderText = "Номер полки";
            this.PlaceNumber.Name = "PlaceNumber";
            this.PlaceNumber.ReadOnly = true;
            this.PlaceNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PlaceNumber.Width = 91;
            // 
            // Authors
            // 
            this.Authors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Authors.HeaderText = "Авторы";
            this.Authors.Name = "Authors";
            this.Authors.ReadOnly = true;
            this.Authors.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Authors.Width = 58;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Category.HeaderText = "Тематика";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category.Width = 68;
            // 
            // Jenres
            // 
            this.Jenres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Jenres.HeaderText = "Жанр";
            this.Jenres.Name = "Jenres";
            this.Jenres.ReadOnly = true;
            this.Jenres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jenres.Width = 46;
            // 
            // Publisher
            // 
            this.Publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Publisher.HeaderText = "Издательство";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 112;
            // 
            // DateP
            // 
            this.DateP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DateP.HeaderText = "Дата печати";
            this.DateP.Name = "DateP";
            this.DateP.ReadOnly = true;
            this.DateP.Width = 103;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1008, 444);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(114, 62);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(38, 209);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(99, 16);
            this.Sort_label.TabIndex = 4;
            this.Sort_label.Text = "Сортировать по";
            // 
            // SortPanel
            // 
            this.SortPanel.DisplayMember = "0";
            this.SortPanel.FormattingEnabled = true;
            this.SortPanel.Items.AddRange(new object[] {
            "автору от большего",
            "автору от меньшего",
            "дате печати от большего",
            "дате печати от меньшего",
            "жанру от большего",
            "жанру от меньшего",
            "количество от большего",
            "количество от меньшего",
            "названию от большего",
            "названию от меньшего"});
            this.SortPanel.Location = new System.Drawing.Point(171, 206);
            this.SortPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(264, 24);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 3;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(20, 523);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(87, 28);
            this.Back.TabIndex = 5;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // JenreFiltr
            // 
            this.JenreFiltr.BackColor = System.Drawing.Color.LavenderBlush;
            this.JenreFiltr.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenreFiltr.FormattingEnabled = true;
            this.JenreFiltr.Location = new System.Drawing.Point(349, 39);
            this.JenreFiltr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JenreFiltr.Name = "JenreFiltr";
            this.JenreFiltr.Size = new System.Drawing.Size(273, 84);
            this.JenreFiltr.TabIndex = 8;
            // 
            // ThemesFiltr
            // 
            this.ThemesFiltr.FormattingEnabled = true;
            this.ThemesFiltr.Location = new System.Drawing.Point(635, 39);
            this.ThemesFiltr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThemesFiltr.Name = "ThemesFiltr";
            this.ThemesFiltr.Size = new System.Drawing.Size(285, 84);
            this.ThemesFiltr.TabIndex = 10;
            // 
            // JenreLabel
            // 
            this.JenreLabel.AutoSize = true;
            this.JenreLabel.Location = new System.Drawing.Point(345, 15);
            this.JenreLabel.Name = "JenreLabel";
            this.JenreLabel.Size = new System.Drawing.Size(49, 16);
            this.JenreLabel.TabIndex = 9;
            this.JenreLabel.Text = "Жанры";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(780, 180);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(77, 16);
            this.CountLabel.TabIndex = 14;
            this.CountLabel.Text = "Количество";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(967, 197);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 28);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Filtr
            // 
            this.Filtr.BackColor = System.Drawing.Color.MintCream;
            this.Filtr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Filtr.Location = new System.Drawing.Point(507, 167);
            this.Filtr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(115, 58);
            this.Filtr.TabIndex = 19;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = false;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // CountFrom
            // 
            this.CountFrom.Location = new System.Drawing.Point(771, 199);
            this.CountFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CountFrom.Name = "CountFrom";
            this.CountFrom.Size = new System.Drawing.Size(71, 21);
            this.CountFrom.TabIndex = 20;
            this.CountFrom.ValueChanged += new System.EventHandler(this.CostFrom_ValueChanged);
            // 
            // CountTo
            // 
            this.CountTo.Location = new System.Drawing.Point(862, 199);
            this.CountTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CountTo.Name = "CountTo";
            this.CountTo.Size = new System.Drawing.Size(71, 21);
            this.CountTo.TabIndex = 21;
            this.CountTo.ValueChanged += new System.EventHandler(this.CostFrom_ValueChanged);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(1008, 399);
            this.Change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(94, 38);
            this.Change.TabIndex = 24;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1008, 346);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 38);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AuthorsFiltr
            // 
            this.AuthorsFiltr.FormattingEnabled = true;
            this.AuthorsFiltr.Location = new System.Drawing.Point(30, 39);
            this.AuthorsFiltr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthorsFiltr.Name = "AuthorsFiltr";
            this.AuthorsFiltr.Size = new System.Drawing.Size(283, 84);
            this.AuthorsFiltr.TabIndex = 26;
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Location = new System.Drawing.Point(27, 11);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(52, 16);
            this.AuthorsLabel.TabIndex = 27;
            this.AuthorsLabel.Text = "Авторы";
            // 
            // AuthorsEdit
            // 
            this.AuthorsEdit.Location = new System.Drawing.Point(127, 5);
            this.AuthorsEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthorsEdit.Name = "AuthorsEdit";
            this.AuthorsEdit.Size = new System.Drawing.Size(126, 28);
            this.AuthorsEdit.TabIndex = 28;
            this.AuthorsEdit.Text = "Изменить";
            this.AuthorsEdit.UseVisualStyleBackColor = true;
            this.AuthorsEdit.Click += new System.EventHandler(this.AuthorsEdit_Click);
            // 
            // JenreEdit
            // 
            this.JenreEdit.Location = new System.Drawing.Point(441, 5);
            this.JenreEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JenreEdit.Name = "JenreEdit";
            this.JenreEdit.Size = new System.Drawing.Size(126, 28);
            this.JenreEdit.TabIndex = 29;
            this.JenreEdit.Text = "Изменить";
            this.JenreEdit.UseVisualStyleBackColor = true;
            this.JenreEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThemesLabel
            // 
            this.ThemesLabel.AutoSize = true;
            this.ThemesLabel.Location = new System.Drawing.Point(631, 11);
            this.ThemesLabel.Name = "ThemesLabel";
            this.ThemesLabel.Size = new System.Drawing.Size(62, 16);
            this.ThemesLabel.TabIndex = 30;
            this.ThemesLabel.Text = "Тематика";
            // 
            // ThemesChange
            // 
            this.ThemesChange.Location = new System.Drawing.Point(731, 5);
            this.ThemesChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThemesChange.Name = "ThemesChange";
            this.ThemesChange.Size = new System.Drawing.Size(126, 28);
            this.ThemesChange.TabIndex = 31;
            this.ThemesChange.Text = "Изменить";
            this.ThemesChange.UseVisualStyleBackColor = true;
            this.ThemesChange.Click += new System.EventHandler(this.ThemesChange_Click);
            // 
            // PublishersEdit
            // 
            this.PublishersEdit.Location = new System.Drawing.Point(1060, 5);
            this.PublishersEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PublishersEdit.Name = "PublishersEdit";
            this.PublishersEdit.Size = new System.Drawing.Size(96, 28);
            this.PublishersEdit.TabIndex = 34;
            this.PublishersEdit.Text = "Изменить";
            this.PublishersEdit.UseVisualStyleBackColor = true;
            this.PublishersEdit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PublishersLabel
            // 
            this.PublishersLabel.AutoSize = true;
            this.PublishersLabel.Location = new System.Drawing.Point(944, 11);
            this.PublishersLabel.Name = "PublishersLabel";
            this.PublishersLabel.Size = new System.Drawing.Size(86, 16);
            this.PublishersLabel.TabIndex = 33;
            this.PublishersLabel.Text = "Издательства";
            // 
            // PublishersFiltr
            // 
            this.PublishersFiltr.FormattingEnabled = true;
            this.PublishersFiltr.Location = new System.Drawing.Point(947, 39);
            this.PublishersFiltr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PublishersFiltr.Name = "PublishersFiltr";
            this.PublishersFiltr.Size = new System.Drawing.Size(255, 84);
            this.PublishersFiltr.TabIndex = 32;
            // 
            // PlaceNum
            // 
            this.PlaceNum.Location = new System.Drawing.Point(667, 197);
            this.PlaceNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlaceNum.Name = "PlaceNum";
            this.PlaceNum.Size = new System.Drawing.Size(71, 21);
            this.PlaceNum.TabIndex = 36;
            // 
            // PlaceLabel
            // 
            this.PlaceLabel.AutoSize = true;
            this.PlaceLabel.Location = new System.Drawing.Point(664, 177);
            this.PlaceLabel.Name = "PlaceLabel";
            this.PlaceLabel.Size = new System.Drawing.Size(44, 16);
            this.PlaceLabel.TabIndex = 35;
            this.PlaceLabel.Text = "Полка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Искать";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(171, 161);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(264, 21);
            this.Search.TabIndex = 39;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(1217, 566);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlaceNum);
            this.Controls.Add(this.PlaceLabel);
            this.Controls.Add(this.PublishersEdit);
            this.Controls.Add(this.PublishersLabel);
            this.Controls.Add(this.PublishersFiltr);
            this.Controls.Add(this.ThemesChange);
            this.Controls.Add(this.ThemesLabel);
            this.Controls.Add(this.JenreEdit);
            this.Controls.Add(this.AuthorsEdit);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.AuthorsFiltr);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.CountTo);
            this.Controls.Add(this.CountFrom);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ThemesFiltr);
            this.Controls.Add(this.JenreLabel);
            this.Controls.Add(this.JenreFiltr);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Dishes);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryForm";
            this.Text = "Книги";
            ((System.ComponentModel.ISupportInitialize)(this.Dishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dishes;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.CheckedListBox JenreFiltr;
        private System.Windows.Forms.CheckedListBox ThemesFiltr;
        private System.Windows.Forms.Label JenreLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.NumericUpDown CountFrom;
        private System.Windows.Forms.NumericUpDown CountTo;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.CheckedListBox AuthorsFiltr;
        private System.Windows.Forms.Label AuthorsLabel;
        private System.Windows.Forms.Button AuthorsEdit;
        private System.Windows.Forms.Button JenreEdit;
        private System.Windows.Forms.Label ThemesLabel;
        private System.Windows.Forms.Button ThemesChange;
        private System.Windows.Forms.Button PublishersEdit;
        private System.Windows.Forms.Label PublishersLabel;
        private System.Windows.Forms.CheckedListBox PublishersFiltr;
        private System.Windows.Forms.NumericUpDown PlaceNum;
        private System.Windows.Forms.Label PlaceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateP;
    }
}