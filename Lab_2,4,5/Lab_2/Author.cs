using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{

    [Serializable]
    [DataContract]
    abstract class AuthorSay
    {
        public virtual void Say()
        {
            Console.WriteLine("Nope");
        }
    }

    [Serializable]
    [DataContract]
    abstract class Decorator : AuthorSay
    {
        public void DoSomething(Author author)
        {
            MessageBox.Show(author.fio);
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
