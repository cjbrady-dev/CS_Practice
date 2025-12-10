using System;

namespace myTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
          Program game = new Program();
          int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
          game.StartGame(nums);
          Console.WriteLine("  1  |  2  |  3  ");
          Console.WriteLine("-----|-----|-----");
          Console.WriteLine("  4  |  5  |  6  ");
          Console.WriteLine("-----|-----|-----");
          Console.WriteLine("  7  |  8  |  9  ");


        }

        static int StartGame(int[] nums)
        {
            switch(nums.Length)
            {
                case 1:
                    Console.WriteLine("You have selected 1");
                    return 1;
                case 2:
                    Console.WriteLine("You have selected 2");
                    return 2;
                case 3:
                    Console.WriteLine("You have selected 3");
                    return 3;
                case 4:
                    Console.WriteLine("You have selected 4");
                    return 4;
                case 5:
                    Console.WriteLine("You have selected 5");
                    return 5;
                case 6:
                    Console.WriteLine("You have selected 6");
                    return 6;
                case 7:
                    Console.WriteLine("You have selected 7");
                    return 7;
                case 8:
                    Console.WriteLine("You have selected 8");
                    return 8;
                case 9:
                    Console.WriteLine("You have selected 9");
                    return 9;
            }
        }
    }
}