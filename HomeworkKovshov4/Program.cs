using System;

namespace HomeworkKovshov4
{
    /// <summary>
    /// Класс для демонстрации обращения приложения к базе данных
    /// </summary>
    /// <remarks>
    /// На вход программе подаётся название СУБД и список действий,
    /// программа выводит на консоль сообщения о вызове методов
    /// соответствующего класса. 
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название базы данных (Oracle, MySQL, PostgreSQL)");
            var controller = Console.ReadLine()?.ToLower() switch
            {
                "oracle" => new Controller(new Oracle()),
                "postgresql" => new Controller(new PostgreSql()),
                _ => new Controller(new MySql())
            };

            Console.WriteLine("Вводите команды:\n" +
                              "0 - выход \n" +
                              "1 - createTable \n" +
                              "2 - dropTable \n" +
                              "3 - alterTable \n" +
                              "4 - insert \n" +
                              "5 - update \n" +
                              "6 - selectUsers \n" +
                              "7 - selectUserSubscribes \n" +
                              "8 - selectUserName \n" +
                              "9 - selectGroups \n" +
                              "10 - selectGroupsSubscribers");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        controller.GetDataBase().CreateTable();
                        break;
                    case "2":
                        controller.GetDataBase().DropTable();
                        break;
                    case "3":
                        controller.GetDataBase().AlterTable();
                        break;
                    case "4":
                        controller.GetDataBase().Insert();
                        break;
                    case "5":
                        controller.GetDataBase().Update();
                        break;
                    case "6":
                        controller.GetDataBase().SelectUsers();
                        break;
                    case "7":
                        controller.GetDataBase().SelectUserSubscribes();
                        break;
                    case "8":
                        controller.GetDataBase().SelectUserFriends();
                        break;
                    case "9":
                        controller.GetDataBase().SelectGroups();
                        break;
                    case "10":
                        controller.GetDataBase().SelectGroupsSubscribers();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}