using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uygulama_interface_repository_pattern_1.Entity
{
    public class Product: IEntity {
        public int Id { get; set;}
        public string Name { get; set; }
        public double Price { get; set; }
    }
}