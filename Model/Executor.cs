using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Model
{
    public class Executor
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public int Experience { get; set; }
        [DataMember]
        public string CodingLevel { get; set; }
        [DataMember]
        public bool isBusy { get; set; }
        [DataMember]
        public string CategoryName { get; set; }

        [ForeignKey("ExecutorId")]
        public virtual List<Request> Requests { get; set; }
    }
}
