﻿using System;
using System.Collections.Generic;

namespace _2_scaffolding_database_and_linq_query.Data.EfCore
{
    public partial class SalesReport
    {
        public string GroupBy { get; set; } = null!;
        public string? Display { get; set; }
        public string? Title { get; set; }
        public string? FilterRowSource { get; set; }
        public bool Default { get; set; }
    }
}
