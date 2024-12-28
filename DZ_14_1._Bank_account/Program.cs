namespace DZ_14_1_Bank_account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Account myAccount = new Account("Основной счет", 1000);
                Console.WriteLine($"Начальный баланс счета \"{myAccount.Name}\": {myAccount.GetBalance():C}\n");

                myAccount.AddMoney(500);

                myAccount.Withdraw(300);

                Console.WriteLine($"Текущий баланс: {myAccount.GetBalance():C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
