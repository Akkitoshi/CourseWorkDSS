using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
