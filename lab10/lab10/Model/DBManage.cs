using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace lab10.Model
{
    internal class DBManage
    {
        private static IConfiguration Configuration;
        private static readonly MySqlConnection _connection;

        private MySqlConnection Connection => _connection;
        private MySqlCommand _command;
        private MySqlTransaction _transaction;

        static DBManage()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            _connection = new MySqlConnection(Configuration.GetConnectionString("DefaultConnection"));
        }

        ~DBManage()
        {
            this.CloseConnection();
        }

        private void OpenConnection()
        {
            if(_connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();
        }

        public void CloseConnection()
        {
            if(_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }

        private bool CheckConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                return false;
            }

            return true;
        }

        public int NonQueryExecute(MySqlCommand command)
        {

            int rows = 0;
            try
            {
                OpenConnection();
                if (!CheckConnection())
                {
                    throw new Exception("Не удалось установить соединение с сервером");
                }
                _transaction = Connection.BeginTransaction();


                _command = command;
                _command.Transaction = _transaction;

                _command.Connection = Connection;
                rows = _command.ExecuteNonQuery();

                _transaction.Commit();
            }
            catch (Exception ex)
            {
                _transaction.Rollback();
            }
            finally
            {
                CloseConnection();
            }

            return rows;
        }

        public int NonQueryExecute(string command)
        {
            
            int rows = 0;
            try
            {
                OpenConnection();
                if (!CheckConnection())
                {
                    throw new Exception("Не удалось установить соединение с сервером");
                }

                _transaction = Connection.BeginTransaction();

                _command = new MySqlCommand(command, Connection);
                _command.Transaction = _transaction;
                rows = _command.ExecuteNonQuery();

                _transaction.Commit();
            }
            catch(Exception ex)
            {
                _transaction.Rollback();
            }
            finally
            {
                CloseConnection();
            }

            return rows;
        }

        public MySqlDataReader ReaderExecute(string command)
        {
            
            MySqlDataReader reader = null;
            try
            {
                OpenConnection();
                if (!CheckConnection())
                {
                    throw new Exception("Не удалось установить соединение с сервером");
                }

                _command = new MySqlCommand(command, Connection);
                reader = _command.ExecuteReader();
            }
            catch(Exception ex)
            {
                
            }
            //no need close connection, it must be open for reading

            return reader;
        }
    }
}
