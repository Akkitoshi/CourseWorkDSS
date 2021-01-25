using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class ExecutorView
    {
        public int Id { get; set; }

        public string FIO { get; set; }

        public int Experience { get; set; }

        public string CodingLevel { get; set; }

        public bool isBusy { get; set; }

        public int CategoryId { get; set; }
    }
}
