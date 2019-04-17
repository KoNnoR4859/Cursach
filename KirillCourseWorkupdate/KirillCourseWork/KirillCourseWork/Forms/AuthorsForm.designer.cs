namespace KirillCourseWork
{
    partial class AuthorsForm
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
            this.Employeers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.Sort_label = new System.Windows.Forms.Label();
            this.Filtrs_Label = new System.Windows.Forms.Label();
            this.Job_Filtr = new System.Windows.Forms.CheckedListBox();
            this.JobFiltr_Label = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.YearTo = new System.Windows.Forms.NumericUpDown();
            this.YearFrom = new System.Windows.Forms.NumericUpDown();
            this.YearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Employeers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // Employeers
            // 
            this.Employeers.AllowUserToAddRows = false;
            this.Employeers.AllowUserToDeleteRows = false;
            this.Employeers.AllowUserToResizeColumns = false;
            this.Employeers.AllowUserToResizeRows = false;
            this.Employeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employeers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FLName,
            this.Adres,
            this.Born});
            this.Employeers.Location = new System.Drawing.Point(14, 97);
            this.Employeers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employeers.MultiSelect = false;
            this.Employeers.Name = "Employeers";
            this.Employeers.ReadOnly = true;
            this.Employeers.RowHeadersVisible = false;
            this.Employeers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Employeers.Size = new System.Drawing.Size(664, 411);
            this.Employeers.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 100;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FLName
            // 
            this.FLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FLName.HeaderText = "Имя";
            this.FLName.Name = "FLName";
            this.FLName.ReadOnly = true;
            this.FLName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FLName.Width = 39;
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adres.HeaderText = "Страна";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            this.Adres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Adres.Width = 54;
            // 
            // Born
            // 
            this.Born.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Born.HeaderText = "Год рождения";
            this.Born.Name = "Born";
            this.Born.ReadOnly = true;
            this.Born.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Born.Width = 98;
            // 
            // SortPanel
            // 
            this.SortPanel.DisplayMember = "0";
            this.SortPanel.FormattingEnabled = true;
            this.SortPanel.Items.AddRange(new object[] {
            "год от большего",
            "год от меньшего",
            "имени от большего",
            "имени от меньшего"});
            this.SortPanel.Location = new System.Drawing.Point(145, 64);
            this.SortPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(221, 24);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 1;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(36, 68);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(99, 16);
            this.Sort_label.TabIndex = 2;
            this.Sort_label.Text = "Сортировать по";
            // 
            // Filtrs_Label
            // 
            this.Filtrs_Label.AutoSize = true;
            this.Filtrs_Label.Location = new System.Drawing.Point(685, 97);
            this.Filtrs_Label.Name = "Filtrs_Label";
            this.Filtrs_Label.Size = new System.Drawing.Size(83, 16);
            this.Filtrs_Label.TabIndex = 3;
            this.Filtrs_Label.Text = "Фильтрация:";
            // 
            // Job_Filtr
            // 
            this.Job_Filtr.FormattingEnabled = true;
            this.Job_Filtr.Location = new System.Drawing.Point(688, 149);
            this.Job_Filtr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Job_Filtr.Name = "Job_Filtr";
            this.Job_Filtr.ScrollAlwaysVisible = true;
            this.Job_Filtr.Size = new System.Drawing.Size(139, 84);
            this.Job_Filtr.TabIndex = 4;
            // 
            // JobFiltr_Label
            // 
            this.JobFiltr_Label.AutoSize = true;
            this.JobFiltr_Label.Location = new System.Drawing.Point(685, 129);
            this.JobFiltr_Label.Name = "JobFiltr_Label";
            this.JobFiltr_Label.Size = new System.Drawing.Size(48, 16);
            this.JobFiltr_Label.TabIndex = 5;
            this.JobFiltr_Label.Text = "Страна";
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(789, 468);
            this.Apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(101, 41);
            this.Apply.TabIndex = 13;
            this.Apply.Text = "Применить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(694, 480);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 28);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(14, 516);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 28);
            this.Back.TabIndex = 15;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(803, 41);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(117, 28);
            this.Add.TabIndex = 16;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Update.Location = new System.Drawing.Point(681, 41);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(114, 28);
            this.Update.TabIndex = 19;
            this.Update.Text = "Изменить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Delete.Location = new System.Drawing.Point(555, 41);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(122, 28);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // YearTo
            // 
            this.YearTo.Location = new System.Drawing.Point(697, 361);
            this.YearTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearTo.Name = "YearTo";
            this.YearTo.Size = new System.Drawing.Size(71, 21);
            this.YearTo.TabIndex = 24;
            this.YearTo.ValueChanged += new System.EventHandler(this.YearTo_ValueChanged);
            // 
            // YearFrom
            // 
            this.YearFrom.Location = new System.Drawing.Point(697, 329);
            this.YearFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearFrom.Name = "YearFrom";
            this.YearFrom.Size = new System.Drawing.Size(71, 21);
            this.YearFrom.TabIndex = 23;
            this.YearFrom.ValueChanged += new System.EventHandler(this.YearTo_ValueChanged);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(694, 309);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(70, 16);
            this.YearLabel.TabIndex = 22;
            this.YearLabel.Text = "Стоимость";
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.YearTo);
            this.Controls.Add(this.YearFrom);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.JobFiltr_Label);
            this.Controls.Add(this.Job_Filtr);
            this.Controls.Add(this.Filtrs_Label);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.Employeers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorsForm";
            this.Text = "Авторы";
            ((System.ComponentModel.ISupportInitialize)(this.Employeers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Employeers;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.Label Filtrs_Label;
        private System.Windows.Forms.CheckedListBox Job_Filtr;
        private System.Windows.Forms.Label JobFiltr_Label;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Born;
        private System.Windows.Forms.NumericUpDown YearTo;
        private System.Windows.Forms.NumericUpDown YearFrom;
        private System.Windows.Forms.Label YearLabel;
    }
}