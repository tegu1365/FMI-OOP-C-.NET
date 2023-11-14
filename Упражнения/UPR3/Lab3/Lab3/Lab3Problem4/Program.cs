namespace Lab3aProblem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PythagoreanTripletsBruteForce();
        }

        //O(number of pythagorean triplets)
        //No repeats
        static void PythagoreanTriplets()
        {
            int side1, side2, hypotenuse = 0;
            int m = 2;
            while (hypotenuse < 30)
            {
                for(int n=1;n<m; n++)
                {
                    side1=(int)Math.Pow(m,2)- (int)Math.Pow(n, 2);
                    side2 = 2 * n * m;
                    hypotenuse = (int)Math.Pow(m, 2) + (int)Math.Pow(n, 2);
                    if(hypotenuse >= 30)
                    {
                        break;
                    }
                    Console.WriteLine($"{side1,5}|{side2,5}|{hypotenuse,5}");
                }
                m++;
            }
        }
        //O(limit^3=30^3=90)
        //some of them will repeat there is no differance between
        //{side1,side2} with {15,20} and {20,15} the hypotenuse is 25
        static void PythagoreanTripletsBruteForce()
        {
            int side1, side2, hypotenuse = 0;
            for(side1=1; side1<30; side1++)
            {
                for (side2 = 1; side2 < 30; side2++)
                {
                    for (hypotenuse = 1; hypotenuse < 30; hypotenuse++)
                    {
                        if (side1 * side1 + side2 * side2 == hypotenuse * hypotenuse &&hypotenuse!=30)
                        {
                            Console.WriteLine($"{side1,5}|{side2,5}|{hypotenuse,5}");
                        }
                    }
                }
            }
        }
    }
}