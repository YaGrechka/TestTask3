namespace TestTask3.Models
{
    public interface IOperations
    {
        /// <summary>
        /// Добавление новой записи
        /// </summary>
        /// <param name="operations">Добавляемый объект</param>
        /// <returns>True - успешно добавлено. False - не добавлено</returns>
        bool Add(IOperations operations);
        /// <summary>
        /// получение списка записей
        /// </summary>
        /// <param name="ColumnNumb">Номер колонки по которой нужно сортировать. По умолчанию 1(по Id)</param>
        /// <param name="ListSize">Размер страницы при постраничном возврате данных. По умолчанию 0(вывод всех записей без страниц)</param>
        /// <param name="ListNumb">Номер возвращаемой страницы при постраничном возврате данных. По умолчанию 0(вывод всех записей без страниц)</param>
        /// <returns></returns>
        IEnumerable<IOperations> List(int ColumnNumb = 1, int ListSize = 0, int ListNumb = 0);
        /// <summary>
        /// Удаляет указанную запись
        /// </summary>
        /// <param name="operations">Удаляемый объект</param>
        /// <returns>True - успешно удалено. False - не удалено</returns>
        bool Remove(IOperations operations);
        /// <summary>
        /// Обновляет указанную запись
        /// </summary>
        /// <param name="operations">Обновляемый объект</param>
        /// <returns>True - успешно обновлено. False - не обновлено</returns>
        bool Update(IOperations operations);
    }
}
