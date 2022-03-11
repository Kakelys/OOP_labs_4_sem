using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{


    abstract class Builder
    {
        public BookFile Book { get; set; }

        public abstract void BuildBook();
        public abstract void BuildInfo();
        public abstract void BuildPublisher();
        public abstract void BuildAuthor();
    }

    class Director
    {
        public BookFile Construct(Builder builder)
        {
            builder.BuildBook();
            builder.BuildInfo();
            builder.BuildPublisher();
            builder.BuildAuthor();
            return builder.Book;
        }


        public static void DMain(Form1 form)
        {
            Director.form = form;
            Director dir = new Director();
            Builder build = new Build();
            dir.Construct(build);
            Display(build);
        }

        private static Form1 form;
        private static void Display(Builder build)
        {
            string message = $"============================================\n\n;";
            message += $"BookInfo:\n; ";
            message += $"Title: {build.Book.title}\n";
            message += $"Pages number: {build.Book.pageNumbers}\n";
            message += $"Upload date:{build.Book.uploadDate}\n";
            message += $"book format: {build.Book.format}\n";
            message += $"File size: {build.Book.fileSize} {build.Book.fileSizeType}\n\n";
            if (build.Book._authors.Count>0)
            {
                message += $"Author:\n";
                message += $"Name: {build.Book._authors[0].fio}\n";
                message += $"Country: {build.Book._authors[0].country}\n";
                message += $"Id: {build.Book._authors[0].id}\n";
            }

            if (build.Book.publisher != null)
            {
                message += $"Publisher:\n";
                message += $"Name: {build.Book.publisher._name}\n";
                message += $"Country-City: {build.Book.publisher._country}-{build.Book.publisher._city}\n";
                message += $"Foundation Year:{build.Book.publisher.FoundationYear}\n";
                string temp = "";
                switch (build.Book.publisher.PubType)
                {
                    case 0:
                        temp = "State"; break;
                    case 1:
                        temp = "Private";break;
                }
                message += $"Type: {temp}\n";
            }

            message += $"\n=============================================";

            MessageBox.Show(message);
        }
    }

    class Build : Builder
    {
        public override void BuildBook()
        {
            Book = new BookFile();
        }

        public override void BuildAuthor()
        {
            Author author = new Author();
            Book._authors = new List<Author>();
            if (BookFile.authors.Count > 0)
            {
                author.fio = BookFile.authors[0].fio;
                author.country = BookFile.authors[0].country;
                author.id = BookFile.authors[0].id;
                Book._authors.Add(author);
            }
        }

        public override void BuildPublisher()
        {
            var pub = new Publisher();
            if (Form1.GetElement("Publisher_Name").Text!="")
                pub._name = Form1.GetElement("Publisher_Name").Text;
            if(Form1.GetElement("Publisher_Country").Text!="")
                pub._country = Form1.GetElement("Publisher_Country").Text;
            if(Form1.GetElement("Publisher_City").Text!="")
                pub._city = Form1.GetElement("Publisher_City").Text;
            if(Form1.GetElement("Publisher_FoundationYear").Text!="")
                pub.FoundationYear = int.Parse(Form1.GetElement("Publisher_FoundationYear").Text);
            if(((RadioButton)Form1.GetElement("Publisher_StateRadio")).Checked || ((RadioButton)Form1.GetElement("Publisher_PrivateRadio")).Checked)
                pub.PubType = ((RadioButton)Form1.GetElement("Publisher_StateRadio")).Checked ? 0 : 1;

            Book.publisher = pub;
        }

        public override void BuildInfo()
        {

            if (Form1.GetElement("Book_Format").Text != "")
                Book.format = Form1.GetElement("Book_Format").Text;
            if (Form1.GetElement("Book_Title").Text != "")
                Book.title = Form1.GetElement("Book_Title").Text;
            if (Form1.GetElement("Book_FileSize").Text != "")
                Book.fileSize = int.Parse(Form1.GetElement("Book_FileSize").Text);
            if (Form1.GetElement("Book_FileSize_Type").Text != "")
                Book.fileSizeType = Form1.GetElement("Book_FileSize_Type").Text;
            if (Form1.GetElement("Book_PageNumbs").Text != "")
                Book.pageNumbers = int.Parse(Form1.GetElement("Book_PageNumbs").Text);
            if (Form1.GetElement("Book_UploadDate").Text != "")
                Book.uploadDate = Form1.GetElement("Book_UploadDate").Text ?? "";
        }
    }


}
