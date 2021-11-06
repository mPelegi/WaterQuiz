using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using WaterQuiz.Utils;

namespace WaterQuiz.Model.DAO
{
    public class ConexaoDAO
    {
        private SQLiteConnection connection;
        private static readonly string connString = string.Format(@"DataSource={0}", new DatabaseUtil().GetDatabasePath());
        private bool isOpen = false;

        public ConexaoDAO()
        {
            try
            {
                connection = new SQLiteConnection(connString);
            }  
            catch (Exception)
            {
                throw;
            }
        }

        public void Abrir()
        {
            if (!isOpen)
            {
                connection.Open();
                isOpen = true;
            }
        }

        public void Fechar()
        {
            if (isOpen)
            {
                connection.Close();
                isOpen = false;
            }
        }

        public bool IsOpen()
        {
            return isOpen;
        }

        public SQLiteConnection Get()
        {
            try
            {
                return connection;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
