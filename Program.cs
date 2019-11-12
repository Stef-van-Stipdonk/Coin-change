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
            if ((enterAmount % 0.25) < enterAmount)
            {
                coins[3] = (int)(enterAmount / 0.25);
                amountLeft = enterAmount % 0.25;
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

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of money you want to change:");
            double enterAmount = Convert.ToDouble(Console.ReadLine());
            double toChange = enterAmount;
            double amountLeft = 0.0;
            int[] coins = new int[4];
            ChangeCalc(enterAmount, amountLeft, coins);
        }
    }
}
