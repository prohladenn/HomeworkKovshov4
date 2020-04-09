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
        void createTable();

        /// <summary>
        /// Метод удаления таблицы
        /// </summary>
        void dropTable();

        /// <summary>
        /// Метод изменения таблицы
        /// </summary>
        void alterTable();

        /// <summary>
        /// Метод вставки в таблицу
        /// </summary>
        void insert();

        /// <summary>
        /// Метод обновления таблицы
        /// </summary>
        void update();

        /// <summary>
        /// Запрос на вывод пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        List<string> selectUsers();

        /// <summary>
        /// Запрос на вывод подписок пользователя
        /// </summary>
        /// <returns>Список подписок</returns>
        List<string> selectUserSubscribes();

        /// <summary>
        /// Запрос на вывод друзей пользователя
        /// </summary>
        /// <returns>Список друзей пользователя</returns>
        List<string> selectUserFriends();

        /// <summary>
        /// Запрос на вывод групп
        /// </summary>
        /// <returns>Список групп</returns>
        List<string> selectGroups();

        /// <summary>
        /// Запрос на вывод подписчиков группы
        /// </summary>
        /// <returns>Список подписчиков группы</returns>
        List<string> selectGroupsSubscribers();
    }
}