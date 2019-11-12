using System;

namespace Coin_change
{
    class Program
    {
        static void ChangeCalc(double enterAmount, double amountLeft, int[] coins)
        {
            if ((enterAmount % 2) < enterAmount)
            {
                coins[6] = (int)(enterAmount / 2);
                amountLeft = enterAmount % 2;
                enterAmount = amountLeft;
            }
            if ((enterAmount % 1) < enterAmount)
            {
                coins[5] = (int)(enterAmount / 1);
                amountLeft = enterAmount % 1;
                enterAmount = amountLeft;
            }
            if ((enterAmount % 0.50) < enterAmount)
            {
                coins[4] = (int)(enterAmount / 0.50);
                amountLeft = enterAmount % 0.50;
                enterAmount = amountLeft;
            }
            if ((enterAmount % 0.2) < enterAmount)
            {
                coins[3] = (int)(enterAmount / 0.2);
                amountLeft = enterAmount % 0.2;
                enterAmount = amountLeft;
            }
            if ((enterAmount % 0.1) < enterAmount)
            {
                coins[2] = (int)(enterAmount / 0.1);
                amountLeft = enterAmount % 0.1;
                enterAmount = amountLeft;
            }
            if ((enterAmount % 0.05) < enterAmount)
            {
                coins[1] = (int)(enterAmount / 0.05);
                amountLeft = enterAmount % 0.05;
                enterAmount = amountLeft;
            }
            if ((enterAmount % 0.01) < enterAmount)
            {
                coins[1] = (int)(enterAmount / 0.01);
                amountLeft = enterAmount % 0.01;
            }
        }
        static void DisplayChange(int[] arr)
        {
            if (arr[6] > 0)
                Console.WriteLine("Number of 2 euro coins: " + arr[6]);
            if (arr[5] > 0)
                Console.WriteLine("Number of 1 euro coins: " + arr[5]);
            if (arr[4] > 0)
                Console.WriteLine("Number of 50 cent coins: " + arr[4]);
            if (arr[3] > 0)
                Console.WriteLine("Number of 20 cent coins: " + arr[3]);
            if (arr[2] > 0)
                Console.WriteLine("Number of 10 cent coins: " + arr[2]);
            if (arr[1] > 0)
                Console.WriteLine("Number of 5 cent coins: " + arr[1]);
            if (arr[0] > 0)
                Console.WriteLine("Number of 1 cent coins: " + arr[0]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of money you want to change:");
            double enterAmount = Convert.ToDouble(Console.ReadLine());
            double toChange = enterAmount;
            double amountLeft = 0.0;
            int[] coins = new int[7];
            ChangeCalc(enterAmount, amountLeft, coins);

            Console.WriteLine("Amount to change: " + toChange);
            Console.WriteLine("The change is: ");
            DisplayChange(coins);
        }
    }
}
