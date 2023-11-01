namespace Lab3aProblem2
{
    internal class Program
    {
        const double ACCURACY = 0.0000001;
        static void Main(string[] args)
        {
            double x;
            x = 1.45;
            Console.WriteLine($"Cos accurate:{x}:{Math.Cos(x)}");
            Console.WriteLine($"Cos approx:{x}:{ComputeCos(x)}");

        }

        static double ComputeCos(double x)
        {
            //declaretion of vars
            double cosResult;
            int counter;
            double term;
            //init
            counter = 0;
            term = 1.0;
            cosResult = term;
            //processing
            do
            {
                counter+=2;
                term = -term * x * x / ((counter - 1) * counter);
                cosResult+= term;
            }while ( Math.Abs(term)>ACCURACY );
            return cosResult;
        }
    }
}