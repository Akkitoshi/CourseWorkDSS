using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Model
{
    public class Complexity
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [ForeignKey("ComplexityId")]
        public virtual List<Request> Requests { get; set; }

    }
}
