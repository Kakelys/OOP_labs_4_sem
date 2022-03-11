namespace Lab_2
{
    partial class About
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
            this.myButton1 = new MyBut.MyButton();
            this.myButton2 = new MyBut.MyButton();
            this.myButton3 = new MyBut.MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.Transparent;
            this.myButton1.Border = false;
            this.myButton1.BorderColor = System.Drawing.Color.Tomato;
            this.myButton1.BorderWidth = 1;
            this.myButton1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(12, 12);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(185, 30);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "Author: Me";
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.Transparent;
            this.myButton2.Border = false;
            this.myButton2.BorderColor = System.Drawing.Color.Tomato;
            this.myButton2.BorderWidth = 1;
            this.myButton2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(12, 48);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(185, 30);
            this.myButton2.TabIndex = 1;
            this.myButton2.Text = "Version: 1.01";
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.Tomato;
            this.myButton3.Border = false;
            this.myButton3.BorderColor = System.Drawing.Color.Tomato;
            this.myButton3.BorderWidth = 1;
            this.myButton3.Font = new System.Drawing.Font("Verdana", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton3.ForeColor = System.Drawing.Color.White;
            this.myButton3.Location = new System.Drawing.Point(54, 84);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(92, 33);
            this.myButton3.TabIndex = 2;
            this.myButton3.Text = "OK";
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(202, 128);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private MyBut.MyButton myButton1;
        private MyBut.MyButton myButton2;
        private MyBut.MyButton myButton3;
    }
}