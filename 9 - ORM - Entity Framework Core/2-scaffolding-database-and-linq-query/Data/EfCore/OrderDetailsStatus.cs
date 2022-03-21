using System;
using System.Collections.Generic;

namespace _2_scaffolding_database_and_linq_query.Data.EfCore
{
    public partial class OrderDetailsStatus
    {
        public OrderDetailsStatus()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
