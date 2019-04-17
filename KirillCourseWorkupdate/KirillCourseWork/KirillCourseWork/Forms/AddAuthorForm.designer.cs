namespace KirillCourseWork
{
    partial class AddAuthorForm
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
            this.Back = new System.Windows.Forms.Button();
            this.Born = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.LnameText = new System.Windows.Forms.TextBox();
            this.AdresText = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.BornText = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BornText)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 219);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 27);
            this.Back.TabIndex = 21;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Born
            // 
            this.Born.AutoSize = true;
            this.Born.Location = new System.Drawing.Point(31, 150);
            this.Born.Name = "Born";
            this.Born.Size = new System.Drawing.Size(28, 13);
            this.Born.TabIndex = 14;
            this.Born.Text = "Год:";
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(14, 93);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(79, 13);
            this.Adres.TabIndex = 13;
            this.Adres.Text = "Страна(Город)";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(31, 58);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(62, 13);
            this.Lname.TabIndex = 12;
            this.Lname.Text = "Фамилия: ";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(33, 25);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(35, 13);
            this.Fname.TabIndex = 11;
            this.Fname.Text = "Имя: ";
            // 
            // FnameText
            // 
            this.FnameText.Location = new System.Drawing.Point(83, 22);
            this.FnameText.MaxLength = 20;
            this.FnameText.Name = "FnameText";
            this.FnameText.Size = new System.Drawing.Size(100, 20);
            this.FnameText.TabIndex = 22;
            // 
            // LnameText
            // 
            this.LnameText.Location = new System.Drawing.Point(99, 55);
            this.LnameText.MaxLength = 20;
            this.LnameText.Name = "LnameText";
            this.LnameText.Size = new System.Drawing.Size(100, 20);
            this.LnameText.TabIndex = 23;
            // 
            // AdresText
            // 
            this.AdresText.Location = new System.Drawing.Point(99, 93);
            this.AdresText.MaxLength = 20;
            this.AdresText.Name = "AdresText";
            this.AdresText.Size = new System.Drawing.Size(237, 20);
            this.AdresText.TabIndex = 24;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(215, 219);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(121, 27);
            this.Add.TabIndex = 34;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Done_Click);
            // 
            // BornText
            // 
            this.BornText.Location = new System.Drawing.Point(65, 150);
            this.BornText.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.BornText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BornText.Name = "BornText";
            this.BornText.Size = new System.Drawing.Size(71, 20);
            this.BornText.TabIndex = 35;
            this.BornText.Value = new decimal(new int[] {
            2001,
            0,
            0,
            0});
            // 
            // AddAuthorForm
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(369, 275);
            this.Controls.Add(this.BornText);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AdresText);
            this.Controls.Add(this.LnameText);
            this.Controls.Add(this.FnameText);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Born);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить автора";
            ((System.ComponentModel.ISupportInitialize)(this.BornText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Born;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.TextBox LnameText;
        private System.Windows.Forms.TextBox AdresText;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.NumericUpDown BornText;
    }
}