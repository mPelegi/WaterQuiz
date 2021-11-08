using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WaterQuiz.Utils
{
    public class DatabaseUtil
    {
        public string GetDatabasePath()
        {
            string rootPath = Path.GetFullPath(@"..\..\..\..\");
            string databasePath = @"WaterQuiz.DAL\resources\banco.db";

            return string.Format("{0}{1}", rootPath, databasePath);
        }
    }
}
