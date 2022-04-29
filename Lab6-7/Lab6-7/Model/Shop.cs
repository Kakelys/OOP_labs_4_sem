using System;
using System.CodeDom.Compiler;
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
            UndoRedo.AddToUndo("Remove",product);
        }

        public static void Delete(Product product)
        {
            var temp = new Shop();
            var i = 0;
            foreach (var elem in temp.Products)
            {

                if (
                    elem.Name==product.Name
                    && elem.Amount==product.Amount
                    && elem.Description == product.Description
                    && elem.ImagePath == product.ImagePath
                    && elem.Price == product.Price
                    && elem.Sold == product.Sold
                              )
                {
                    break;
                }

                i++;
            }

            temp.Products.RemoveAt(i);
            temp.SaveProducts();
            UndoRedo.AddToUndo("Add",product);
        }

        public static void DeleteLast()
        {
            var shop = new Shop();
            shop.Products.RemoveAt(shop.Products.Count-1);
            shop.SaveProducts();
        }

        public static void SaveEdit(Product product, int id)
        {
            var shop = new Shop();
            shop.Products[id - 1] = product;
            shop.SaveProducts();
        }
    }
}
