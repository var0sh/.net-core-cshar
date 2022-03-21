﻿using System;
using System.Collections.Generic;

namespace _2_scaffolding_database_and_linq_query.Data.EfCore
{
    public partial class InventoryTransaction
    {
        public InventoryTransaction()
        {
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }

        public int Id { get; set; }
        public sbyte TransactionType { get; set; }
        public DateTime? TransactionCreatedDate { get; set; }
        public DateTime? TransactionModifiedDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int? PurchaseOrderId { get; set; }
        public int? CustomerOrderId { get; set; }
        public string? Comments { get; set; }

        public virtual Order? CustomerOrder { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual PurchaseOrder? PurchaseOrder { get; set; }
        public virtual InventoryTransactionType TransactionTypeNavigation { get; set; } = null!;
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
