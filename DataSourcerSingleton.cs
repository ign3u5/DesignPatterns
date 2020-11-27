using System;

namespace SingletonPrototype
{
    public class DataSourcerSingleton
    {
        private static DataSourcerSingleton _instance;
        private readonly string _connectionString;

        private DataSourcerSingleton(string connectionString)
        {
            _connectionString = connectionString;
            DatabaseConnection();
        }

        public static DataSourcerSingleton GetInstance(string connectionString)
        {
            return _instance ??= new DataSourcerSingleton(connectionString);
        }

        public string ReadImpossibleFile()
        {
            return "File contents";
        }

        public void DatabaseConnection()
        {
            if (_connectionString == "bean")
                throw new Exception("Dead");
        }
    }
}
