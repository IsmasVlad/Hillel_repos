using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15_1_Vegetable_Shop
{
    public abstract class Product
    {
        private decimal basePrice;

        public string Name { get; protected set; }

        public abstract decimal Price { get; }

        protected Product(decimal basePrice)
        {
            this.basePrice = basePrice; 
        }

        // Метод для получения базовой цены
        protected decimal GetBasePrice() => basePrice;

        public override string ToString()
        {
            return $"{Name}:{Price:C}";
        }
    }
}
