using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15_1_Vegetable_Shop.Vegetable
{
    public class Potato : Product
    {
        private decimal count;
        public override decimal Price => GetBasePrice() * count;

        public Potato(decimal basePrice, decimal count) : base(basePrice)
        {
            Name = "Картошка";
            this.count = count;
        }
        public override string ToString()
        {
            return $"{Name} ({count} кг): {Price:C}";
        }
    }
}
