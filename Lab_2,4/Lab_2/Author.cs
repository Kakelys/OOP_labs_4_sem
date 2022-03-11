using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    abstract class AuthorSay
    {
        public virtual void Say()
        {
            Console.WriteLine("Nope");
        }
    }

    abstract class Decorator : AuthorSay
    {
        private Author author;

        public void SetAuthor(Author author)
        {
            this.author = author;
        }
    }


    [Serializable]
    [DataContract]
    internal class Author : Decorator
    {
        [DataMember]
        public string fio { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public int id { get; set; }


        public Author(string fio, string country, int id)
        {
            this.fio = fio;
            this.country = country;
            this.id = id;
        }

        public Author()
        {
        }

    }
}
