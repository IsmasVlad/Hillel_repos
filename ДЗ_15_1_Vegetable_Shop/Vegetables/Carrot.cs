using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15_1_Vegetable_Shop.Vegetable
{
    public class Carrot : Product
    {
        public override decimal Price => GetBasePrice();

        public Carrot(decimal basePrice) : base(basePrice)
        {
            Name = "Морковь";
        }
    }
}
