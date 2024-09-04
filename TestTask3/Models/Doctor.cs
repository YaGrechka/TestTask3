namespace TestTask3.Models
{
    /// <summary>
    /// Врач
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Кабинет
        /// </summary>
        public Cabinet Cabinet { get; set; }
        /// <summary>
        /// Специализация
        /// </summary>
        public Specification Specification { get; set; }
        /// <summary>
        /// Участок
        /// </summary>
        public Region Region { get; set; }
    }
}
