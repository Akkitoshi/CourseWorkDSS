using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace Model
{
    public class Priority
    {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [ForeignKey("PriorityId")]
        public virtual List<Request> Requests { get; set; }
    }
}
