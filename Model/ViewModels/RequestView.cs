using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class RequestView
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        [DisplayName("Тема")]
        public string Theme { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Сложность")]
        public int ComplexityId { get; set; }
        [DisplayName("Приоритет")]
        public int PriorityId { get; set; }
        [DisplayName("Категория")]
        public int CategoryId { get; set; }
        [DisplayName("Исполнитель")]
        public int ExecutorId { get; set; }
    }
}
