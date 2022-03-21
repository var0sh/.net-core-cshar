using System;
using System.Collections.Generic;

namespace _2_scaffolding_database_and_linq_query.Data.EfCore
{
    public partial class OrdersStatus
    {
        public OrdersStatus()
        {
            Orders = new HashSet<Order>();
        }

        public sbyte Id { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
