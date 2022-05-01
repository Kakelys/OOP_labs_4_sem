using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using lab10.ViewModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace lab10.Model
{
    internal class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }

        public Post(int id, int userId, string message)
        {
            Id = id;
            UserId = userId;
            Message = message;
        }

        public Post(Post post)
        {
            Id = post.Id;
            UserId = post.UserId;
            Message = post.Message;
        }

        public void DeleteFromDb()
        {
            CRUD.DeletePost(Id);
            ElementList.Update();
        }

        public RelayCommand DeletePost => new RelayCommand(DeleteFromDb);

    }
}
