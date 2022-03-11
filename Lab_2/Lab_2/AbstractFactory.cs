using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal abstract class AbstractFactory
    {
        public static void AFCreate()
        {
            Random rand = new();
            var value = rand.Next(1, 3);

            switch (value)
            {
                case 1:
                    Book book1 = new Book(new FamousBook());
                    book1.Author.CreateAuthor();
                    book1.BookInfo.CreateBookInfo();
                    book1.Publisher.CreatePublisher();
                    book1.DisplayInfo();
                    break;
                case 2:
                    Book book2 = new Book(new PoorBook());
                    book2.Author.CreateAuthor();
                    book2.BookInfo.CreateBookInfo();
                    book2.Publisher.CreatePublisher();
                    book2.DisplayInfo();
                    break;
            }

        }


      
    }

    public class  Book
    {
        public BookInfoAF BookInfo;
        public AuthorAF Author;
        public PublisherAF Publisher;

        public Book(BookFileF  el)
        {
            BookInfo = el.CreateBookInfo();
            Author = el.CreateAuthor();
            Publisher = el.CreatePublisher();
        }

        public void DisplayInfo()
        {
            string message = $"======================\n\n" +
                             $"BookInfo:\n" +
                             $"Title: {BookInfo.title}\n" +
                             $"Pages number: {BookInfo.pageNumbers}" +
                             $"Upload date:{BookInfo.uploadDate}\n" +
                             $"book format: {BookInfo.format}\n" +
                             $"File size: {BookInfo.fileSize} {BookInfo.fileSizeType}\n\n" +
                             $"" +
                             $"Author:\n" +
                             $"Name: {Author.fio}\n" +
                             $"Country: {Author.country}\n" +
                             $"Id: {Author.id}\n" +
                             $"" +
                             $"" +
                             $"Publisher:\n" +
                             $"Name: {Publisher.name}\n" +
                             $"Country-City: {Publisher.country}-{Publisher.city}\n" +
                             $"Foundation Year:{Publisher.foundationYear}\n" +
                             $"Type: {Publisher.type.ToString()}";


            MessageBox.Show(message);
        }

    }

    public abstract class BookFileF
    {
        public abstract AuthorAF CreateAuthor();
        public abstract PublisherAF CreatePublisher();
        public abstract BookInfoAF CreateBookInfo();
    }

    public abstract class BookInfoAF
    {
        public abstract void CreateBookInfo();

        public string format { get; set; }
        public string title { get; set; }
        public int fileSize { get; set; }
        public string fileSizeType { get; set; }
        public int pageNumbers { get; set; }
        public string uploadDate { get; set; }
    }


    public abstract class AuthorAF
    {
        public abstract void CreateAuthor();


        public string fio { get; set; }
        public string country { get; set; } 
        public int id { get; set; }
    }

    public abstract class PublisherAF
    {
        public abstract void CreatePublisher();

        public string name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public int foundationYear { get; set; }
        public Type type { get; set; }

        public enum Type
        {
            state, privat
        }
    }

    public class FamousBook : BookFileF
    {
        public override PublisherAF CreatePublisher() => new FamousPublisher();
        public override AuthorAF CreateAuthor() => new FamousAuthor();
        public override BookInfoAF CreateBookInfo() => new FamousBookInfo();
    }

    public class FamousPublisher : PublisherAF
    {
        public override void CreatePublisher()
        {
            name = "Davida de Lape";
            country = "USA";
            city = "Vellidor";
            foundationYear = 1967;
            type = Type.state;
        }
    }

    public class FamousAuthor : AuthorAF
    {
        public override void CreateAuthor()
        {
            fio = "So Le Dia";
            country = "Forit";
            id = 67;
        }
    }

    public class FamousBookInfo : BookInfoAF
    {
        public override void CreateBookInfo()
        {
            format = "A4";
            title = "Kalista";
            fileSize = 4758;
            fileSizeType = "Mb";
            pageNumbers = 3567;
            uploadDate = "30.06.2003";
        }
    }

    public class PoorBook : BookFileF
    {
        public override PublisherAF CreatePublisher() => new PoorPublisher();
        public override AuthorAF CreateAuthor() => new PoorAuthor();
        public override BookInfoAF CreateBookInfo() => new PoorBookInfo();
    }

    public class PoorPublisher : PublisherAF
    {
        public override void CreatePublisher()
        {
            name = "Jellute";
            country = "Poland";
            city = "Velica";
            foundationYear = 2009;
            type = Type.privat;
        }
    }

    public class PoorAuthor : AuthorAF
    {
        public override void CreateAuthor()
        {
            fio = "Janna";
            country = "Strogk";
            id = 84569;
        }
    }

    public class PoorBookInfo : BookInfoAF
    {
        public override void CreateBookInfo()
        {
            format = "A4";
            title = "Celeste";
            fileSize = 10;
            fileSizeType = "Mb";
            pageNumbers = 24;
            uploadDate = "30.06.2013";
        }
    }




}
