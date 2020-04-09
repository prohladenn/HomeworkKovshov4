using System;

namespace HomeworkKovshov4
{
    /// <summary>
    /// Класс-контроллер для выполнения стандартных операций с БД
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Объект-зависимость для класса контроллера
        /// </summary>
        private readonly IDataBase _db;

        /// <summary>
        /// Конструктор класса Controller
        /// </summary>
        /// <param name="db">Объект конкретной субд</param>
        public Controller(IDataBase db)
        {
            _db = db;
        }

        /// <summary>
        /// Метод, возвращающий объект-реализацию конкретной субд для данного приложения
        /// </summary>
        /// <returns>Конкретная субд</returns>
        public IDataBase getDataBase()
        {
            return _db;
        }
    }
}