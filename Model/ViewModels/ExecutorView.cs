using System.ComponentModel;

namespace Model.ViewModels
{
    public class ExecutorView
    {
        [DisplayName("Идентификаторм")]
        public int Id { get; set; }
        [DisplayName("ФИО")]

        public string FIO { get; set; }
        [DisplayName("Опыт работы (лет)")]
        public int Experience { get; set; }
        [DisplayName("Уровень программирования")]

        public string CodingLevel { get; set; }
        [DisplayName("Занятость задачей")]

        public bool isBusy { get; set; }
        [DisplayName("Категория")]

        public string CategoryName { get; set; }

    }
}
