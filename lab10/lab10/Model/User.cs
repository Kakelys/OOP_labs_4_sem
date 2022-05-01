using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[]? Img { get; set; }

        public User(int id, string name, byte[]? img)
        {
            Id = id;
            Name = name;
            Img = img;
        }

        public User(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Img = user.Img;
        }

    }
}
