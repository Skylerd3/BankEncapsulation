namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            var CurrentBalance = account.GetBalance();

            Console.WriteLine(CurrentBalance);

            account.Deposit(555);

            CurrentBalance = account.GetBalance();

            Console.WriteLine(CurrentBalance);
        }
    }
}
