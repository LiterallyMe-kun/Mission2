using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    /* 
      method loop to roll dice for numRolls

      2 6-sided dice
        if statement to increment each index from 0 to 10, 
                                    since it rolls from 2 to 12
            int[] diceRecord
            
            if diceResult = 2
                diceRecord[0] = diceRecord[0] +      
     */

    internal class Required
    {
        // output is an array of ints
        public int[] RollDice(int numRolls) 
        {
            int[] diceRecord;

            diceRecord = new int[11];

            for (int i = 0; i < numRolls; i++)
            {
                // actually roll two 6-sided dice
                Random rnd = new Random();

                int diceResult = rnd.Next(1,7) + rnd.Next(1,7);

                //switch case because it's cleaner than ifs
                switch (diceResult)
                {
                    case 2:
                        diceRecord[0] = diceRecord[0] + 1;
                        break;

                    case 3:
                        diceRecord[1] = diceRecord[1] + 1;
                        break;

                    case 4:
                        diceRecord[2] = diceRecord[2] + 1;
                        break;

                    case 5:
                        diceRecord[3] = diceRecord[3] + 1;
                        break;

                    case 6:
                        diceRecord[4] = diceRecord[4] + 1;
                        break;

                    case 7:
                        diceRecord[5] = diceRecord[5] + 1;
                        break;

                    case 8:
                        diceRecord[6] = diceRecord[6] + 1;
                        break;

                    case 9:
                        diceRecord[7] = diceRecord[7] + 1;
                        break;

                    case 10:
                        diceRecord[8] = diceRecord[8] + 1;
                        break;

                    case 11:
                        diceRecord[9] = diceRecord[9] + 1;
                        break;

                    case 12:
                        diceRecord[10] = diceRecord[10] + 1;
                        break;
                }
            }
            // return the array 
            return diceRecord;
        }
    }
}
