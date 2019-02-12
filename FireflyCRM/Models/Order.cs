using System;

namespace FireflyCRM.Models
{
    public class Order : BaseEntity
    {
        public Customer Customer { get; }
        
        public DateTime Created { get; set; }
    }
}