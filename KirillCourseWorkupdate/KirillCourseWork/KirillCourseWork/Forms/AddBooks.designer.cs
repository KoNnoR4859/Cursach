namespace KirillCourseWork
{
    partial class AddBooks
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
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCount = new System.Windows.Forms.Label();
            this.LabelPlace = new System.Windows.Forms.Label();
            this.LabelPublisher = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PublisherText = new System.Windows.Forms.ComboBox();
            this.CountText = new System.Windows.Forms.NumericUpDown();
            this.PlaceText = new System.Windows.Forms.NumericUpDown();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Categoryes = new System.Windows.Forms.Button();
            this.ThemesChange = new System.Windows.Forms.Button();
            this.ThemesLabel = new System.Windows.Forms.Label();
            this.JenreEdit = new System.Windows.Forms.Button();
            this.AuthorsEdit = new System.Windows.Forms.Button();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.AuthorsFiltr = new System.Windows.Forms.CheckedListBox();
            this.ThemesFiltr = new System.Windows.Forms.CheckedListBox();
            this.JenreLabel = new System.Windows.Forms.Label();
            this.JenreFiltr = new System.Windows.Forms.CheckedListBox();
            this.DateText = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceText)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(27, 38);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(63, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Название: ";
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Location = new System.Drawing.Point(18, 70);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(66, 13);
            this.LabelCount.TabIndex = 3;
            this.LabelCount.Text = "Количество";
            // 
            // LabelPlace
            // 
            this.LabelPlace.AutoSize = true;
            this.LabelPlace.Location = new System.Drawing.Point(27, 112);
            this.LabelPlace.Name = "LabelPlace";
            this.LabelPlace.Size = new System.Drawing.Size(39, 13);
            this.LabelPlace.TabIndex = 4;
            this.LabelPlace.Text = "Полка";
            // 
            // LabelPublisher
            // 
            this.LabelPublisher.AutoSize = true;
            this.LabelPublisher.Location = new System.Drawing.Point(13, 150);
            this.LabelPublisher.Name = "LabelPublisher";
            this.LabelPublisher.Size = new System.Drawing.Size(82, 13);
            this.LabelPublisher.TabIndex = 5;
            this.LabelPublisher.Text = " Издательство";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(96, 35);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 7;
            // 
            // PublisherText
            // 
            this.PublisherText.FormattingEnabled = true;
            this.PublisherText.Location = new System.Drawing.Point(96, 150);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(121, 21);
            this.PublisherText.TabIndex = 10;
            // 
            // CountText
            // 
            this.CountText.Location = new System.Drawing.Point(96, 68);
            this.CountText.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.CountText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(78, 20);
            this.CountText.TabIndex = 12;
            this.CountText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PlaceText
            // 
            this.PlaceText.Location = new System.Drawing.Point(90, 105);
            this.PlaceText.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PlaceText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlaceText.Name = "PlaceText";
            this.PlaceText.Size = new System.Drawing.Size(120, 20);
            this.PlaceText.TabIndex = 13;
            this.PlaceText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(553, 375);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 33);
            this.Add.TabIndex = 14;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(420, 385);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Categoryes
            // 
            this.Categoryes.Location = new System.Drawing.Point(225, 150);
            this.Categoryes.Name = "Categoryes";
            this.Categoryes.Size = new System.Drawing.Size(102, 23);
            this.Categoryes.TabIndex = 16;
            this.Categoryes.Text = "Издательства";
            this.Categoryes.UseVisualStyleBackColor = true;
            this.Categoryes.Click += new System.EventHandler(this.Categoryes_Click);
            // 
            // ThemesChange
            // 
            this.ThemesChange.Location = new System.Drawing.Point(474, 229);
            this.ThemesChange.Name = "ThemesChange";
            this.ThemesChange.Size = new System.Drawing.Size(108, 23);
            this.ThemesChange.TabIndex = 48;
            this.ThemesChange.Text = "Изменить";
            this.ThemesChange.UseVisualStyleBackColor = true;
            this.ThemesChange.Click += new System.EventHandler(this.ThemesChange_Click);
            // 
            // ThemesLabel
            // 
            this.ThemesLabel.AutoSize = true;
            this.ThemesLabel.Location = new System.Drawing.Point(388, 234);
            this.ThemesLabel.Name = "ThemesLabel";
            this.ThemesLabel.Size = new System.Drawing.Size(57, 13);
            this.ThemesLabel.TabIndex = 47;
            this.ThemesLabel.Text = "Тематика";
            // 
            // JenreEdit
            // 
            this.JenreEdit.Location = new System.Drawing.Point(109, 229);
            this.JenreEdit.Name = "JenreEdit";
            this.JenreEdit.Size = new System.Drawing.Size(108, 23);
            this.JenreEdit.TabIndex = 46;
            this.JenreEdit.Text = "Изменить";
            this.JenreEdit.UseVisualStyleBackColor = true;
            this.JenreEdit.Click += new System.EventHandler(this.JenreEdit_Click);
            // 
            // AuthorsEdit
            // 
            this.AuthorsEdit.Location = new System.Drawing.Point(474, 7);
            this.AuthorsEdit.Name = "AuthorsEdit";
            this.AuthorsEdit.Size = new System.Drawing.Size(108, 23);
            this.AuthorsEdit.TabIndex = 45;
            this.AuthorsEdit.Text = "Изменить";
            this.AuthorsEdit.UseVisualStyleBackColor = true;
            this.AuthorsEdit.Click += new System.EventHandler(this.AuthorsEdit_Click);
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Location = new System.Drawing.Point(388, 12);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(45, 13);
            this.AuthorsLabel.TabIndex = 44;
            this.AuthorsLabel.Text = "Авторы";
            // 
            // AuthorsFiltr
            // 
            this.AuthorsFiltr.FormattingEnabled = true;
            this.AuthorsFiltr.Location = new System.Drawing.Point(391, 35);
            this.AuthorsFiltr.Name = "AuthorsFiltr";
            this.AuthorsFiltr.Size = new System.Drawing.Size(243, 79);
            this.AuthorsFiltr.TabIndex = 43;
            // 
            // ThemesFiltr
            // 
            this.ThemesFiltr.FormattingEnabled = true;
            this.ThemesFiltr.Location = new System.Drawing.Point(391, 257);
            this.ThemesFiltr.Name = "ThemesFiltr";
            this.ThemesFiltr.Size = new System.Drawing.Size(245, 79);
            this.ThemesFiltr.TabIndex = 42;
            // 
            // JenreLabel
            // 
            this.JenreLabel.AutoSize = true;
            this.JenreLabel.Location = new System.Drawing.Point(27, 237);
            this.JenreLabel.Name = "JenreLabel";
            this.JenreLabel.Size = new System.Drawing.Size(44, 13);
            this.JenreLabel.TabIndex = 41;
            this.JenreLabel.Text = "Жанры";
            // 
            // JenreFiltr
            // 
            this.JenreFiltr.FormattingEnabled = true;
            this.JenreFiltr.Location = new System.Drawing.Point(30, 257);
            this.JenreFiltr.Name = "JenreFiltr";
            this.JenreFiltr.Size = new System.Drawing.Size(235, 79);
            this.JenreFiltr.TabIndex = 40;
            // 
            // DateText
            // 
            this.DateText.CustomFormat = "yyyy-MM-dd";
            this.DateText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateText.Location = new System.Drawing.Point(96, 193);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(200, 20);
            this.DateText.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = " Дата печати";
            // 
            // AddBooks
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(664, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.ThemesChange);
            this.Controls.Add(this.ThemesLabel);
            this.Controls.Add(this.JenreEdit);
            this.Controls.Add(this.AuthorsEdit);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.AuthorsFiltr);
            this.Controls.Add(this.ThemesFiltr);
            this.Controls.Add(this.JenreLabel);
            this.Controls.Add(this.JenreFiltr);
            this.Controls.Add(this.Categoryes);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PlaceText);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.PublisherText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.LabelPublisher);
            this.Controls.Add(this.LabelPlace);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.LabelName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBooks";
            this.Text = "Добавить книгу";
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Label LabelPlace;
        private System.Windows.Forms.Label LabelPublisher;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.ComboBox PublisherText;
        private System.Windows.Forms.NumericUpDown CountText;
        private System.Windows.Forms.NumericUpDown PlaceText;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Categoryes;
        private System.Windows.Forms.Button ThemesChange;
        private System.Windows.Forms.Label ThemesLabel;
        private System.Windows.Forms.Button JenreEdit;
        private System.Windows.Forms.Button AuthorsEdit;
        private System.Windows.Forms.Label AuthorsLabel;
        private System.Windows.Forms.CheckedListBox AuthorsFiltr;
        private System.Windows.Forms.CheckedListBox ThemesFiltr;
        private System.Windows.Forms.Label JenreLabel;
        private System.Windows.Forms.CheckedListBox JenreFiltr;
        private System.Windows.Forms.DateTimePicker DateText;
        private System.Windows.Forms.Label label1;
    }
}