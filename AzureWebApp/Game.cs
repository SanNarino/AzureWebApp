using System;

namespace AzureWebApp;

public class Game
{
    //method to check if number is prime
    public bool IsPrime(int number)
    {
        bool isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
    
    //method to check if number is even
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    
    //method to check if number is odd
public bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    //method to check if number is a perfect square
    public bool IsPerfectSquare(int number)
    {
        int root = (int)Math.Sqrt(number);
        return root * root == number;
    }
    
    //main method
    public static void Main()
    {

    }




}