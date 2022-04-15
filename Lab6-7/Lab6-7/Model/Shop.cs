using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab6_7.Model
{
    [Serializable]
    [DataContract]
    internal class Shop
    {
        [DataMember] public List<Product> Products{get;set;}

        public Shop()
        {
            Products = GetProducts();
            if (Products == null)
                Products = new List<Product>();
        }

        private List<Product> GetProducts()
        {
            try
            {
                Shop temp;
                if (!File.Exists("Shop.json")) return null;
                using (FileStream fs = new FileStream("Shop.json", FileMode.OpenOrCreate))
                {
                    var ser = new DataContractJsonSerializer(typeof(Shop));
                    temp = (Shop) ser.ReadObject(fs);
                }
                return temp.Products;
            }
            catch
            {
                return null;
            }
        }

        private void SaveProducts()
        {
            var path = "Shop.json";
            if(File.Exists(path))File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.CreateNew))
            {
                var ser = new DataContractJsonSerializer(typeof(Shop));
                ser.WriteObject(fs,this);
            }
        }

        public static void Add(Product product)
        {
            var temp = new Shop();
            temp.Products.Add(product);
            temp.SaveProducts();
        }

        public static void Delete(Product product)
        {
            var temp = new Shop();
            temp.Products.RemoveAt(product.Id-1);
            temp.SaveProducts();
        }

        public static void SaveEdit(Product product, int id)
        {
            var shop = new Shop();
            shop.Products[id - 1] = product;
            shop.SaveProducts();
        }
    }
}
