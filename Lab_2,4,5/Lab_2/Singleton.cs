using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Singleton
    {
        private static Singleton _instance;
        public int width;
        public int height;
        public Color bgColor;


        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return _instance ??= new Singleton();
        }
    }
}
