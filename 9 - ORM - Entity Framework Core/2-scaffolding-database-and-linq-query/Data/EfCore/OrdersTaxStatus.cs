using System;
using System.Collections.Generic;

namespace _2_scaffolding_database_and_linq_query.Data.EfCore
{
    public partial class OrdersTaxStatus
    {
        public OrdersTaxStatus()
        {
            Orders = new HashSet<Order>();
        }

        public sbyte Id { get; set; }
        public string TaxStatusName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
