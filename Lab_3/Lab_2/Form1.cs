using System;
using System.CodeDom;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using MyBut;
using System.ComponentModel.DataAnnotations;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Multiselect = true;
            UpdateState();



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
                    Book_PageNumbs.Text != "" || Book_UDK.Text != "")
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

                if (Book_UDK.Text != "")
                {
                    FinalBookFile.Text += $"UDK: {Book_UDK.Text}\n";
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
            if (Book_UDK.Text != "")
            {
                FinalBookFile.Text += $"UDK: {Book_UDK.Text}\n";
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
                ChangeLastActivity("Add Author");
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
                //Change Activity
                ChangeLastActivity("Save book");


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
                    Book_PageNumbs.Text, Book_UploadDate.Text,
                    new Publisher(Publisher_Name.Text, Publisher_Country.Text, Publisher_City.Text,
                        int.Parse(Publisher_FoundationYear.Text), Publisher_StateRadio.Checked ? 0 : 1),Book_UDK.Text);

                var results1 = new List<ValidationResult>();
                var context1 = new ValidationContext(book.publisher);
                if (!Validator.TryValidateObject(book.publisher, context1, results1, true))
                {
                    string errorStr = "";
                    foreach (var elem in results1)
                    {
                        errorStr += elem.ErrorMessage;
                    }
                    throw new Exception(errorStr);
                }

                var results2 = new List<ValidationResult>();
                var context2 = new ValidationContext(book);
                if (!Validator.TryValidateObject(book, context2, results2, true))
                {
                    string errorStr = "";
                    foreach (var elem in results2)
                    {
                        errorStr += elem.ErrorMessage;
                    }
                    throw new Exception(errorStr);
                }


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


            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Json file(*.json)|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var arrFiles = openFileDialog1.FileNames;
            string filePath;
            if (arrFiles.Length == 1)
            {
                filePath = arrFiles[0];
            }
            else
            {
                DeleteLoadedBooks();
                //Create simple rectangle with text
                MyButton loaded = new MyButton();
                loaded.Location = new Point(FinalBookFile.Location.X - 110, FinalBookFile.Location.Y);
                loaded.Text = "Loaded Books:";
                loaded.Name = "Loaded_Name";
                loaded.BackColor = Color.Transparent;
                loaded.ForeColor = Color.Black;
                this.Controls.Add(loaded);
                //ListView for books
                ListView books = new ListView();
                //RichTextBox books = new RichTextBox();
                books.Location = new Point(loaded.Location.X, loaded.Location.Y + loaded.Size.Height);
                books.Size = new Size(loaded.Size.Width, loaded.Size.Height*3);
                //books.WordWrap = false;
                books.Name = "Loaded_Books_All";
                books.DoubleClick += new System.EventHandler(ChooseBook);
                this.Controls.Add(books);

                
                foreach (var elem in arrFiles)
                {
                    BookFile book = DeserializeBookFile(elem);
                    //take only name of file(without .json)
                    //string str = elem.Substring(elem.LastIndexOf('\\')+1);
                    //str = str.Remove(str.LastIndexOf('.'));
                    //    str += $"({book.title})";

                    books.Items.Add($"{book.title}");
                    

                    BookFile.books.Add(book);
                
                }

                //change Activity
                ChangeLastActivity("Loading book(s)");
                return;
            }
            
            LoadBookFileIn(filePath);
        }

        private BookFile DeserializeBookFile(string filePath)
        {
            BookFile book = new BookFile();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                var ser = new DataContractJsonSerializer(book.GetType());
                book = ser.ReadObject(fs) as BookFile;
            }

            return book;
        }

        private void DeleteLoadedBooks()
        {
            BookFile.books.Clear();
            foreach (var elem in Controls.Find("Loaded_Name", true))
            {
                Controls.Remove(elem);
            }
            
            foreach (var elem in Controls.Find("Loaded_Books_All", true))
            {
                Controls.Remove(elem);
            }
        }

        private void LoadBookFileIn(BookFile book)
        {
            ClearAll();
            

            //adding info to form
            Book_Format.Text = book.format;
            Book_Title.Text = book.title;
            Book_FileSize.Text = book.fileSize.ToString();
            Book_FileSize_Type.Text = book.fileSizeType;
            Book_PageNumbs.Text = book.pageNumbers.ToString();
            Book_UploadDate.Text = book.uploadDate.ToString();
            Book_UDK.Text = book.udk;

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

        private void LoadBookFileIn(string filePath)
        {
            ClearAll();
            DeleteLoadedBooks();
            BookFile book = DeserializeBookFile(filePath);
            BookFile.books.Add(book);
            //adding info to form
            Book_Format.Text = book.format;
            Book_Title.Text = book.title;
            Book_FileSize.Text = book.fileSize.ToString();
            Book_FileSize_Type.Text = book.fileSizeType;
            Book_PageNumbs.Text = book.pageNumbers.ToString();
            Book_UploadDate.Text = book.uploadDate.ToString();
            Book_UDK.Text = book.udk;

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
            //change Activity
            ChangeLastActivity("Loading book");
        }

        private void ClearAll()
        {
            FinalBookFile.Text = "";

            Book_Format.Text = "";
            Book_FileSize.Text = "";
            Book_FileSize_Type.Text = "";
            Book_Title.Text = "";
            Book_PageNumbs.Text = "";
            Book_UDK.Text = "";

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
            ChangeLastActivity("Remove all Authors");
        }
        //delete last: authors
        private void myButton19_Click(object sender, EventArgs e)
        {
            BookFile.authors.Remove(BookFile.authors.Last());
            UpdateFinalBookInfo();
            ChangeLastActivity("Remove last author");
        }

        private void CreateFindMenu(object sender, EventArgs e)
        {

            ChangeLastActivity("Open Find Menu");
            Find_Menu newForm = new Find_Menu();
            newForm.Show(this);

        }

        private void ChooseBook(object sender, EventArgs e)
        {

            //find name of send 
            ListView temp = new ListView();
            temp = (ListView) sender;
            BookFile.choosedBook = temp.FocusedItem.Index;
            LoadBookFileIn(BookFile.books[temp.FocusedItem.Index]);
        }

        
        public static void ApplyFind(bool[] indexes, Form form)
        {
            

            var boxControl = form.Controls.Find("Loaded_Books_All", true);
            var box = (ListView)boxControl[0];

            for (var i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] == false)
                {
                    box.Items[i].BackColor = Color.IndianRed;
                    continue;
                }
                
                box.Items[i].BackColor = Color.Green;

            }

        }

        private void UpdateBooks()
        {
            var books = Controls.Find("Loaded_Books_All", true);
            ListView box = (ListView)books[0];
            box.Clear();

            foreach (var elem in BookFile.books)
            {
                box.Items.Add($"{elem.title}");
            }

        }

        private void SortingByName(object sender, EventArgs e)
        {
            try
            {
                var list = from elem in BookFile.books
                    orderby elem.title
                    select elem;

                List<BookFile> booksList = new List<BookFile>();
                foreach (var elem in list)
                {
                    booksList.Add(elem);
                }

                BookFile.books.Clear();
                foreach (var elem in booksList)
                {

                    BookFile.books.Add(elem);
                }

                UpdateBooks();
                ChangeLastActivity("Sorting Books By Name");
            }
            catch
            {
            }
        }

        private void SortingByYear(object sender, EventArgs e)
        {
            try
            {
                var list = from elem in BookFile.books
                    orderby int.Parse(elem.uploadDate[^7..^3])
                    select elem;


                List<BookFile> booksList = new List<BookFile>();
                foreach (var elem in list)
                {
                    booksList.Add(elem);
                }

                BookFile.books.Clear();
                foreach (var elem in booksList)
                {
                    BookFile.books.Add(elem);
                }

                UpdateBooks();
                ChangeLastActivity("Sorting Books By Year");
            }
            catch
            {
            }
        }

        private void OpenAbout(object sender, EventArgs e)
        {
            About newForm = new About();
            newForm.Show(this);
            ChangeLastActivity("Open Find Menu");
        }

        private void ChangeLastActivity(string activity)
        {
            StateLineSt.LastActivity = activity;
            UpdateState();
        }

        private void CloseMenu(object sender, EventArgs e)
        {
            tool_menu.Visible = false;
            but_open_menu.Visible = true;
        }

        private void OpenMenu(object sender, EventArgs e)
        {
            tool_menu.Visible = true;
            but_open_menu.Visible = false;

        }

        private void UpdateState()
        {
            StateLine.Text = "";
            StateLineSt.ObjectCount = BookFile.books.Count;
            StateLine.Text += $"Objects counter: {StateLineSt.ObjectCount.ToString()}\n";
            StateLine.Text += $"Last activity: {StateLineSt.LastActivity}\n";
            StateLine.Text += $"Current date: {StateLineSt.CurrentDate}\n";
        }

        private void ClearAll(object sender, EventArgs e)
        {
            ChangeLastActivity("Clear all info");

            ClearAll();
            DeleteLoadedBooks();
            UpdateState();
        }

        private void ListUpdate(object sender, EventArgs e)
        {
            ChangeLastActivity("Change info in list");
        }

        private void TextInfoUpdate(object sender, EventArgs e)
        {
            ChangeLastActivity("Change text");
        }

        private void ChangeDate(object sender, EventArgs e)
        {
            ChangeLastActivity("Change Date");
        }

        private void Next(object sender, EventArgs e)
        {
            try
            {
                BookFile.choosedBook++;
                if (BookFile.choosedBook >= BookFile.books.Count || BookFile.choosedBook < 0)
                {
                    BookFile.choosedBook--;
                    throw new Exception("Book Doesn't Exist");
                }
                
                BookFile book = BookFile.books[BookFile.choosedBook];
                LoadBookFileIn(book);
                ChangeLastActivity("Read Next Book");
            }
            catch(Exception ex)
            {
                CauseException(ex);
            }
        }

        private void Previous(object sender, EventArgs e)
        {
            try
            {
                BookFile.choosedBook--;
                if (BookFile.choosedBook>=BookFile.books.Count || BookFile.choosedBook<0)
                {
                    BookFile.choosedBook++;
                    throw new Exception("Book Doesn't Exist");
                }
                
                BookFile book = BookFile.books[BookFile.choosedBook];
                LoadBookFileIn(book);
                ChangeLastActivity("Read Previous Book");
            }
            catch (Exception ex)
            {
                CauseException(ex);
            }
        }
    }
}