using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15_1_Vegetable_Shop.Vegetable
{
    public class Cucumber : Product
    {
        private decimal count;

        public override decimal Price => GetBasePrice() * count;

        public Cucumber(decimal basePrice, decimal count) : base(basePrice)
        {
            Name = "Огурец";
            this.count = count;
        }

        public override string ToString()
        {
            return $"{Name} ({count} кг): {Price:C}";
        }
    }
}
