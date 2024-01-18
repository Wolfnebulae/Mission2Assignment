using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class ArrayReturn
    {
        public static Array CalculateArray(int numberOfRolls)
        {
            int[] diceArray = new int[11];
            Random rnd = new Random();
            for (int i = 0; i < numberOfRolls; i++)
            {
                int Dice1 = rnd.Next(1, 7);
                int Dice2 = rnd.Next(1, 7);
                int diceResult = Dice1 + Dice2;

                diceArray[diceResult - 2]++;
            }
            return diceArray;
        }
        
    }
}
