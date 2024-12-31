using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15_1_Vegetable_Shop
{
    public class VegetableShop
    {
        private List<Product> products = new List<Product>();

        // Добавление нового продукта
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Вывод всех продуктов и стоимости
        public void AllProducts()
        {
            Console.WriteLine("Овощи в магазине:");
            decimal totalPrice = 0;
            foreach (var product in products)
            {
                Console.WriteLine(product);
                totalPrice += product.Price;
            }
            Console.WriteLine($" Cтоимость всех продуктов: {totalPrice:C}");
        }
    }
}
