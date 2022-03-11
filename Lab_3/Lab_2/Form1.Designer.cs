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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.myButton21 = new MyBut.MyButton();
            this.Book_UDK = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tool_menu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.nameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.StateLine = new System.Windows.Forms.RichTextBox();
            this.but_open_menu = new MyBut.MyButton();
            this.panel2.SuspendLayout();
            this.tool_menu.SuspendLayout();
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
            this.Book_Format.Location = new System.Drawing.Point(102, 50);
            this.Book_Format.Margin = new System.Windows.Forms.Padding(4);
            this.Book_Format.Name = "Book_Format";
            this.Book_Format.Size = new System.Drawing.Size(235, 23);
            this.Book_Format.TabIndex = 0;
            this.Book_Format.SelectedIndexChanged += new System.EventHandler(this.ListUpdate);
            this.Book_Format.Enter += new System.EventHandler(this.EnterObject);
            this.Book_Format.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nothing);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.Transparent;
            this.myButton1.Border = false;
            this.myButton1.BorderColor = System.Drawing.Color.Tomato;
            this.myButton1.BorderWidth = 1;
            this.myButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton1.ForeColor = System.Drawing.Color.Black;
            this.myButton1.Location = new System.Drawing.Point(14, 50);
            this.myButton1.Margin = new System.Windows.Forms.Padding(4);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(91, 25);
            this.myButton1.TabIndex = 1;
            this.myButton1.Text = "Format";
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.Transparent;
            this.myButton2.Border = false;
            this.myButton2.BorderColor = System.Drawing.Color.Tomato;
            this.myButton2.BorderWidth = 1;
            this.myButton2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton2.ForeColor = System.Drawing.Color.Black;
            this.myButton2.Location = new System.Drawing.Point(24, 82);
            this.myButton2.Margin = new System.Windows.Forms.Padding(4);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(81, 28);
            this.myButton2.TabIndex = 2;
            this.myButton2.Text = "Title";
            // 
            // Book_Title
            // 
            this.Book_Title.AcceptsTab = true;
            this.Book_Title.Location = new System.Drawing.Point(102, 82);
            this.Book_Title.Margin = new System.Windows.Forms.Padding(4);
            this.Book_Title.Name = "Book_Title";
            this.Book_Title.Size = new System.Drawing.Size(235, 23);
            this.Book_Title.TabIndex = 3;
            this.Book_Title.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Book_Title.Enter += new System.EventHandler(this.EnterObject);
            // 
            // Book_FileSize
            // 
            this.Book_FileSize.AcceptsTab = true;
            this.Book_FileSize.Location = new System.Drawing.Point(102, 118);
            this.Book_FileSize.Margin = new System.Windows.Forms.Padding(4);
            this.Book_FileSize.Name = "Book_FileSize";
            this.Book_FileSize.Size = new System.Drawing.Size(140, 23);
            this.Book_FileSize.TabIndex = 5;
            this.Book_FileSize.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Book_FileSize.Enter += new System.EventHandler(this.EnterObject);
            this.Book_FileSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.Transparent;
            this.myButton3.Border = false;
            this.myButton3.BorderColor = System.Drawing.Color.Tomato;
            this.myButton3.BorderWidth = 1;
            this.myButton3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton3.ForeColor = System.Drawing.Color.Black;
            this.myButton3.Location = new System.Drawing.Point(27, 118);
            this.myButton3.Margin = new System.Windows.Forms.Padding(4);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(67, 28);
            this.myButton3.TabIndex = 4;
            this.myButton3.Text = "File Size";
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.Color.Transparent;
            this.myButton4.Border = false;
            this.myButton4.BorderColor = System.Drawing.Color.Tomato;
            this.myButton4.BorderWidth = 1;
            this.myButton4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton4.ForeColor = System.Drawing.Color.Black;
            this.myButton4.Location = new System.Drawing.Point(177, 191);
            this.myButton4.Margin = new System.Windows.Forms.Padding(4);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(142, 28);
            this.myButton4.TabIndex = 7;
            this.myButton4.Text = "Upload Date";
            // 
            // Book_UploadDate
            // 
            this.Book_UploadDate.Location = new System.Drawing.Point(39, 227);
            this.Book_UploadDate.Margin = new System.Windows.Forms.Padding(4);
            this.Book_UploadDate.Name = "Book_UploadDate";
            this.Book_UploadDate.Size = new System.Drawing.Size(280, 23);
            this.Book_UploadDate.TabIndex = 8;
            this.Book_UploadDate.Enter += new System.EventHandler(this.EnterObject);
            // 
            // Book_PageNumbs
            // 
            this.Book_PageNumbs.AcceptsTab = true;
            this.Book_PageNumbs.Location = new System.Drawing.Point(102, 155);
            this.Book_PageNumbs.Margin = new System.Windows.Forms.Padding(4);
            this.Book_PageNumbs.Name = "Book_PageNumbs";
            this.Book_PageNumbs.Size = new System.Drawing.Size(235, 23);
            this.Book_PageNumbs.TabIndex = 10;
            this.Book_PageNumbs.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Book_PageNumbs.Enter += new System.EventHandler(this.EnterObject);
            this.Book_PageNumbs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.Color.Transparent;
            this.myButton5.Border = false;
            this.myButton5.BorderColor = System.Drawing.Color.Tomato;
            this.myButton5.BorderWidth = 1;
            this.myButton5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton5.ForeColor = System.Drawing.Color.Black;
            this.myButton5.Location = new System.Drawing.Point(27, 155);
            this.myButton5.Margin = new System.Windows.Forms.Padding(4);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(67, 28);
            this.myButton5.TabIndex = 9;
            this.myButton5.Text = "Page numbs";
            // 
            // myButton6
            // 
            this.myButton6.BackColor = System.Drawing.Color.Transparent;
            this.myButton6.Border = false;
            this.myButton6.BorderColor = System.Drawing.Color.Tomato;
            this.myButton6.BorderWidth = 1;
            this.myButton6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton6.ForeColor = System.Drawing.Color.Black;
            this.myButton6.Location = new System.Drawing.Point(39, 278);
            this.myButton6.Margin = new System.Windows.Forms.Padding(4);
            this.myButton6.Name = "myButton6";
            this.myButton6.Size = new System.Drawing.Size(150, 28);
            this.myButton6.TabIndex = 11;
            this.myButton6.Text = "Publisher";
            // 
            // myButton7
            // 
            this.myButton7.BackColor = System.Drawing.Color.Transparent;
            this.myButton7.Border = false;
            this.myButton7.BorderColor = System.Drawing.Color.Tomato;
            this.myButton7.BorderWidth = 1;
            this.myButton7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton7.ForeColor = System.Drawing.Color.Black;
            this.myButton7.Location = new System.Drawing.Point(27, 314);
            this.myButton7.Margin = new System.Windows.Forms.Padding(4);
            this.myButton7.Name = "myButton7";
            this.myButton7.Size = new System.Drawing.Size(67, 28);
            this.myButton7.TabIndex = 12;
            this.myButton7.Text = "Name";
            // 
            // myButton8
            // 
            this.myButton8.BackColor = System.Drawing.Color.Transparent;
            this.myButton8.Border = false;
            this.myButton8.BorderColor = System.Drawing.Color.Tomato;
            this.myButton8.BorderWidth = 1;
            this.myButton8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton8.ForeColor = System.Drawing.Color.Black;
            this.myButton8.Location = new System.Drawing.Point(27, 350);
            this.myButton8.Margin = new System.Windows.Forms.Padding(4);
            this.myButton8.Name = "myButton8";
            this.myButton8.Size = new System.Drawing.Size(67, 28);
            this.myButton8.TabIndex = 13;
            this.myButton8.Text = "Country";
            // 
            // myButton9
            // 
            this.myButton9.BackColor = System.Drawing.Color.Transparent;
            this.myButton9.Border = false;
            this.myButton9.BorderColor = System.Drawing.Color.Tomato;
            this.myButton9.BorderWidth = 1;
            this.myButton9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton9.ForeColor = System.Drawing.Color.Black;
            this.myButton9.Location = new System.Drawing.Point(27, 386);
            this.myButton9.Margin = new System.Windows.Forms.Padding(4);
            this.myButton9.Name = "myButton9";
            this.myButton9.Size = new System.Drawing.Size(67, 28);
            this.myButton9.TabIndex = 14;
            this.myButton9.Text = "City";
            // 
            // myButton10
            // 
            this.myButton10.BackColor = System.Drawing.Color.Transparent;
            this.myButton10.Border = false;
            this.myButton10.BorderColor = System.Drawing.Color.Tomato;
            this.myButton10.BorderWidth = 1;
            this.myButton10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton10.ForeColor = System.Drawing.Color.Black;
            this.myButton10.Location = new System.Drawing.Point(14, 422);
            this.myButton10.Margin = new System.Windows.Forms.Padding(4);
            this.myButton10.Name = "myButton10";
            this.myButton10.Size = new System.Drawing.Size(81, 28);
            this.myButton10.TabIndex = 15;
            this.myButton10.Text = "Foundation Year";
            // 
            // Publisher_Name
            // 
            this.Publisher_Name.AcceptsTab = true;
            this.Publisher_Name.Location = new System.Drawing.Point(102, 314);
            this.Publisher_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Publisher_Name.Name = "Publisher_Name";
            this.Publisher_Name.Size = new System.Drawing.Size(106, 23);
            this.Publisher_Name.TabIndex = 16;
            this.Publisher_Name.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Publisher_Name.Enter += new System.EventHandler(this.EnterObject);
            this.Publisher_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolsOrSpace);
            // 
            // Publisher_Country
            // 
            this.Publisher_Country.AcceptsTab = true;
            this.Publisher_Country.Location = new System.Drawing.Point(102, 350);
            this.Publisher_Country.Margin = new System.Windows.Forms.Padding(4);
            this.Publisher_Country.Name = "Publisher_Country";
            this.Publisher_Country.Size = new System.Drawing.Size(106, 23);
            this.Publisher_Country.TabIndex = 17;
            this.Publisher_Country.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Publisher_Country.Enter += new System.EventHandler(this.EnterObject);
            this.Publisher_Country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolOrDashOrSpace);
            // 
            // Publisher_City
            // 
            this.Publisher_City.AcceptsTab = true;
            this.Publisher_City.Location = new System.Drawing.Point(102, 386);
            this.Publisher_City.Margin = new System.Windows.Forms.Padding(4);
            this.Publisher_City.Name = "Publisher_City";
            this.Publisher_City.Size = new System.Drawing.Size(106, 23);
            this.Publisher_City.TabIndex = 18;
            this.Publisher_City.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Publisher_City.Enter += new System.EventHandler(this.EnterObject);
            this.Publisher_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolOrDashOrSpace);
            // 
            // Publisher_FoundationYear
            // 
            this.Publisher_FoundationYear.AcceptsTab = true;
            this.Publisher_FoundationYear.Location = new System.Drawing.Point(102, 422);
            this.Publisher_FoundationYear.Margin = new System.Windows.Forms.Padding(4);
            this.Publisher_FoundationYear.Name = "Publisher_FoundationYear";
            this.Publisher_FoundationYear.Size = new System.Drawing.Size(106, 23);
            this.Publisher_FoundationYear.TabIndex = 19;
            this.Publisher_FoundationYear.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Publisher_FoundationYear.Enter += new System.EventHandler(this.EnterObject);
            this.Publisher_FoundationYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // Publisher_StateRadio
            // 
            this.Publisher_StateRadio.AutoSize = true;
            this.Publisher_StateRadio.Location = new System.Drawing.Point(39, 459);
            this.Publisher_StateRadio.Margin = new System.Windows.Forms.Padding(4);
            this.Publisher_StateRadio.Name = "Publisher_StateRadio";
            this.Publisher_StateRadio.Size = new System.Drawing.Size(51, 19);
            this.Publisher_StateRadio.TabIndex = 20;
            this.Publisher_StateRadio.TabStop = true;
            this.Publisher_StateRadio.Text = "State";
            this.Publisher_StateRadio.UseVisualStyleBackColor = true;
            this.Publisher_StateRadio.Enter += new System.EventHandler(this.EnterObject);
            // 
            // Publisher_PrivateRadio
            // 
            this.Publisher_PrivateRadio.AutoSize = true;
            this.Publisher_PrivateRadio.Location = new System.Drawing.Point(116, 459);
            this.Publisher_PrivateRadio.Margin = new System.Windows.Forms.Padding(4);
            this.Publisher_PrivateRadio.Name = "Publisher_PrivateRadio";
            this.Publisher_PrivateRadio.Size = new System.Drawing.Size(61, 19);
            this.Publisher_PrivateRadio.TabIndex = 21;
            this.Publisher_PrivateRadio.TabStop = true;
            this.Publisher_PrivateRadio.Text = "Private";
            this.Publisher_PrivateRadio.UseVisualStyleBackColor = true;
            this.Publisher_PrivateRadio.Enter += new System.EventHandler(this.EnterObject);
            // 
            // myButton11
            // 
            this.myButton11.BackColor = System.Drawing.Color.Transparent;
            this.myButton11.Border = false;
            this.myButton11.BorderColor = System.Drawing.Color.Tomato;
            this.myButton11.BorderWidth = 1;
            this.myButton11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton11.ForeColor = System.Drawing.Color.Black;
            this.myButton11.Location = new System.Drawing.Point(256, 278);
            this.myButton11.Margin = new System.Windows.Forms.Padding(4);
            this.myButton11.Name = "myButton11";
            this.myButton11.Size = new System.Drawing.Size(150, 28);
            this.myButton11.TabIndex = 22;
            this.myButton11.Text = "Author";
            // 
            // myButton12
            // 
            this.myButton12.BackColor = System.Drawing.Color.Transparent;
            this.myButton12.Border = false;
            this.myButton12.BorderColor = System.Drawing.Color.Tomato;
            this.myButton12.BorderWidth = 1;
            this.myButton12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton12.ForeColor = System.Drawing.Color.Black;
            this.myButton12.Location = new System.Drawing.Point(74, 15);
            this.myButton12.Margin = new System.Windows.Forms.Padding(4);
            this.myButton12.Name = "myButton12";
            this.myButton12.Size = new System.Drawing.Size(168, 28);
            this.myButton12.TabIndex = 23;
            this.myButton12.Text = "Book file info";
            // 
            // Author_Id
            // 
            this.Author_Id.AcceptsTab = true;
            this.Author_Id.BackColor = System.Drawing.SystemColors.Window;
            this.Author_Id.Location = new System.Drawing.Point(315, 386);
            this.Author_Id.Margin = new System.Windows.Forms.Padding(4);
            this.Author_Id.Name = "Author_Id";
            this.Author_Id.Size = new System.Drawing.Size(106, 23);
            this.Author_Id.TabIndex = 29;
            this.Author_Id.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Author_Id.Enter += new System.EventHandler(this.EnterObject);
            this.Author_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Digit);
            // 
            // Author_Country
            // 
            this.Author_Country.AcceptsTab = true;
            this.Author_Country.Location = new System.Drawing.Point(315, 350);
            this.Author_Country.Margin = new System.Windows.Forms.Padding(4);
            this.Author_Country.Name = "Author_Country";
            this.Author_Country.Size = new System.Drawing.Size(106, 23);
            this.Author_Country.TabIndex = 28;
            this.Author_Country.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Author_Country.Enter += new System.EventHandler(this.EnterObject);
            this.Author_Country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolOrDashOrSpace);
            // 
            // Author_Name
            // 
            this.Author_Name.AcceptsTab = true;
            this.Author_Name.Location = new System.Drawing.Point(315, 314);
            this.Author_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Author_Name.Name = "Author_Name";
            this.Author_Name.Size = new System.Drawing.Size(106, 23);
            this.Author_Name.TabIndex = 27;
            this.Author_Name.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            this.Author_Name.Enter += new System.EventHandler(this.EnterObject);
            this.Author_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolsOrSpace);
            // 
            // myButton13
            // 
            this.myButton13.BackColor = System.Drawing.Color.Transparent;
            this.myButton13.Border = false;
            this.myButton13.BorderColor = System.Drawing.Color.Tomato;
            this.myButton13.BorderWidth = 1;
            this.myButton13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton13.ForeColor = System.Drawing.Color.Black;
            this.myButton13.Location = new System.Drawing.Point(241, 386);
            this.myButton13.Margin = new System.Windows.Forms.Padding(4);
            this.myButton13.Name = "myButton13";
            this.myButton13.Size = new System.Drawing.Size(67, 28);
            this.myButton13.TabIndex = 26;
            this.myButton13.Text = "Id";
            // 
            // myButton14
            // 
            this.myButton14.BackColor = System.Drawing.Color.Transparent;
            this.myButton14.Border = false;
            this.myButton14.BorderColor = System.Drawing.Color.Tomato;
            this.myButton14.BorderWidth = 1;
            this.myButton14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton14.ForeColor = System.Drawing.Color.Black;
            this.myButton14.Location = new System.Drawing.Point(241, 350);
            this.myButton14.Margin = new System.Windows.Forms.Padding(4);
            this.myButton14.Name = "myButton14";
            this.myButton14.Size = new System.Drawing.Size(67, 28);
            this.myButton14.TabIndex = 25;
            this.myButton14.Text = "Country";
            // 
            // myButton15
            // 
            this.myButton15.BackColor = System.Drawing.Color.Transparent;
            this.myButton15.Border = false;
            this.myButton15.BorderColor = System.Drawing.Color.Tomato;
            this.myButton15.BorderWidth = 1;
            this.myButton15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton15.ForeColor = System.Drawing.Color.Black;
            this.myButton15.Location = new System.Drawing.Point(241, 314);
            this.myButton15.Margin = new System.Windows.Forms.Padding(4);
            this.myButton15.Name = "myButton15";
            this.myButton15.Size = new System.Drawing.Size(67, 28);
            this.myButton15.TabIndex = 24;
            this.myButton15.Text = "Name";
            // 
            // myButton16
            // 
            this.myButton16.BackColor = System.Drawing.Color.Tomato;
            this.myButton16.Border = false;
            this.myButton16.BorderColor = System.Drawing.Color.Tomato;
            this.myButton16.BorderWidth = 1;
            this.myButton16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton16.ForeColor = System.Drawing.Color.White;
            this.myButton16.Location = new System.Drawing.Point(315, 422);
            this.myButton16.Margin = new System.Windows.Forms.Padding(4);
            this.myButton16.Name = "myButton16";
            this.myButton16.Size = new System.Drawing.Size(106, 28);
            this.myButton16.TabIndex = 30;
            this.myButton16.Text = "Add";
            this.myButton16.Click += new System.EventHandler(this.myButton16_Click);
            // 
            // FinalBookFile
            // 
            this.FinalBookFile.AutoWordSelection = true;
            this.FinalBookFile.Location = new System.Drawing.Point(482, 106);
            this.FinalBookFile.Margin = new System.Windows.Forms.Padding(4);
            this.FinalBookFile.Name = "FinalBookFile";
            this.FinalBookFile.Size = new System.Drawing.Size(437, 440);
            this.FinalBookFile.TabIndex = 31;
            this.FinalBookFile.Text = "";
            this.FinalBookFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FinalBookFile_KeyPress);
            // 
            // myButton17
            // 
            this.myButton17.BackColor = System.Drawing.Color.Tomato;
            this.myButton17.Border = false;
            this.myButton17.BorderColor = System.Drawing.Color.Tomato;
            this.myButton17.BorderWidth = 1;
            this.myButton17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton17.ForeColor = System.Drawing.Color.White;
            this.myButton17.Location = new System.Drawing.Point(798, 13);
            this.myButton17.Margin = new System.Windows.Forms.Padding(4);
            this.myButton17.Name = "myButton17";
            this.myButton17.Size = new System.Drawing.Size(116, 38);
            this.myButton17.TabIndex = 32;
            this.myButton17.Text = "SAVE";
            this.myButton17.Click += new System.EventHandler(this.myButton17_Click);
            // 
            // myButton18
            // 
            this.myButton18.BackColor = System.Drawing.Color.Tomato;
            this.myButton18.Border = false;
            this.myButton18.BorderColor = System.Drawing.Color.Tomato;
            this.myButton18.BorderWidth = 1;
            this.myButton18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton18.ForeColor = System.Drawing.Color.White;
            this.myButton18.Location = new System.Drawing.Point(798, 62);
            this.myButton18.Margin = new System.Windows.Forms.Padding(4);
            this.myButton18.Name = "myButton18";
            this.myButton18.Size = new System.Drawing.Size(116, 38);
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
            this.Book_FileSize_Type.Location = new System.Drawing.Point(256, 118);
            this.Book_FileSize_Type.Margin = new System.Windows.Forms.Padding(4);
            this.Book_FileSize_Type.Name = "Book_FileSize_Type";
            this.Book_FileSize_Type.Size = new System.Drawing.Size(81, 23);
            this.Book_FileSize_Type.TabIndex = 34;
            this.Book_FileSize_Type.SelectedIndexChanged += new System.EventHandler(this.ListUpdate);
            this.Book_FileSize_Type.Enter += new System.EventHandler(this.EnterObject);
            this.Book_FileSize_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nothing);
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.Color.DimGray;
            this.ErrorBox.Location = new System.Drawing.Point(-1, 523);
            this.ErrorBox.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.Size = new System.Drawing.Size(484, 23);
            this.ErrorBox.TabIndex = 35;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // myButton19
            // 
            this.myButton19.BackColor = System.Drawing.Color.Tomato;
            this.myButton19.Border = false;
            this.myButton19.BorderColor = System.Drawing.Color.Tomato;
            this.myButton19.BorderWidth = 1;
            this.myButton19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton19.ForeColor = System.Drawing.Color.White;
            this.myButton19.Location = new System.Drawing.Point(315, 459);
            this.myButton19.Margin = new System.Windows.Forms.Padding(4);
            this.myButton19.Name = "myButton19";
            this.myButton19.Size = new System.Drawing.Size(106, 20);
            this.myButton19.TabIndex = 36;
            this.myButton19.Text = "delete last";
            this.myButton19.Click += new System.EventHandler(this.myButton19_Click);
            // 
            // myButton20
            // 
            this.myButton20.BackColor = System.Drawing.Color.Tomato;
            this.myButton20.Border = false;
            this.myButton20.BorderColor = System.Drawing.Color.Tomato;
            this.myButton20.BorderWidth = 1;
            this.myButton20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton20.ForeColor = System.Drawing.Color.White;
            this.myButton20.Location = new System.Drawing.Point(315, 486);
            this.myButton20.Margin = new System.Windows.Forms.Padding(4);
            this.myButton20.Name = "myButton20";
            this.myButton20.Size = new System.Drawing.Size(106, 20);
            this.myButton20.TabIndex = 37;
            this.myButton20.Text = "clear all";
            this.myButton20.Click += new System.EventHandler(this.myButton20_Click);
            // 
            // myButton21
            // 
            this.myButton21.BackColor = System.Drawing.Color.Transparent;
            this.myButton21.Border = false;
            this.myButton21.BorderColor = System.Drawing.Color.Tomato;
            this.myButton21.BorderWidth = 1;
            this.myButton21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton21.ForeColor = System.Drawing.Color.Black;
            this.myButton21.Location = new System.Drawing.Point(14, 194);
            this.myButton21.Margin = new System.Windows.Forms.Padding(4);
            this.myButton21.Name = "myButton21";
            this.myButton21.Size = new System.Drawing.Size(91, 25);
            this.myButton21.TabIndex = 39;
            this.myButton21.Text = "UDK";
            // 
            // Book_UDK
            // 
            this.Book_UDK.AcceptsTab = true;
            this.Book_UDK.Location = new System.Drawing.Point(102, 196);
            this.Book_UDK.Margin = new System.Windows.Forms.Padding(4);
            this.Book_UDK.Name = "Book_UDK";
            this.Book_UDK.Size = new System.Drawing.Size(87, 23);
            this.Book_UDK.TabIndex = 40;
            this.Book_UDK.TextChanged += new System.EventHandler(this.TextInfoUpdate);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tool_menu);
            this.panel2.Location = new System.Drawing.Point(343, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 44);
            this.panel2.TabIndex = 41;
            // 
            // tool_menu
            // 
            this.tool_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSplitButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripButton5});
            this.tool_menu.Location = new System.Drawing.Point(0, 0);
            this.tool_menu.Name = "tool_menu";
            this.tool_menu.Size = new System.Drawing.Size(448, 25);
            this.tool_menu.TabIndex = 0;
            this.tool_menu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton1.Text = "find";
            this.toolStripButton1.Click += new System.EventHandler(this.CreateFindMenu);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem1,
            this.yearToolStripMenuItem1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripSplitButton1.Text = "Sorting";
            // 
            // nameToolStripMenuItem1
            // 
            this.nameToolStripMenuItem1.Name = "nameToolStripMenuItem1";
            this.nameToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.nameToolStripMenuItem1.Text = "Name";
            this.nameToolStripMenuItem1.Click += new System.EventHandler(this.SortingByName);
            // 
            // yearToolStripMenuItem1
            // 
            this.yearToolStripMenuItem1.Name = "yearToolStripMenuItem1";
            this.yearToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.yearToolStripMenuItem1.Text = "Year";
            this.yearToolStripMenuItem1.Click += new System.EventHandler(this.SortingByYear);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton2.Text = "Clear";
            this.toolStripButton2.Click += new System.EventHandler(this.ClearAll);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Next";
            this.toolStripButton3.Click += new System.EventHandler(this.Next);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Previous";
            this.toolStripButton4.Click += new System.EventHandler(this.Previous);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "CloseMenu";
            this.toolStripButton5.Click += new System.EventHandler(this.CloseMenu);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.OpenAbout);
            // 
            // StateLine
            // 
            this.StateLine.Location = new System.Drawing.Point(15, 554);
            this.StateLine.Name = "StateLine";
            this.StateLine.Size = new System.Drawing.Size(193, 96);
            this.StateLine.TabIndex = 42;
            this.StateLine.Text = "";
            // 
            // but_open_menu
            // 
            this.but_open_menu.BackColor = System.Drawing.Color.Tomato;
            this.but_open_menu.Border = false;
            this.but_open_menu.BorderColor = System.Drawing.Color.Tomato;
            this.but_open_menu.BorderWidth = 1;
            this.but_open_menu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_open_menu.ForeColor = System.Drawing.Color.White;
            this.but_open_menu.Location = new System.Drawing.Point(691, 69);
            this.but_open_menu.Name = "but_open_menu";
            this.but_open_menu.Size = new System.Drawing.Size(100, 30);
            this.but_open_menu.TabIndex = 43;
            this.but_open_menu.Text = "Open Menu";
            this.but_open_menu.Visible = false;
            this.but_open_menu.Click += new System.EventHandler(this.OpenMenu);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(934, 652);
            this.Controls.Add(this.but_open_menu);
            this.Controls.Add(this.StateLine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Book_UDK);
            this.Controls.Add(this.myButton21);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tool_menu.ResumeLayout(false);
            this.tool_menu.PerformLayout();
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
        private MyBut.MyButton myButton21;
        private TextBox Book_UDK;
        private Panel panel2;
        private ToolStrip tool_menu;
        private ToolStripButton toolStripButton1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem nameToolStripMenuItem1;
        private ToolStripMenuItem yearToolStripMenuItem1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private RichTextBox StateLine;
        private ToolStripButton toolStripButton5;
        private MyBut.MyButton but_open_menu;
        private ToolStripButton toolStripButton6;
    }
}