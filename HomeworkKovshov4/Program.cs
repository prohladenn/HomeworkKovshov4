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
                        controller.getDataBase().CreateTable();
                        break;
                    case "2":
                        controller.getDataBase().DropTable();
                        break;
                    case "3":
                        controller.getDataBase().AlterTable();
                        break;
                    case "4":
                        controller.getDataBase().Insert();
                        break;
                    case "5":
                        controller.getDataBase().Update();
                        break;
                    case "6":
                        controller.getDataBase().SelectUsers();
                        break;
                    case "7":
                        controller.getDataBase().SelectUserSubscribes();
                        break;
                    case "8":
                        controller.getDataBase().SelectUserFriends();
                        break;
                    case "9":
                        controller.getDataBase().SelectGroups();
                        break;
                    case "10":
                        controller.getDataBase().SelectGroupsSubscribers();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}