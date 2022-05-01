using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using lab10.Model;
using Microsoft.Toolkit.Mvvm.Input;

namespace lab10.ViewModel
{
    internal class AddPostView : ViewModelBase
    {
        public string Message { get; set; }

        public void Add()
        {
            CRUD.AddPost(ElementList.CurId,Message);
            ElementList.Update();
        }

        public RelayCommand AddPost => new RelayCommand(Add);
    }
}
