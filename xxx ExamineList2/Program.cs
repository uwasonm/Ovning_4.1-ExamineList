using System;
using System.Runtime.Intrinsics.Arm;

namespace ExamineList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                  * Loop this method untill the user inputs something to exit to main menue.
                  * Create a switch statement with cases '+' and '-'
                  * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
                  * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
                  * In both cases, look at the count and capacity of the list
                  * As a default case, tell them to use only + or -
                  * Below you can see some inspirational code to begin working.
                 */

            List<string> theList = new List<string>();

            do
            {
                Console.WriteLine("Choose a word to add or remove");
                string input = Console.ReadLine();
                
                Console.WriteLine("Choose you action ADD for adding the word or REMOVE for removing the word");
                String nav = (Console.ReadLine());
                
                switch (nav)
                {
                    case "ADD":
                        theList.Add(input);
                        break;

                    case "REMOVE":
                        theList.Remove(input);
                        break;

                    case "QUIT":                    
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("OPS! {0} is not an option, only \"+\" or \"+\" can be used!", input);
                        break;
                }
                Console.WriteLine("The list:");
                Console.WriteLine("---------");

                for (int i = 0; i < theList.Count; i++)

                {
                    Console.WriteLine(theList[i]);
                }
                
                Console.WriteLine($"The list size is :" +theList.Count);
                Console.WriteLine($"The list capacity is :" + theList.Capacity);
                Console.WriteLine();
            } while (true);

                    
        }
    }
}

//2. First, the capacity is initialized at 4 and when that capicity is used,
//   reached at, it is inceased again to 4 more i.e. 8.

//3. Apparently the capacity increases by 4.

//4. The capacity does not increase until when there is no more room for a new element.

//5. When the elements are removed from the list the capacity does not decrease.


//6. SELF DEFINED ARRAYS VS LIST
