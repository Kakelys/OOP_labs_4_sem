﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;



namespace Lab_2
{
    [DataContract]
    internal class BookFile
    {
        //list of books for load several books
        public static List<BookFile> books = new List<BookFile>();

        //for loading book
        [DataMember]
        public List<Author> _authors;

        //for adding several authors for one book
        public static List<Author> authors = new();

        [DataMember] public string format { get; set; }
        [DataMember] public string title { get; set; }
        [DataMember] public int fileSize { get; set; } 
        [DataMember] public string fileSizeType { get; set; }
        [DataMember] public int pageNumbers { get; set; }
        [DataMember] public string uploadDate { get; set; }


        [DataMember]
        public Publisher publisher;

       

        public BookFile(string format, string title, int fileSize,string fileSizeType, int pageNumbers, string uploadDate, 
            Publisher publisher)
        {
            this.format = format;
            this.title = title;
            this.fileSize = fileSize;
            this.fileSizeType = fileSizeType;
            this.pageNumbers = pageNumbers;
            this.uploadDate = uploadDate;

            this.publisher = new Publisher();
            this.publisher = (Publisher)publisher.Clone();

            _authors = new List<Author>();
            foreach (var elem in authors)
            {
             _authors.Add(elem);   
            }
            
        }

        public BookFile()
        {
        }

    }
}
