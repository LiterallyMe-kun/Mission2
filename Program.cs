using Mission2;

internal class Program
{

    /*  
        
        
        int numRolls
        
    method to divide each index of diceResult[] by numRolls

    post histogram of *'s to demonstrate the percentage each number took

    */
    private static void Main(string[] args)
    {
        int[] calculatedRolls;
        
        //this has to be a double because Math.round really wanted to be sure if it were a double or decimal
        int numRolls = 0;

        double rolledFreq = 0;

        

        Required rq = new Required();

        System.Console.WriteLine("How many dice rolls will you throw? Enter a whole numeral (ie. 32):");
        numRolls = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("At " + numRolls + "rolls, here are your results!");

        System.Console.WriteLine("{One asterisk equal 1% of 100% of the results)");

        //use the second class on Required.cs, assigning its output (times a certain number was rolled) to a new array
        calculatedRolls = rq.RollDice(numRolls); 


        for (int i = 0; i < calculatedRolls.Length; i++)

        {
            //reset the asterisk count for each number 
            string asteriskNum = "";
            rolledFreq = (calculatedRolls[i] / numRolls);

            rolledFreq = Math.Round(rolledFreq);

            //loop to add asterisks
            for (int j = 0; j <= calculatedRolls[i]; j++) 
            {
                asteriskNum = asteriskNum + "*";
            }

            System.Console.WriteLine("Percentage of " + (i + 2) + "'s rolled: " + asteriskNum);

        }


        System.Console.WriteLine("Thanks for playing!");
    }




}