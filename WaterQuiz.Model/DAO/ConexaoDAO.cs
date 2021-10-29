using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace WaterQuiz.Model.DAO
{
    public class ConexaoDAO
    {
        private SQLiteConnection connection;
        private static readonly string connString = @"DataSource=C:\Users\muril\Documents\Padrdoes e Paradigmas\waterQuiz\WaterQuiz.DAL\resources\banco.db";
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
