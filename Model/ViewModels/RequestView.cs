using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class RequestView
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string Description { get; set; }
        public int ComplexityId { get; set; }
        public int PriorityId { get; set; }
        public int CategoryId { get; set; }
        public int ExecutorId { get; set; }
    }
}
