//Omar Marin
/*
 * Create a function SumDigits that receives a number and returns
 * any results in the sum of its digits.
 * For example, if the number is 123, the sum would be 6.
 * 
 * Console.Write( SumDigits(123) );
 * 6
*/
using System;

class FunctionSumDigits
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter digits");
        string numbers = Console.ReadLine();

        Console.WriteLine(SumDigits(numbers));

    }

    public static int SumDigits(int num)
    {
        string str = Convert.ToString(num);
        int sum = 0;

        for (int i = 0; i < str.Length; i++)
            sum += Convert.ToInt32(str.Substring(i, 1));

        return sum;
    }
}

