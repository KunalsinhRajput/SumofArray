using System;

namespace SumofArray;

internal class Program
{
    public static void Main(string[] args)
    {
        int[]a=new int[5];
        int i;
        int sum = 0;
        try
        {
            Console.WriteLine("Enter no of array elements");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Sum of Array is " + sum);
            Console.ReadLine();
        } catch (Exception e)
        {
            Console.WriteLine("enter valid number "+ e);
        }
    }
}
