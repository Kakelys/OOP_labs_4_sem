namespace Lab_2
{
    partial class Find_Menu
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
            this.Menu_Box = new System.Windows.Forms.CheckedListBox();
            this.myButton1 = new MyBut.MyButton();
            this.myButton2 = new MyBut.MyButton();
            this.SuspendLayout();
            // 
            // Menu_Box
            // 
            this.Menu_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Menu_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Menu_Box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_Box.FormattingEnabled = true;
            this.Menu_Box.Items.AddRange(new object[] {
            "Publisher",
            "Publishing Year",
            "Page Range"});
            this.Menu_Box.Location = new System.Drawing.Point(22, 48);
            this.Menu_Box.Name = "Menu_Box";
            this.Menu_Box.Size = new System.Drawing.Size(109, 54);
            this.Menu_Box.TabIndex = 0;
            this.Menu_Box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Choose);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.Transparent;
            this.myButton1.Border = false;
            this.myButton1.BorderColor = System.Drawing.Color.Tomato;
            this.myButton1.BorderWidth = 1;
            this.myButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(11, 12);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(90, 30);
            this.myButton1.TabIndex = 1;
            this.myButton1.Text = "Choose find options";
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.myButton2.Border = false;
            this.myButton2.BorderColor = System.Drawing.Color.Tomato;
            this.myButton2.BorderWidth = 1;
            this.myButton2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(22, 122);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(100, 30);
            this.myButton2.TabIndex = 2;
            this.myButton2.Text = "Confirm";
            this.myButton2.Click += new System.EventHandler(this.Confirm);
            // 
            // Find_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(347, 166);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.Menu_Box);
            this.Controls.Add(this.myButton1);
            this.Name = "Find_Menu";
            this.Text = "Find_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox Menu_Box;
        private MyBut.MyButton myButton1;
        private MyBut.MyButton myButton2;
    }
}