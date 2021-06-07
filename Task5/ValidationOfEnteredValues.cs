using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class ValidationOfEnteredValues
    {
        public int ValidateEnteredComplexity()
        {

            {
                int validComlexity;
                while (true)
                {

                    int enteredComlexity = Convert.ToInt32(Console.ReadLine());
                    if ((enteredComlexity == 1) || (enteredComlexity == 2) || (enteredComlexity == 4))
                    {
                        validComlexity = enteredComlexity;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Error! Try again. Valid values are 1, 2 or 4");
                    }

                }
                return validComlexity;
            }
        }

        public int ValidateEnteredPriority()
        {
            int validPriority;
            while (true)
            {

                int enteredPriority = Convert.ToInt32(Console.ReadLine());
                if ((enteredPriority == 1) || (enteredPriority == 2) || (enteredPriority == 3))
                {
                    validPriority = enteredPriority;
                    break;

                }
                else
                {
                    Console.WriteLine("Error! Try again. Valid values are 1, 2 or 3");

                }

            }
            return validPriority;
        }
    }
}
