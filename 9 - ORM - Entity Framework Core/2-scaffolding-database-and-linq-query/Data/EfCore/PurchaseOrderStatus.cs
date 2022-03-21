using System;
using System.Collections.Generic;

namespace _2_scaffolding_database_and_linq_query.Data.EfCore
{
    public partial class PurchaseOrderStatus
    {
        public PurchaseOrderStatus()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int Id { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
