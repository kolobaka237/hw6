
using System;

class Programe
{
    public static void Main()
    {
        Console.WriteLine("Enter number:");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter dagree of number:");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your number in dagree = {Dagree(a, b)}");
        Console.WriteLine();
        Console.WriteLine("Enter first number:");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Sum numbers of range = {SumOfRange(first, second)}");
        Console.WriteLine();
        Console.WriteLine("Enter start of range: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end of range: ");
        int end = Convert.ToInt32(Console.ReadLine());
        List<int> perfectNumbers = PerfectNumbers(start, end);
        Console.WriteLine($"Perfect number if range from {start} to {end}:");
        foreach (var number in perfectNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        Console.WriteLine("Enter number playing card(1 - 13):");
        int card = Convert.ToInt32(Console.ReadLine());
        string[] deck = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        Console.WriteLine($"Your card is: {DisplayCard(deck, card)}");
        Console.WriteLine();
        Console.Write("Enter number of your ticket:");
        int ticket = Convert.ToInt32(Console.ReadLine());
        if(IsLuckyNumber(ticket))
        {
            Console.WriteLine($"Your ticket {ticket} is lucky!");
        }
        else
        {
            Console.WriteLine($"Your ticket {ticket} is unlucky!");
        }
        

    }

    static bool IsLuckyNumber(int number)
    {
        if (number < 100000 || number > 999999)
        {
            Console.WriteLine("Некорректный ввод. Введите 6-значное число.");
            return false;
        }

        int sumFirstHalf = 0;
        int sumSecondHalf = 0;

        for (int i = 0; i < 6; i++)
        {
            int digit = number % 10;
            number /= 10;

            if (i < 3)
            {
                sumFirstHalf += digit;
            }
            else
            {
                sumSecondHalf += digit;
            }
        }

        return sumFirstHalf == sumSecondHalf;
    }

    public static double Dagree(double a, double b)
    {
        
        double result = Math.Pow(a, b);
       return result;
    }
public static int SumOfRange(int a, int b)
    {
        int result = 0;
        for(int i = a; i <= b; i++)
        {
            result += i;
            
        }
        
        return result;
    }

    
    static List<int> PerfectNumbers(int start, int end)
    {
        List<int> result = new List<int>();

        for (int i = start; i <= end; i++)
        {
            int sum = 1;
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    sum += j;
                }
            }
            if (sum == i)
            {
                result.Add(i);
            }
        }

        return result;
    }

    static string DisplayCard(string[] deck, int index)
    {
        if (index >= 0 && index < deck.Length)
        {
            return deck[index];
        }
        else
        {
            return null;
        }
    }



}

