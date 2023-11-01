namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestAccount();
            TestTime();
        }
        static void TestAccount()
        {
            //Create Account instance
            Account account = new();

            Console.WriteLine(account);
            account.Deposit(1000);
            Console.WriteLine(account);
            account.AnualInterestRate = 0.05m;
            Console.WriteLine(account);
        }
        static void TestTime()
        {
            Console.WriteLine("Test time:");
            Time time = new();
            Console.WriteLine(time);

            Console.WriteLine("Current time: ");
            time.Hour = DateTime.Now.Hour;
            time.Minute = DateTime.Now.Minute;  
            time.Second = DateTime.Now.Second;
            Console.WriteLine(time);
        }
    }
}