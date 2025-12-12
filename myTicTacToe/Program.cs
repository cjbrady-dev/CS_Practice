using System;

namespace myTicTacToe
{
    class Program
    {
        static char[,] playField = {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };
        static int turns = 0;
        static void Main(string[] args)
        {
          Program myField = new Program();

          Console.Clear();
          Console.WriteLine("    |     |     ");
          Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0], playField[0,1], playField[0, 2]);
          Console.WriteLine("____|_____|_____");
          Console.WriteLine("    |     |     ");
          Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0], playField[0,1], playField[0,2]);
          Console.WriteLine("____|_____|_____");
          Console.WriteLine("    |     |     ");
          Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0], playField[0,1], playField[0,2]);
          Console.WriteLine("    |     |     ");  
          turns++;
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