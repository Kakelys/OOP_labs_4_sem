using System.Runtime;
using System.Text.RegularExpressions;

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

            var trueIndexes = new bool[BookFile.books.Count];
            for (var i = 0; i < BookFile.books.Count; i++)
            {
                trueIndexes[i] = true;
            }

            PublisherFind(ref trueIndexes);
            PublishingYear(ref trueIndexes);
            PageRange(ref trueIndexes);


            Form1.ApplyFind(trueIndexes, this.Owner);
            
        }

        private void PublisherFind(ref bool[] indexes)
        {
            var elem = Controls.Find("Find_Publisher", true);

            if (elem.Length == 0)
            {
                return;
            }

            var find = elem[0].Text;
            MatchCollection matches;
            Regex regex = new Regex(find);
            for (var i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] == false)
                    continue;
                if (!regex.IsMatch(BookFile.books[i].publisher._name))
                {
                    indexes[i] = false;
                }
            }

            
        }

        private void PublishingYear(ref bool[] indexes)
        {
            var elem = Controls.Find("Find_PublishingYear", true);
            if (elem.Length == 0)
            {
                return;
            }
            var find = elem[0].Text;

            Regex regex = new Regex(find);


            

            for (var i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] == false)
                    continue;

                

                if (!regex.IsMatch(BookFile.books[i].uploadDate))
                {
                    indexes[i] = false;
                }
            }
        }

        private void PageRange(ref bool[] indexes)
        {
            var elem = Controls.Find("Find_PageRange", true);
            if (elem.Length == 0)
            {
                return;
            }
            var find = elem[0].Text;
            var number = int.Parse(find);

            int div = number / 10;
            var finalRegex = "^("; //    $/

            for (int i = 0; i < div.ToString().Length; i++)
            {

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                    {

                        finalRegex += $"[0-9]";
                    }
                    else
                    {

                        finalRegex += $"[1-9]";
                    }
                }

                finalRegex += "|";
            }
            for (int j = 0; j < find.Length; j++)
            {
                if (j == 0)
                {
                    finalRegex += j == find.Length - 1 ? $"[1-{find[j]}]" : $"[1-{find[j]}]";
                }
                else
                {
                    finalRegex += j == find.Length - 1 ? $"[0-{find[j]}]" : $"[0-{find[j]}]";
                }

            }
            finalRegex += ")$";


            Regex regex = new Regex(finalRegex);
            
            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] == false)
                    continue;

                MatchCollection match = regex.Matches(BookFile.books[i].pageNumbers);
                if (match.Count == 0)
                {
                    indexes[i] = false;
                }
            }

        }
    }

    
}
