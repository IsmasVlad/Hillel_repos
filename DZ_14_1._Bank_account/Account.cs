using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_1_Bank_account
{
    public class Account // Класс Account, представляющий банковский счет
    {
        public string Name { get; set; } // Название счета


        private decimal balance; // Состояние счета

        public Account(string name, decimal initialBalance) // Конструктор для инициализации счета
        {
            if (initialBalance < 0)
                throw new ArgumentOutOfRangeException("Начальная сумма не может быть меньше 0.");

            Name = name;
            this.balance = balance;
        }
        public void AddMoney(decimal summ) // Метод для добавления денег на счет
        {
            if ( summ <= 0)
                throw new ArgumentOutOfRangeException("Сумма добавления должна быть больше 0");

                balance += summ;
                Console.WriteLine($"На счет {Name} добавлено {summ:C}. Текущий баланс: {balance:C}.");
        }

        public void Withdraw(decimal summ) // Метод для снятия денег с счета
        {
            if (summ <= 0)
                throw new ArgumentOutOfRangeException("Сумма снятия должна быть больше 0.");
            balance -= summ;
            Console.WriteLine($"Со счета {Name} снято {summ:C}. Текущий баланс: {balance:C}.");
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
