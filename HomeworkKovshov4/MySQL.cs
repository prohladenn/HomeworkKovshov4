using System;
using System.Collections.Generic;

namespace HomeworkKovshov4
{
    /// <summary>
    /// Класс для реализации запросов к MySQL субд
    /// </summary>
    public class MySql : IDataBase
    {
        private const string Db = "MySQL";

        public void CreateTable()
        {
            Console.WriteLine("createTable " + Db);
        }

        public void DropTable()
        {
            Console.WriteLine("dropTable " + Db);
        }

        public void AlterTable()
        {
            Console.WriteLine("alterTable " + Db);
        }

        public void Insert()
        {
            Console.WriteLine("insert " + Db);
        }

        public void Update()
        {
            Console.WriteLine("update " + Db);
        }

        public List<string> SelectUsers()
        {
            Console.WriteLine("selectUsers " + Db);
            return new List<string>();
        }

        public List<string> SelectUserSubscribes()
        {
            Console.WriteLine("selectUserSubscribes " + Db);
            return new List<string>();
        }

        public List<string> SelectUserFriends()
        {
            Console.WriteLine("selectUserName " + Db);
            return new List<string>();
        }

        public List<string> SelectGroups()
        {
            Console.WriteLine("selectGroups " + Db);
            return new List<string>();
        }

        public List<string> SelectGroupsSubscribers()
        {
            Console.WriteLine("selectGroupsSubscribers " + Db);
            return new List<string>();
        }
    }
}