namespace Lab_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Book_Format = new System.Windows.Forms.ComboBox();
            this.myButton1 = new MyBut.MyButton();
            this.myButton2 = new MyBut.MyButton();
            this.Book_Title = new System.Windows.Forms.TextBox();
            this.Book_FileSize = new System.Windows.Forms.TextBox();
            this.myButton3 = new MyBut.MyButton();
            this.myButton4 = new MyBut.MyButton();
            this.Book_UploadDate = new System.Windows.Forms.DateTimePicker();
            this.Book_PageNumbs = new System.Windows.Forms.TextBox();
            this.myButton5 = new MyBut.MyButton();
            this.myButton6 = new MyBut.MyButton();
            this.myButton7 = new MyBut.MyButton();
            this.myButton8 = new MyBut.MyButton();
            this.myButton9 = new MyBut.MyButton();
            this.myButton10 = new MyBut.MyButton();
            this.Publisher_Name = new System.Windows.Forms.TextBox();
            this.Publisher_Country = new System.Windows.Forms.TextBox();
            this.Publisher_City = new System.Windows.Forms.TextBox();
            this.Publisher_FoundationYear = new System.Windows.Forms.TextBox();
            this.Publisher_StateRadio = new System.Windows.Forms.RadioButton();
            this.Publisher_PrivateRadio = new System.Windows.Forms.RadioButton();
            this.myButton11 = new MyBut.MyButton();
            this.myButton12 = new MyBut.MyButton();
            this.Author_Id = new System.Windows.Forms.TextBox();
            this.Author_Country = new System.Windows.Forms.TextBox();
            this.Author_Name = new System.Windows.Forms.TextBox();
            this.myButton13 = new MyBut.MyButton();
            this.myButton14 = new MyBut.MyButton();
            this.myButton15 = new MyBut.MyButton();
            this.myButton16 = new MyBut.MyButton();
            this.FinalBookFile = new System.Windows.Forms.RichTextBox();
            this.myButton17 = new MyBut.MyButton();
            this.myButton18 = new MyBut.MyButton();
            this.Book_FileSize_Type = new System.Windows.Forms.ComboBox();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.myButton19 = new MyBut.MyButton();
            this.myButton20 = new MyBut.MyButton();
            this.SuspendLayout();
            // 
            // Book_Format
            // 
            this.Book_Format.FormattingEnabled = true;
            this.Book_Format.Items.AddRange(new object[] {
            "60х90 1/8",
            "84х108 1/16",
            "70х100 1/16",
            "70х90 1/16",
            "60х90 1/16",
            "60х84 1/16",
            "84х108 1/32",
            "70х100 1/32",
            "75х90 1/32",
            "70х90 1/32",
            "60х90 1/32",
            "60х84 1/32"});
            this.Book_Format.Location = new System.Drawing.Point(87, 40);
            this.Book_Format.Name = "Book_Format";
            this.Book_Format.Size = new System.Drawing.Size(202, 20);
            this.Book_Format.TabIndex = 0;
            this.Book_Format.Enter += new System.EventHandler(this.EnterObject);
            this.Book_Format.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nothing);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.Transparent;
            this.myButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton1.ForeColor = System.Drawing.Color.Black;
            this.myButton1.Location = new System.Drawing.Point(12, 40);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(78, 20);
            this.myButton1.TabIndex = 1;
            this.myButton1.Text = "Format";
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.Transparent;
            this.myButton2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton2.ForeColor = System.Drawing.Color.Black;
            this.myButton2.Location = new System.Drawing.Point(20, 66);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(70, 23);
            this.myButton2.TabIndex = 2;
            this.myButton2.Text = "Title";
            // 
            // Book_Title
            // 
            this.Book_Title.AcceptsTab = true;
            this.Book_Title.Location = new System.Drawing.Point(87, 66);
            this.Book_Title.Name = "Book_Title";
            this.Book_Title.Size = new System.Drawing.Size(202, 23);
            this.Book_Title.TabIndex = 3;
            this.Book_Title.Enter += new System.EventHandler(this.EnterObject);
            // 
            // Book_FileSize
            // 
            this.Book_FileSize.AcceptsTab = true;
            this.Book_FileSize.Location = new System.Drawing.Point(87, 95);
            this.Book_FileSize.Name = "Book_FileSize";
            this.Book_FileSize.Size = new System.Drawing.Size(121, 23);
            this.Book_FileSize.TabIndex = 5;
            this.Book_FileSize.Enter += new System.EventHandler(this.EnterObject);
            this.Book_FileSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.Transparent;
            this.myButton3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton3.ForeColor = System.Drawing.Color.Black;
            this.myButton3.Location = new System.Drawing.Point(23, 95);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(58, 23);
            this.myButton3.TabIndex = 4;
            this.myButton3.Text = "File Size";
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.Color.Transparent;
            this.myButton4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton4.ForeColor = System.Drawing.Color.Black;
            this.myButton4.Location = new System.Drawing.Point(56, 153);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(186, 23);
            this.myButton4.TabIndex = 7;
            this.myButton4.Text = "Upload Date";
            // 
            // Book_UploadDate
            // 
            this.Book_UploadDate.Location = new System.Drawing.Point(34, 182);
            this.Book_UploadDate.Name = "Book_UploadDate";
            this.Book_UploadDate.Size = new System.Drawing.Size(240, 23);
            this.Book_UploadDate.TabIndex = 8;
            this.Book_UploadDate.Enter += new System.EventHandler(this.EnterObject);
            // 
            // Book_PageNumbs
            // 
            this.Book_PageNumbs.AcceptsTab = true;
            this.Book_PageNumbs.Location = new System.Drawing.Point(87, 124);
            this.Book_PageNumbs.Name = "Book_PageNumbs";
            this.Book_PageNumbs.Size = new System.Drawing.Size(202, 23);
            this.Book_PageNumbs.TabIndex = 10;
            this.Book_PageNumbs.Enter += new System.EventHandler(this.EnterObject);
            this.Book_PageNumbs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.Color.Transparent;
            this.myButton5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton5.ForeColor = System.Drawing.Color.Black;
            this.myButton5.Location = new System.Drawing.Point(23, 124);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(58, 23);
            this.myButton5.TabIndex = 9;
            this.myButton5.Text = "Page numbs";
            // 
            // myButton6
            // 
            this.myButton6.BackColor = System.Drawing.Color.Transparent;
            this.myButton6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton6.ForeColor = System.Drawing.Color.Black;
            this.myButton6.Location = new System.Drawing.Point(34, 222);
            this.myButton6.Name = "myButton6";
            this.myButton6.Size = new System.Drawing.Size(128, 23);
            this.myButton6.TabIndex = 11;
            this.myButton6.Text = "Publisher";
            // 
            // myButton7
            // 
            this.myButton7.BackColor = System.Drawing.Color.Transparent;
            this.myButton7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton7.ForeColor = System.Drawing.Color.Black;
            this.myButton7.Location = new System.Drawing.Point(23, 251);
            this.myButton7.Name = "myButton7";
            this.myButton7.Size = new System.Drawing.Size(58, 23);
            this.myButton7.TabIndex = 12;
            this.myButton7.Text = "Name";
            // 
            // myButton8
            // 
            this.myButton8.BackColor = System.Drawing.Color.Transparent;
            this.myButton8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton8.ForeColor = System.Drawing.Color.Black;
            this.myButton8.Location = new System.Drawing.Point(23, 280);
            this.myButton8.Name = "myButton8";
            this.myButton8.Size = new System.Drawing.Size(58, 23);
            this.myButton8.TabIndex = 13;
            this.myButton8.Text = "Country";
            // 
            // myButton9
            // 
            this.myButton9.BackColor = System.Drawing.Color.Transparent;
            this.myButton9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton9.ForeColor = System.Drawing.Color.Black;
            this.myButton9.Location = new System.Drawing.Point(23, 309);
            this.myButton9.Name = "myButton9";
            this.myButton9.Size = new System.Drawing.Size(58, 23);
            this.myButton9.TabIndex = 14;
            this.myButton9.Text = "City";
            // 
            // myButton10
            // 
            this.myButton10.BackColor = System.Drawing.Color.Transparent;
            this.myButton10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton10.ForeColor = System.Drawing.Color.Black;
            this.myButton10.Location = new System.Drawing.Point(12, 338);
            this.myButton10.Name = "myButton10";
            this.myButton10.Size = new System.Drawing.Size(70, 23);
            this.myButton10.TabIndex = 15;
            this.myButton10.Text = "Foundation Year";
            // 
            // Publisher_Name
            // 
            this.Publisher_Name.AcceptsTab = true;
            this.Publisher_Name.Location = new System.Drawing.Point(87, 251);
            this.Publisher_Name.Name = "Publisher_Name";
            this.Publisher_Name.Size = new System.Drawing.Size(91, 23);
            this.Publisher_Name.TabIndex = 16;
            this.Publisher_Name.Enter += new System.EventHandler(this.EnterObject);
            this.Publisher_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolsOrSpace);
            // 
            // Publisher_Country
            // 
            this.Publisher_Country.AcceptsTab = true;
            this.Publisher_Country.Location = new System.Drawing.Point(87, 280);
            this.Publisher_Country.Name = "Publisher_Country";
            this.Publisher_Country.Size = new System.Drawing.Size(91, 23);
            this.Publisher_Country.TabIndex = 17;
            this.Publisher_Country.Enter += new System.EventHandler(this.EnterObject);
            this.Publisher_Country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolOrDashOrSpace);
            // 
            // Publisher_City
            // 
            this.Publisher_City.AcceptsTab = true;
            this.Publisher_City.Location = new System.Drawing.Point(87, 309);
            this.Publisher_City.Name = "Publisher_City";
            this.Publisher_City.Size = new System.Drawing.Size(91, 23);
            this.Publisher_City.TabIndex = 18;
            this.Publisher_City.Enter += new System.EventHandler(this.EnterObject);
            this.Publisher_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolOrDashOrSpace);
            // 
            // Publisher_FoundationYear
            // 
            this.Publisher_FoundationYear.AcceptsTab = true;
            this.Publisher_FoundationYear.Location = new System.Drawing.Point(87, 338);
            this.Publisher_FoundationYear.Name = "Publisher_FoundationYear";
            this.Publisher_FoundationYear.Size = new System.Drawing.Size(91, 23);
            this.Publisher_FoundationYear.TabIndex = 19;
            this.Publisher_FoundationYear.Enter += new System.EventHandler(this.EnterObject);
            this.Publisher_FoundationYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // Publisher_StateRadio
            // 
            this.Publisher_StateRadio.AutoSize = true;
            this.Publisher_StateRadio.Location = new System.Drawing.Point(34, 367);
            this.Publisher_StateRadio.Name = "Publisher_StateRadio";
            this.Publisher_StateRadio.Size = new System.Drawing.Size(56, 16);
            this.Publisher_StateRadio.TabIndex = 20;
            this.Publisher_StateRadio.TabStop = true;
            this.Publisher_StateRadio.Text = "State";
            this.Publisher_StateRadio.UseVisualStyleBackColor = true;
            this.Publisher_StateRadio.Enter += new System.EventHandler(this.EnterObject);
            // 
            // Publisher_PrivateRadio
            // 
            this.Publisher_PrivateRadio.AutoSize = true;
            this.Publisher_PrivateRadio.Location = new System.Drawing.Point(100, 367);
            this.Publisher_PrivateRadio.Name = "Publisher_PrivateRadio";
            this.Publisher_PrivateRadio.Size = new System.Drawing.Size(65, 16);
            this.Publisher_PrivateRadio.TabIndex = 21;
            this.Publisher_PrivateRadio.TabStop = true;
            this.Publisher_PrivateRadio.Text = "Private";
            this.Publisher_PrivateRadio.UseVisualStyleBackColor = true;
            this.Publisher_PrivateRadio.Enter += new System.EventHandler(this.EnterObject);
            // 
            // myButton11
            // 
            this.myButton11.BackColor = System.Drawing.Color.Transparent;
            this.myButton11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton11.ForeColor = System.Drawing.Color.Black;
            this.myButton11.Location = new System.Drawing.Point(219, 222);
            this.myButton11.Name = "myButton11";
            this.myButton11.Size = new System.Drawing.Size(128, 23);
            this.myButton11.TabIndex = 22;
            this.myButton11.Text = "Author";
            // 
            // myButton12
            // 
            this.myButton12.BackColor = System.Drawing.Color.Transparent;
            this.myButton12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton12.ForeColor = System.Drawing.Color.Black;
            this.myButton12.Location = new System.Drawing.Point(64, 12);
            this.myButton12.Name = "myButton12";
            this.myButton12.Size = new System.Drawing.Size(144, 23);
            this.myButton12.TabIndex = 23;
            this.myButton12.Text = "Book file info";
            // 
            // Author_Id
            // 
            this.Author_Id.AcceptsTab = true;
            this.Author_Id.BackColor = System.Drawing.SystemColors.Window;
            this.Author_Id.Location = new System.Drawing.Point(270, 309);
            this.Author_Id.Name = "Author_Id";
            this.Author_Id.Size = new System.Drawing.Size(91, 23);
            this.Author_Id.TabIndex = 29;
            this.Author_Id.Enter += new System.EventHandler(this.EnterObject);
            this.Author_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // Author_Country
            // 
            this.Author_Country.AcceptsTab = true;
            this.Author_Country.Location = new System.Drawing.Point(270, 280);
            this.Author_Country.Name = "Author_Country";
            this.Author_Country.Size = new System.Drawing.Size(91, 23);
            this.Author_Country.TabIndex = 28;
            this.Author_Country.Enter += new System.EventHandler(this.EnterObject);
            this.Author_Country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolOrDashOrSpace);
            // 
            // Author_Name
            // 
            this.Author_Name.AcceptsTab = true;
            this.Author_Name.Location = new System.Drawing.Point(270, 251);
            this.Author_Name.Name = "Author_Name";
            this.Author_Name.Size = new System.Drawing.Size(91, 23);
            this.Author_Name.TabIndex = 27;
            this.Author_Name.Enter += new System.EventHandler(this.EnterObject);
            this.Author_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolsOrSpace);
            // 
            // myButton13
            // 
            this.myButton13.BackColor = System.Drawing.Color.Transparent;
            this.myButton13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton13.ForeColor = System.Drawing.Color.Black;
            this.myButton13.Location = new System.Drawing.Point(206, 309);
            this.myButton13.Name = "myButton13";
            this.myButton13.Size = new System.Drawing.Size(58, 23);
            this.myButton13.TabIndex = 26;
            this.myButton13.Text = "Id";
            // 
            // myButton14
            // 
            this.myButton14.BackColor = System.Drawing.Color.Transparent;
            this.myButton14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton14.ForeColor = System.Drawing.Color.Black;
            this.myButton14.Location = new System.Drawing.Point(206, 280);
            this.myButton14.Name = "myButton14";
            this.myButton14.Size = new System.Drawing.Size(58, 23);
            this.myButton14.TabIndex = 25;
            this.myButton14.Text = "Country";
            // 
            // myButton15
            // 
            this.myButton15.BackColor = System.Drawing.Color.Transparent;
            this.myButton15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton15.ForeColor = System.Drawing.Color.Black;
            this.myButton15.Location = new System.Drawing.Point(206, 251);
            this.myButton15.Name = "myButton15";
            this.myButton15.Size = new System.Drawing.Size(58, 23);
            this.myButton15.TabIndex = 24;
            this.myButton15.Text = "Name";
            // 
            // myButton16
            // 
            this.myButton16.BackColor = System.Drawing.Color.Tomato;
            this.myButton16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton16.ForeColor = System.Drawing.Color.White;
            this.myButton16.Location = new System.Drawing.Point(270, 338);
            this.myButton16.Name = "myButton16";
            this.myButton16.Size = new System.Drawing.Size(91, 23);
            this.myButton16.TabIndex = 30;
            this.myButton16.Text = "Add";
            this.myButton16.Click += new System.EventHandler(this.myButton16_Click);
            // 
            // FinalBookFile
            // 
            this.FinalBookFile.Location = new System.Drawing.Point(413, 85);
            this.FinalBookFile.Name = "FinalBookFile";
            this.FinalBookFile.Size = new System.Drawing.Size(375, 353);
            this.FinalBookFile.TabIndex = 31;
            this.FinalBookFile.Text = "";
            this.FinalBookFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FinalBookFile_KeyPress);
            // 
            // myButton17
            // 
            this.myButton17.BackColor = System.Drawing.Color.Tomato;
            this.myButton17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton17.ForeColor = System.Drawing.Color.White;
            this.myButton17.Location = new System.Drawing.Point(684, 10);
            this.myButton17.Name = "myButton17";
            this.myButton17.Size = new System.Drawing.Size(100, 30);
            this.myButton17.TabIndex = 32;
            this.myButton17.Text = "SAVE";
            this.myButton17.Click += new System.EventHandler(this.myButton17_Click);
            // 
            // myButton18
            // 
            this.myButton18.BackColor = System.Drawing.Color.Tomato;
            this.myButton18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton18.ForeColor = System.Drawing.Color.White;
            this.myButton18.Location = new System.Drawing.Point(684, 49);
            this.myButton18.Name = "myButton18";
            this.myButton18.Size = new System.Drawing.Size(100, 30);
            this.myButton18.TabIndex = 33;
            this.myButton18.Text = "LOAD";
            this.myButton18.Click += new System.EventHandler(this.myButton18_Click);
            // 
            // Book_FileSize_Type
            // 
            this.Book_FileSize_Type.FormattingEnabled = true;
            this.Book_FileSize_Type.Items.AddRange(new object[] {
            "Gb",
            "Mb"});
            this.Book_FileSize_Type.Location = new System.Drawing.Point(219, 95);
            this.Book_FileSize_Type.Name = "Book_FileSize_Type";
            this.Book_FileSize_Type.Size = new System.Drawing.Size(70, 20);
            this.Book_FileSize_Type.TabIndex = 34;
            this.Book_FileSize_Type.Enter += new System.EventHandler(this.EnterObject);
            this.Book_FileSize_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nothing);
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.Color.DimGray;
            this.ErrorBox.Location = new System.Drawing.Point(0, 415);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.Size = new System.Drawing.Size(416, 23);
            this.ErrorBox.TabIndex = 35;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // myButton19
            // 
            this.myButton19.BackColor = System.Drawing.Color.Tomato;
            this.myButton19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton19.ForeColor = System.Drawing.Color.White;
            this.myButton19.Location = new System.Drawing.Point(270, 367);
            this.myButton19.Name = "myButton19";
            this.myButton19.Size = new System.Drawing.Size(91, 16);
            this.myButton19.TabIndex = 36;
            this.myButton19.Text = "delete last";
            this.myButton19.Click += new System.EventHandler(this.myButton19_Click);
            // 
            // myButton20
            // 
            this.myButton20.BackColor = System.Drawing.Color.Tomato;
            this.myButton20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton20.ForeColor = System.Drawing.Color.White;
            this.myButton20.Location = new System.Drawing.Point(270, 389);
            this.myButton20.Name = "myButton20";
            this.myButton20.Size = new System.Drawing.Size(91, 16);
            this.myButton20.TabIndex = 37;
            this.myButton20.Text = "clear all";
            this.myButton20.Click += new System.EventHandler(this.myButton20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myButton20);
            this.Controls.Add(this.myButton19);
            this.Controls.Add(this.Book_FileSize_Type);
            this.Controls.Add(this.myButton18);
            this.Controls.Add(this.myButton17);
            this.Controls.Add(this.FinalBookFile);
            this.Controls.Add(this.myButton16);
            this.Controls.Add(this.Author_Id);
            this.Controls.Add(this.Author_Country);
            this.Controls.Add(this.Author_Name);
            this.Controls.Add(this.myButton13);
            this.Controls.Add(this.myButton14);
            this.Controls.Add(this.myButton15);
            this.Controls.Add(this.myButton12);
            this.Controls.Add(this.myButton11);
            this.Controls.Add(this.Publisher_PrivateRadio);
            this.Controls.Add(this.Publisher_StateRadio);
            this.Controls.Add(this.Publisher_FoundationYear);
            this.Controls.Add(this.Publisher_City);
            this.Controls.Add(this.Publisher_Country);
            this.Controls.Add(this.Publisher_Name);
            this.Controls.Add(this.myButton9);
            this.Controls.Add(this.myButton8);
            this.Controls.Add(this.myButton7);
            this.Controls.Add(this.myButton6);
            this.Controls.Add(this.Book_PageNumbs);
            this.Controls.Add(this.myButton5);
            this.Controls.Add(this.Book_UploadDate);
            this.Controls.Add(this.Book_FileSize);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.Book_Title);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.Book_Format);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.myButton10);
            this.Controls.Add(this.ErrorBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Book_Format;
        private MyBut.MyButton myButton1;
        private MyBut.MyButton myButton2;
        private TextBox Book_Title;
        private TextBox Book_FileSize;
        private MyBut.MyButton myButton3;
        private MyBut.MyButton myButton4;
        private DateTimePicker Book_UploadDate;
        private TextBox Book_PageNumbs;
        private MyBut.MyButton myButton5;
        private MyBut.MyButton myButton6;
        private MyBut.MyButton myButton7;
        private MyBut.MyButton myButton8;
        private MyBut.MyButton myButton9;
        private MyBut.MyButton myButton10;
        private TextBox Publisher_Name;
        private TextBox Publisher_Country;
        private TextBox Publisher_City;
        private TextBox Publisher_FoundationYear;
        private RadioButton Publisher_StateRadio;
        private RadioButton Publisher_PrivateRadio;
        private MyBut.MyButton myButton11;
        private MyBut.MyButton myButton12;
        private TextBox Author_Id;
        private TextBox Author_Country;
        private TextBox Author_Name;
        private MyBut.MyButton myButton13;
        private MyBut.MyButton myButton14;
        private MyBut.MyButton myButton15;
        private MyBut.MyButton myButton16;
        private RichTextBox FinalBookFile;
        private MyBut.MyButton myButton17;
        private MyBut.MyButton myButton18;
        private ComboBox Book_FileSize_Type;
        private TextBox ErrorBox;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private MyBut.MyButton myButton19;
        private MyBut.MyButton myButton20;
    }
}