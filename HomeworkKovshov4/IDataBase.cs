using System.Collections.Generic;

namespace HomeworkKovshov4
{
    /// <summary>
    /// Интерфейс описывающий методы для доступа к базе данных
    /// </summary>
    public interface IDataBase
    {
        /// <summary>
        /// Метод создания таблицы
        /// </summary>
        void CreateTable();

        /// <summary>
        /// Метод удаления таблицы
        /// </summary>
        void DropTable();

        /// <summary>
        /// Метод изменения таблицы
        /// </summary>
        void AlterTable();

        /// <summary>
        /// Метод вставки в таблицу
        /// </summary>
        void Insert();

        /// <summary>
        /// Метод обновления таблицы
        /// </summary>
        void Update();

        /// <summary>
        /// Запрос на вывод пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        List<string> SelectUsers();

        /// <summary>
        /// Запрос на вывод подписок пользователя
        /// </summary>
        /// <returns>Список подписок</returns>
        List<string> SelectUserSubscribes();

        /// <summary>
        /// Запрос на вывод друзей пользователя
        /// </summary>
        /// <returns>Список друзей пользователя</returns>
        List<string> SelectUserFriends();

        /// <summary>
        /// Запрос на вывод групп
        /// </summary>
        /// <returns>Список групп</returns>
        List<string> SelectGroups();

        /// <summary>
        /// Запрос на вывод подписчиков группы
        /// </summary>
        /// <returns>Список подписчиков группы</returns>
        List<string> SelectGroupsSubscribers();
    }
}