using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{

    
    [DataContract]
    internal class Author
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

    }
}
