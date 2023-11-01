internal class Program
{
    public static int encrypt(int number)
    {
        int[] digits = new int[4];//splited digits from the number
        int outputNumber = 0; //encrypted number

        //spliting digits
        digits[0] = number / 1000;
        digits[1] = (number % 1000) / 100;
        digits[2] = (number % 100) / 10;
        digits[3] = number % 10;


        //adding 7 and mod 10
        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = (digits[i] + 7) % 10;
        }

        //adding digits to num
        outputNumber = digits[2] * 1000 + digits[3] * 100 + digits[0] * 10 + digits[1];
        return outputNumber;
    }

    public static int decrypt(int number)
    {
        int[] digits = new int[4];//splited digits from the number
        int outputNumber = 0; //encrypted number

        //spliting digits
        digits[0] = number / 1000;
        digits[1] = (number % 1000) / 100;
        digits[2] = (number % 100) / 10;
        digits[3] = number % 10;

        //reversing adding 7 and mod 10
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] < 8)
            {
                digits[i] = (digits[i] + 10) - 7;
            }
            else
            {
                digits[i] -= 7;
            }
        }

        outputNumber = digits[2] * 1000 + digits[3] * 100 + digits[0] * 10 + digits[1];
        return outputNumber;
    }

    static void Main(string[] args)
    {
        //declaring local variables
        int number;//user-inputed 4-digit number

        //reading user input 
        Console.Write("Please, enter the 4-digit number:");
        number = Convert.ToInt16(Console.ReadLine());

        //output
        Console.WriteLine($"{encrypt(number)}");
        //output
        Console.WriteLine($"{decrypt(encrypt(number))}");
    }
}
