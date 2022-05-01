using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lab10.Model
{
    internal static class CRUD
    {

        public static (List<Post> posts, List<User> users) Load()
        {
            var db = new DBManage();
            try
            {
                var reader = db.ReaderExecute("call GetUsers()");
                var data = new object[reader.FieldCount];
                var userList = new List<User>();
                var postList = new List<Post>();

                
                while (reader.Read())
                {
                    reader.GetValues(data);
                    userList.Add(new User((int) data[0], (string) data[1], (byte[]?) data[2]));
                }

                reader.Close();

                reader = db.ReaderExecute("call GetPosts()");
                while (reader.Read())
                {
                    reader.GetValues(data);
                    postList.Add(new Post((int) data[0], (int) data[1], (string) data[2]));
                }

                reader.Close();

                return (postList, userList);
            }
            catch
            {
            }
            finally
            {
                db.CloseConnection();
            }
            return (null, null);
        }

        public static void AddUser(string name, byte[] img)
        {
            var db = new DBManage();
            try
            {
                var command = new MySqlCommand($"insert into User(name,img) values ('{name}',@bytes)");
                command.Parameters.AddWithValue("@bytes", img);
                db.NonQueryExecute(command);
            }
            catch
            {

            }
            finally
            {
                db.CloseConnection();
            }
        }

        public static void AddPost(int userId, string message)
        {
            var db = new DBManage();
            try
            {
                db.NonQueryExecute($"call AddPost({userId},'{message}')");
            }
            catch
            {

            }
            finally
            {
                db.CloseConnection();
            }
        }

        public static void DeletePost(int id)
        {
            var db = new DBManage();
            try
            {
                db.NonQueryExecute($"delete from Post where id = {id};");
            }
            catch
            {
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public static void DeleteUser(int id)
        {
            var db = new DBManage();
            try
            {
                db.NonQueryExecute($"delete From User where id = {id};");
            }
            catch
            {
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public static void ChangeMessage(int postId, string newMessage)
        {
            var db = new DBManage();
            try
            {
                db.NonQueryExecute($"update Post set message = '{newMessage}' where id = {postId};");
            }
            catch
            {
            }
            finally
            {
                db.CloseConnection();
            }

        }

        public static void CreateDB()
        {
            var db = new DBManage();

            try
            {
                db.NonQueryExecute(
                    "create table User" +
                    "(id int primary key auto_increment, " +
                    "name nvarchar(30) not null, " +
                    "img blob); " +
                    "create table Post" +
                    "(id int primary key auto_increment," +
                    "id int," +
                    "message nvarchar(3000)," +
                    "foreign key(`id`) references User(`id`) on delete cascade );");


            }
            catch (Exception e)
            {


            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
