using DZ_15_1_Vegetable_Shop.Vegetable;
using DZ_15_1_Vegetable_Shop.Vegetables;

namespace DZ_15_1_Vegetable_Shop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var shop = new VegetableShop();

            //Добавление продуктов

            shop.AddProduct(new Carrot(10.5m));
            shop.AddProduct(new Tomato(40.0m));
            shop.AddProduct(new Potato(25m, 3));
            shop.AddProduct(new Cucumber(10m, 2));

            shop.AllProducts();
        }
    }
}
