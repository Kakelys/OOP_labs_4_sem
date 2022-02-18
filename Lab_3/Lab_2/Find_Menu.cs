using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Find_Menu : Form
    {
        public Find_Menu()
        {
            InitializeComponent();

        }


        private void Choose(object sender, ItemCheckEventArgs e)
        {
           
            UpdateTextBox(e.Index,(int)e.CurrentValue);
        }

        private void UpdateTextBox(int index, int status)
        {
            string name = "";
            switch (index)
            {
                case 0:
                    name = "Find_Publisher";
                    break;
                case 1:
                    name = "Find_PublishingYear";
                    break;
                case 2:
                    name = "Find_PageRange";
                    break;
            }
            //Событие возвращает текущее значение статуса, так что обратные значения
            int y = Menu_Box.Location.Y + (index) * (Menu_Box.Size.Height / Menu_Box.Items.Count);
            switch (status)
            {
                case 1:
                    foreach (var elem in Controls.Find(name, true))
                    {
                        Controls.Remove(elem);
                    }
                    break;

                case 0:
                    var box = new TextBox();
                    box.Location = new Point(Menu_Box.Location.X + Menu_Box.Size.Width, y);
                    box.Size = new Size(200, Menu_Box.Size.Height / Menu_Box.Items.Count);
                    box.Name = name;
                    box.WordWrap = false;
                    box.Multiline = true;
                    box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoEnter);
                    Controls.Add(box);
                    break;
            }

        
        }

        private void NoEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                e.Handled = true;
            }
            if (e.KeyChar.Equals('\n'))
            {
                e.Handled = true;
            }
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (BookFile.books.Count < 0)
            {
                throw new Exception("No books loaded");
            }
        }
    }
    
}
