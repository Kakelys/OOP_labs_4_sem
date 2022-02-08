namespace Calc
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
            this.gender = new Calc.MyButton();
            this.MyBut1 = new Calc.MyButton();
            this.MyBut2 = new Calc.MyButton();
            this.mybut3 = new Calc.MyButton();
            this.age = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.myButton5 = new Calc.MyButton();
            this.mubyt4 = new Calc.MyButton();
            this.goal = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.DarkSalmon;
            this.gender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.ForeColor = System.Drawing.Color.White;
            this.gender.Location = new System.Drawing.Point(24, 89);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(88, 28);
            this.gender.TabIndex = 0;
            this.gender.Text = "gender:";
            // 
            // MyBut1
            // 
            this.MyBut1.BackColor = System.Drawing.Color.DarkSalmon;
            this.MyBut1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyBut1.ForeColor = System.Drawing.Color.White;
            this.MyBut1.Location = new System.Drawing.Point(24, 138);
            this.MyBut1.Name = "MyBut1";
            this.MyBut1.Size = new System.Drawing.Size(88, 25);
            this.MyBut1.TabIndex = 1;
            this.MyBut1.Text = "age:";
            // 
            // MyBut2
            // 
            this.MyBut2.BackColor = System.Drawing.Color.DarkSalmon;
            this.MyBut2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyBut2.ForeColor = System.Drawing.Color.White;
            this.MyBut2.Location = new System.Drawing.Point(24, 186);
            this.MyBut2.Name = "MyBut2";
            this.MyBut2.Size = new System.Drawing.Size(88, 22);
            this.MyBut2.TabIndex = 2;
            this.MyBut2.Text = "weight:";
            // 
            // mybut3
            // 
            this.mybut3.BackColor = System.Drawing.Color.DarkSalmon;
            this.mybut3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mybut3.ForeColor = System.Drawing.Color.White;
            this.mybut3.Location = new System.Drawing.Point(24, 226);
            this.mybut3.Name = "mybut3";
            this.mybut3.Size = new System.Drawing.Size(88, 28);
            this.mybut3.TabIndex = 3;
            this.mybut3.Text = "height:";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(102, 140);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 23);
            this.age.TabIndex = 5;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(102, 186);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 23);
            this.weight.TabIndex = 6;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(102, 231);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 23);
            this.height.TabIndex = 7;
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.Color.Tomato;
            this.myButton5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton5.ForeColor = System.Drawing.Color.White;
            this.myButton5.Location = new System.Drawing.Point(68, 326);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(155, 45);
            this.myButton5.TabIndex = 8;
            this.myButton5.Text = "Calculate";
            this.myButton5.Click += new System.EventHandler(this.myButton5_Click);
            // 
            // mubyt4
            // 
            this.mubyt4.BackColor = System.Drawing.Color.DarkSalmon;
            this.mubyt4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mubyt4.ForeColor = System.Drawing.Color.White;
            this.mubyt4.Location = new System.Drawing.Point(24, 277);
            this.mubyt4.Name = "mubyt4";
            this.mubyt4.Size = new System.Drawing.Size(88, 20);
            this.mubyt4.TabIndex = 9;
            this.mubyt4.Text = "goal:";
            // 
            // goal
            // 
            this.goal.FormattingEnabled = true;
            this.goal.Items.AddRange(new object[] {
            "weight loss",
            "rapid weight loss",
            "no weight loss"});
            this.goal.Location = new System.Drawing.Point(102, 277);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(121, 20);
            this.goal.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(118, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 16);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 16);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(245, 93);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(122, 16);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "Attack Helicopter";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.DarkSalmon;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Location = new System.Drawing.Point(440, 117);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(287, 240);
            this.Output.TabIndex = 14;
            this.Output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.mubyt4);
            this.Controls.Add(this.myButton5);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.age);
            this.Controls.Add(this.mybut3);
            this.Controls.Add(this.MyBut2);
            this.Controls.Add(this.MyBut1);
            this.Controls.Add(this.gender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private MyButton gender;
        private MyButton MyBut1;
        private MyButton MyBut2;
        private MyButton mybut3;
        private TextBox age;
        private TextBox weight;
        private TextBox height;
        private MyButton myButton5;
        private MyButton mubyt4;
        private ComboBox goal;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RichTextBox Output;
    }
}