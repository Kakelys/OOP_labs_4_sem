using System.Diagnostics;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Json;

namespace Lab_2
{
    public partial class Form1 : Form
    {

        private static Form1 form;
        public Form1()
        {
            InitializeComponent();
            Singleton.GetInstance().bgColor = this.BackColor;
            Singleton.GetInstance().height = this.Height;
            Singleton.GetInstance().width = this.Width;
            form = this;
        }

        public static Control GetElement(string name)
        {
            var temp = form.Controls.Find(name, true) ?? null;
            return temp[0];
        }

        //only symbol or -
        private void SymbolOrDashOrSpace(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar) || e.KeyChar.Equals(Char.IsSymbol('-')) || e.KeyChar.Equals(Char.IsSymbol(' '));
        }
        //only digit
        private void Digit(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(Char.IsDigit(e.KeyChar) ||  (e.KeyChar == (char)8));
        }
        //only symbols
        private void Symbols(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }
        //only symbols or space
        private void SymbolsOrSpace(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar) || e.KeyChar.Equals(Char.IsSymbol(' '));
        }
        //Nothing
        private void Nothing(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void UpdateBookInfo()
        {
           
                if (Book_Format.Text != "" || Book_Title.Text != "" || Book_FileSize.Text != "" ||
                    Book_PageNumbs.Text != "")
                {
                    FinalBookFile.Text += "Book info:\n\n";
                }
                else
                {
                    return;
                }


                if (Book_Format.Text != "")
                {
                    FinalBookFile.Text += $"Format: {Book_Format.Text}\n";
                }

                if (Book_Title.Text != "")
                {
                    FinalBookFile.Text += $"Title: {Book_Title.Text}\n";
                }

                if (Book_FileSize.Text != "")
                {
                    string fileSizeType = Book_FileSize_Type.Text == "" ? "Mb" : Book_FileSize_Type.Text;
                    FinalBookFile.Text += $"File Size: {Book_FileSize.Text} {fileSizeType}\n";
                }

                if (Book_PageNumbs.Text != "")
                {
                    FinalBookFile.Text += $"Page Numbers: {Book_PageNumbs.Text}\n";
                }

                if (Book_UploadDate.Text != "")
                {
                    FinalBookFile.Text += $"Upload Date: {Book_UploadDate.Text}\n";
                }


                FinalBookFile.Text += "\n";
        }

        private void UpdatePublisherInfo()
        {
            if (Publisher_Name.Text != "" || Publisher_Country.Text != "" || Publisher_City.Text != ""
                || Publisher_FoundationYear.Text != "" || Publisher_PrivateRadio.Checked ||
                Publisher_StateRadio.Checked)
            {
                FinalBookFile.Text += "Publisher info: \n";
            }
            else
            {
                return;
            }

            if (Publisher_Name.Text != "")
            {
                FinalBookFile.Text += $"Name: {Publisher_Name.Text}\n";
            }
            if (Publisher_Country.Text != "")
            {
                FinalBookFile.Text += $"Country: {Publisher_Country.Text}\n";
            }
            if (Publisher_City.Text != "")
            {
                FinalBookFile.Text += $"City: {Publisher_City.Text}\n";
            }
            if (Publisher_FoundationYear.Text != "")
            {
                FinalBookFile.Text += $"Foundation Year: {Publisher_FoundationYear.Text}\n";
            }
            if (Publisher_StateRadio.Checked || Publisher_PrivateRadio.Checked)
            {
                string type = Publisher_PrivateRadio.Checked ? "Private" : "State";
                FinalBookFile.Text += $"Type: {type}\n";
            }
            FinalBookFile.Text += $"\n";
        }

        private void UpdateAuthorInfo()
        {
            if (BookFile.authors.Count > 0)
            {
                FinalBookFile.Text += "Authors: \n";
            }
            else
            {
                return;
            }

            foreach (var elem in BookFile.authors)
            {
                FinalBookFile.Text += $"fio: {elem.fio}\tcountry: {elem.country}\tid: {elem.id}\n";
            }
        }

        private void UpdateFinalBookInfo()
        {
            FinalBookFile.Text = "";

            UpdateBookInfo();
            UpdatePublisherInfo();
            UpdateAuthorInfo();
         
        }

        //add Author
        private void myButton16_Click(object sender, EventArgs e)
        {
            try
            {
                BookFile.authors.Add(new Author(Author_Name.Text, Author_Country.Text, int.Parse(Author_Id.Text)));
                Author_Name.Text = "";
                Author_Country.Text = "";
                Author_Id.Text = "";


                UpdateFinalBookInfo();
            }
            catch(Exception ex)
            {
              CauseException(ex);
            }
        }

        private void CauseException(Exception ex)
        {

            if (ErrorBox.Text != "")
            {
                return;
            }

           

            ErrorBox.BackColor = Color.DarkRed;
            ErrorBox.ForeColor = Color.AntiqueWhite;
            ErrorBox.Text = ex.Message;

            TimerCallback tm = new TimerCallback(DeleteExceptionMessage);
            System.Threading.Timer timer = new System.Threading.Timer(tm, 0, 5000, 0);
            
        }

        private void DeleteExceptionMessage(object obj)
        {
            try
            {
                ErrorBox.Text = "";
                ErrorBox.ForeColor = Color.Black;
                ErrorBox.BackColor = Color.DimGray;
            }
            catch
            {
            }
        }

        private void FinalBookFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void EnterObject(object sender, EventArgs e)
        {
            UpdateFinalBookInfo();
        }

        private void SaveFile()
        {
            try
            {
                saveFileDialog1.Filter = "Json file(*.json)|*.json";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                string filePath = saveFileDialog1.FileName;
                //Проверка параметров на пустые строки
                if (Publisher_Name.Text != "" || Publisher_Country.Text != "" || Publisher_City.Text != ""
                    || Publisher_FoundationYear.Text != "" || Publisher_PrivateRadio.Checked ||
                    Publisher_StateRadio.Checked || Book_Format.Text != "" || Book_Title.Text != "" || Book_FileSize.Text != "" ||
                    Book_FileSize_Type.Text != "" || Book_PageNumbs.Text != "" || BookFile.authors.Count > 0)
                {
                }
                else
                {
                    throw new Exception("One of the fields is empty or the authors are not specified");
                }


                BookFile book = new BookFile(
                    Book_Format.Text, Book_Title.Text, int.Parse(Book_FileSize.Text), Book_FileSize_Type.Text,
                    int.Parse(Book_PageNumbs.Text), Book_UploadDate.Text,
                    new Publisher(Publisher_Name.Text, Publisher_Country.Text, Publisher_City.Text,
                        int.Parse(Publisher_FoundationYear.Text), Publisher_StateRadio.Checked ? 0 : 1));

               

                DataContractJsonSerializer Jmatter = new DataContractJsonSerializer(typeof(BookFile));
                using (FileStream fj = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    Jmatter.WriteObject(fj, book);
                }
            }
            catch (Exception ex)
            {
                CauseException(ex);
            }
        }

        private void LoadFile()
        {
           
                openFileDialog1.Filter = "Json file(*.json)|*.json";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                string filePath = openFileDialog1.FileName;

                BookFile book = new BookFile();
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    var ser = new DataContractJsonSerializer(book.GetType());
                    book = ser.ReadObject(fs) as BookFile;
                }

                ClearAll();


                Book_Format.Text = book.format;
                Book_Title.Text = book.title;
                Book_FileSize.Text = book.fileSize.ToString();
                Book_FileSize_Type.Text = book.fileSizeType;
                Book_PageNumbs.Text = book.pageNumbers.ToString();
                Book_UploadDate.Text = book.uploadDate.ToString();

                Publisher_Name.Text = book.publisher._name;
                Publisher_Country.Text = book.publisher._country;
                Publisher_City.Text = book.publisher._city;
                Publisher_FoundationYear.Text = book.publisher.FoundationYear.ToString();
                if (book.publisher.PubType == 0)
                {
                    Publisher_StateRadio.Checked = true;
                }
                else
                {
                    Publisher_PrivateRadio.Checked = true;
                }

                foreach (var elem in book._authors)
                {
                    BookFile.authors.Add(elem);
                }

                UpdateFinalBookInfo();
       
        }

        private void ClearAll()
        {
            Book_Format.Text = "";
            Book_FileSize.Text = "";
            Book_FileSize_Type.Text = "";
            Book_Title.Text = "";
            Book_PageNumbs.Text = "";

            Publisher_Name.Text = "";
            Publisher_Country.Text = "";
            Publisher_City.Text = "";
            Publisher_FoundationYear.Text = "";
            Publisher_PrivateRadio.Checked = false;
            Publisher_StateRadio.Checked = false;
            BookFile.authors.Clear();
        }

        //save button
        private void myButton17_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        //load button
        private void myButton18_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
        //remove all: authors
        private void myButton20_Click(object sender, EventArgs e)
        {
            BookFile.authors.Clear();
            UpdateFinalBookInfo();
        }
        //delete last: authors
        private void myButton19_Click(object sender, EventArgs e)
        {
            BookFile.authors.Remove(BookFile.authors.Last());
            UpdateFinalBookInfo();
        }

        private void myButton21_Click(object sender, EventArgs e)
        {
            AbstractFactory.AFCreate(this);
        }

        private void myButton22_Click(object sender, EventArgs e)
        {
            Director.DMain(this);
        }

        private void myButton23_Click(object sender, EventArgs e)
        {
            BookFile book = new BookFile(
                Book_Format.Text, Book_Title.Text, int.Parse(Book_FileSize.Text), Book_FileSize_Type.Text,
                int.Parse(Book_PageNumbs.Text), Book_UploadDate.Text,
                new Publisher(Publisher_Name.Text, Publisher_Country.Text, Publisher_City.Text,
                    int.Parse(Publisher_FoundationYear.Text), Publisher_StateRadio.Checked ? 0 : 1));

            var copy = book.DeepCopy();
        }
    }
}