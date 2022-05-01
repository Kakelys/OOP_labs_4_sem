using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevExpress.Internal;
using DevExpress.Mvvm;
using Google.Protobuf.WellKnownTypes;
using lab10.Model;
using lab10.View;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Win32;

namespace lab10.ViewModel
{
    internal class ElementList : ViewModelBase
    {
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Post> Posts { get; set; }

        private int _index = 0;
        public static int CurId { get; private set; }

        public string UserName { get; set; }
        public ObservableCollection<Post> CurPosts { get; set; }
        public ImageSource Img { get; set; }

        public Visibility AddButtonVisibility { get; set; } = Visibility.Collapsed;
        public Visibility UserVisibility { get; set; } = Visibility.Collapsed;

        private static ElementList View;

        public ElementList()
        {
            View = this;
        }

        public void Load()
        {
            var list = CRUD.Load();
            if (list.users == null)
            {
                UserVisibility = Visibility.Collapsed;
                return;
            }

            Users = new ObservableCollection<User>(list.users.Select(x => new User(x)));
            AddButtonVisibility = Visibility.Visible;
            UserVisibility = Visibility.Visible;

            try
            {
                Posts = new ObservableCollection<Post>(list.posts.Select(x => new Post(x)));
            }
            catch
            {
            }

            Next();
        }

        public static void Update()
        {
            var list = CRUD.Load();
            if (list.users == null)
            {
                View.UserVisibility = Visibility.Collapsed;
                return;
            }

            View.Users = new ObservableCollection<User>(list.users.Select(x => new User(x)));
            View.AddButtonVisibility = Visibility.Visible;
            View.UserVisibility = Visibility.Visible;

            try
            {
                View.Posts = new ObservableCollection<Post>(list.posts.Select(x => new Post(x)));
            }
            catch
            {
            }

            if (View._index > View.Users.Count)
                View._index = 1;
            if (View._index > View.Users.Count)
                return;

            var user = View.Users.Skip(View._index - 1).First();
            CurId = user.Id;
            View.UserName = user.Name;
            View.Img = LoadImage(user.Img);
            if (View.Posts != null && View.Posts.Any())
                View.CurPosts = new ObservableCollection<Post>(View.Posts.Where(x => x.UserId == CurId));
        }

        public void Next()
        {
            if (Users == null) return;
            _index++;
            if (_index > Users.Count)
                _index = 1;
            if (_index > Users.Count)
                return;

            var user = Users.Skip(_index - 1).First();
            CurId = user.Id;
            UserName = user.Name;
            Img = LoadImage(user.Img);
            if (Posts != null && Posts.Any())
                CurPosts = new ObservableCollection<Post>(Posts.Where(x => x.UserId == CurId));
        }

        public void Previous()
        {
            if (Users == null) return;
            _index--;
            if (_index <= 0)
                _index = Users.Count;
            if (_index <= 0) return;

            var user = Users.Skip(_index - 1).First();
            CurId = user.Id;
            UserName = user.Name;
            Img = LoadImage(user.Img);
            if (Posts != null && Posts.Any())
                CurPosts = new ObservableCollection<Post>(Posts.Where(x => x.UserId == CurId));
        }

        private static ImageSource LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }

            image.Freeze();
            return image;
        }



        public void OpenAddingUserMenu()
        {
            var form = new AddUserMenu();
            form.Show();
        }

        public void OpenAddingPostMenu()
        {
            var form = new AddPost();
            form.Show();
        }

        public void DeleteUserFromDb()
        {
            CRUD.DeleteUser(CurId);
            Update();
        }

        public RelayCommand  LoadInfo => new RelayCommand(Load);
        public RelayCommand NextUser => new RelayCommand(Next);
        public RelayCommand PrevUser => new RelayCommand(Previous);
        public RelayCommand AddUser => new RelayCommand(OpenAddingUserMenu);
        public RelayCommand AddPost => new RelayCommand(OpenAddingPostMenu);
        public RelayCommand DeleteUser => new RelayCommand(DeleteUserFromDb);
    }
}
