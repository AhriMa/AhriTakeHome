using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
   public class BowlingGame
    {
        public int roll = 0;
        public int[] rolls = new int[21];
        
        public void Roll(int[] rolls)
        {
            
            foreach (int pinsDown in rolls)
            {
                Roll(pinsDown);
            }    
        }

        public void Roll(int pinsDown)
        {
            rolls[roll++] = pinsDown;
        }

        public int Score()
        {
            int score = 0;
            int cursor = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(cursor))
                {
                    score += 10 + rolls[cursor + 1] + rolls[cursor + 2];
                    cursor++; 
                    //if strick, only 1 cursor(slot) in this frame  is filled
                }
                else if (isSpare(cursor))
                {
                    score += 10 + rolls[cursor + 2];
                    cursor += 2;
                }

                else
                {
                    score += rolls[cursor] + rolls[cursor + 1];
                    cursor += 2;
                }
            }
            return score;
        }

        public Boolean isStrike(int cursor)
        {
            return rolls[cursor] == 10;
        }

        public Boolean isSpare(int cursor)
        {
            return rolls[cursor] + rolls[cursor + 1] == 10;
        }
    }
}
