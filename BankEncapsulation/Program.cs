namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var grantsAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            grantsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is ${grantsAccount.GetBalance()}");
        }
    }
}
