using System;
using System.Collections.Generic;

namespace _2_scaffolding_database_and_linq_query.Data.EfCore
{
    public partial class InventoryTransactionType
    {
        public InventoryTransactionType()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        public sbyte Id { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}
