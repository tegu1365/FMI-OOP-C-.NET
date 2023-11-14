namespace Lab3aProblem3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 50, y = 4;
            int gcd, lcm;
            if(CommonDivisior(x, y,out gcd, out lcm))
            {
                Console.WriteLine($"GCD({x},{y})={gcd}; LCM({x},{y})={lcm}");
            }
            else
            {
                Console.WriteLine($"No common divisior other then 1.");
            }
            
        }

        static bool CommonDivisior(int x, int y, out int greatest, out int least)
        {
            int num1 = x;
            int num2 = y;
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            greatest = num1;
            least = (x * y) / greatest;
            return greatest > 1;
        }
    }
}