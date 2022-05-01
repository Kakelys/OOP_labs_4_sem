using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Mvvm;
using lab10.Model;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Win32;

namespace lab10.ViewModel
{
    internal class AddingUserMenuView : ViewModelBase
    {
        public string Name { get; set; }
        private byte[]? img;

        public void Add()
        {
            if (img == null)
            {
                MessageBox.Show("NOPE");
                return;
            }

            CRUD.AddUser(Name,img);
            ElementList.Update();
        }

        public void OpenImage()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() != true)
            {
                MessageBox.Show("NOPE");
                return;
            }
            var path = openFileDialog1.FileName;
            using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            using var br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
        }

        public RelayCommand AddUser => new RelayCommand(Add);
        public RelayCommand LoadImage => new RelayCommand(OpenImage);
    }
}
