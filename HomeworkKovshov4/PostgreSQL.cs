using System;
using System.Collections.Generic;

namespace HomeworkKovshov4
{
    /// <summary>
    /// Класс для реализации запросов к PostgreSQL субд
    /// </summary>
    public class PostgreSql : IDataBase
    {
        private const string Db = "PostgreSQL";

        public void createTable()
        {
            Console.WriteLine("createTable " + Db);
        }

        public void dropTable()
        {
            Console.WriteLine("dropTable " + Db);
        }

        public void alterTable()
        {
            Console.WriteLine("alterTable " + Db);
        }

        public void insert()
        {
            Console.WriteLine("insert " + Db);
        }

        public void update()
        {
            Console.WriteLine("update " + Db);
        }

        public List<string> selectUsers()
        {
            Console.WriteLine("selectUsers " + Db);
            return new List<string>();
        }

        public List<string> selectUserSubscribes()
        {
            Console.WriteLine("selectUserSubscribes " + Db);
            return new List<string>();
        }

        public List<string> selectUserFriends()
        {
            Console.WriteLine("selectUserName " + Db);
            return new List<string>();
        }

        public List<string> selectGroups()
        {
            Console.WriteLine("selectGroups " + Db);
            return new List<string>();
        }

        public List<string> selectGroupsSubscribers()
        {
            Console.WriteLine("selectGroupsSubscribers " + Db);
            return new List<string>();
        }
    }
}