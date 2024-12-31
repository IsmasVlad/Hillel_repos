using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ_15_1_Vegetable_Shop.Vegetables
{
    public class Tomato : Product
    {
        public override decimal Price => GetBasePrice();
        public Tomato(decimal basePrice) : base(basePrice)
        {
            Name = "Помидор";
        }
    }
}
