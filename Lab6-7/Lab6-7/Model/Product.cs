using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Lab6_7.View;

namespace Lab6_7.Model
{
    [Serializable]
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public int Sold { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public string ImagePath { get; set; }

        public Product(string name, string description, int amount, int sold, int price, string imagePath)
        {
            var temp = new Shop().Products;
            Id = temp == null && temp.Count>0? temp.Count:1;
            Name = name;
            Description = description;
            Amount = amount;
            Sold = sold;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
