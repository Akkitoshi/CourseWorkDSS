using System.ComponentModel;

namespace Model.ViewModels
{
    public class ComplexityView
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
    }
}
