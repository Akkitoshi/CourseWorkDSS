using System.Runtime.Serialization;

namespace Model
{
    public class Request
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Theme { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
        public int PriorityId { get; set; }
        [DataMember]
        public int ComplexityId { get; set; }
        [DataMember]
        public int ExecutorId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Complexity Complexity { get; set; }
        public virtual Executor Executor { get; set; }
    }
}
