using System;
using Kata;

namespace StartUp
{
   public  class Program
    {
        static void Main(string[] args)
        {
            BowlingGame bowlinggame = new BowlingGame();
            bowlinggame.rolls = new int[20];
        }
    }
}
