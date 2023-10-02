using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }


            /// <summary>
            /// Examines the datastructure List
            /// </summary>


            /// Answers:
            /// 2. If the count becomes equal to the capacity of the list, the list increases automatically by reallocating the internal array.
            ///3. The memory of the ArrayList type capacity is increased by doubling it.
            ///4. The capacity does not increase each time when elements are added to avoid unnecessary allocation/deallocation.
            ///5. NO, the capacity does not decrease automatically if the elements are removed and we only have to explicitly decrease capacity if needed.
            ///6. It is advantage to use array if we know fixed size of elements and to access elements faster using respective indexes.

            static void ExamineList()
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

                try
                {
                    bool isActive = false;
                    List<string> list = new List<string>();
                    string UInput;

                    do
                    {
                        Console.WriteLine("Welcome..");
                        Console.WriteLine("Press (+) to add name to the list or press (-) to remove names from the list:" + "\n press (Q) to quit/exit the main menu");
                        string input = Console.ReadLine();
                        char nav = input[0];
                        string value = input[1..].Trim();

                        switch (nav)
                        {
                            case '+':
                                if (string.IsNullOrWhiteSpace(value))
                                {
                                    Console.WriteLine("Enter the name to add in the list:");
                                    UInput = Console.ReadLine();
                                    list.Add(UInput);
                                }
                                else
                                {
                                    list.Add(value);
                                }

                                foreach (var name in list)
                                {
                                    Console.WriteLine($"The names in the list are: {name}");
                                }
                                Console.WriteLine(list.Count);
                                break;

                            case '-':

                                if (string.IsNullOrWhiteSpace(value))
                                {
                                    Console.WriteLine("Enter the name to remove from the list:");
                                    UInput = Console.ReadLine();
                                    list.Add(UInput);
                                }
                                else
                                { list.Add(value); }
                                foreach (var name in list)
                                {
                                    Console.WriteLine($"The names in the list are: {name}");
                                }
                                Console.WriteLine(list.Count);
                                break;

                            case 'Q':

                                isActive = true;
                                break;

                            default:

                                Console.Clear();
                                throw new ArgumentException("Invalid Entry! Enter only + or - to add or remove elements");
                        }

                    } while (!isActive);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            /// <summary>
            /// Examines the datastructure Queue
            /// </summary>
            static void ExamineQueue()
            {
                /*
                 * Loop this method untill the user inputs something to exit to main menue.
                 * Create a switch with cases to enqueue items or dequeue items
                 * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
                */


                /*Answers: Queue follows linear data structure but it is open as both ends.
                 * Implementation takes place in FIFO order 
                 * Eg: A person standing first in queue to purchase ticket will come out first */
                try
                {
                    bool isActive = false;
                    Queue<string> person = new Queue<string>();

                    do
                    {
                        Console.WriteLine("Welcome to ICA..");
                        Console.WriteLine("Press '1' to add a person to the Queue or press  or '2' to remove a person from the Queue:" + "\n press '0' to quit/exit the main menu");
                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("Enter the name to be added in Queue:"); ;
                                string name = Console.ReadLine();
                                person.Enqueue(name);

                                foreach (var pers in person)
                                {
                                    Console.WriteLine($"Person: {pers} is in the Queue");
                                }

                                break;

                            case "2":

                                if (person.Count > 0)
                                {
                                    string person1 = person.Dequeue();
                                    Console.WriteLine($"{person1} has left the queue.");
                                }
                                else
                                {
                                    Console.WriteLine("The Queue is empty");
                                }
                                break;

                            case "0":

                                isActive = true;
                                break;

                            default:

                                Console.Clear();
                                throw new ArgumentException("Invalid choice. Please enter a valid option.");

                        }

                    } while (!isActive);

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                /* 1. Using stack to implement above is not so smart as stack uses FILO principle where the person who came 
                 first is the last to go out. Thus implementing queue with stack is not the right process. */

            }
        }

        private static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            /* Stack : linear data structure where insertion and deletion of elements takes place in the same end(top of the stack).
             * Stack follows FILO or LIFO principle and manages to clear memory by itsel
        * Eg: Book stacked on top of one another in the shelf -- the book which is inserted first remains for longest time as it can be accessed last. */
            try
            {
                bool isActive = false;
                Stack<string> person = new Stack<string>();
                do
                {
                    Console.WriteLine("Welcome to ICA..");
                    Console.WriteLine("Press '1' to add a person to the stack or press  or '2' to remove a person from the stack:" + "\n Press (3) to Reverse a text" +
                        "\n press '0' to quit/exit the main menu");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Enter the name to be added in Stack:"); ;
                            string name = Console.ReadLine();
                            person.Push(item: name);

                            foreach (var pers in person)
                            {
                                Console.WriteLine($"Person: {pers} is in the stack");
                            }

                            break;

                        case "2":

                            if (person.Count > 0)
                            {
                                string person1 = person.Pop();
                                Console.WriteLine($"{person1} has left the stack");
                            }
                            else
                            {
                                Console.WriteLine("The Queue is empty");
                            }
                            break;

                        case "3":
                            {
                                Stack<char> chars = new Stack<char>();
                                Console.WriteLine("Enter a text to be reversed:");
                                string input = Console.ReadLine();

                                foreach (char c in input)
                                {
                                    chars.Push(c);
                                }
                                char[] revString = new char[chars.Count];
                                for (int i = 0; i < chars.Count; i++)
                                {
                                    revString[i] = chars.Pop();
                                }
                                Console.WriteLine(revString);
                            }
                            break;

                        case "0":

                            isActive = true;
                            break;

                        default:

                            Console.Clear();
                            throw new ArgumentException("Invalid choice. Please enter a valid option.");

                    }

                } while (!isActive);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            Console.WriteLine("\nEnter a string to check for the correct parenthesis.");
            string? input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            bool isWellFormed = true;
            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[' || c == '<')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']' || c == '>')
                {
                    if (stack.Count == 0)
                    {
                        isWellFormed = false;
                        break;
                    }
                    char top = stack.Pop();

                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '[') || (c == '>' && top != '<'))
                    {
                        isWellFormed = false;
                        break;
                    }
                }

            }
            if (stack.Count != 0)
            {
                isWellFormed = false;
            }
            if (isWellFormed)
            {
                Console.WriteLine("\nThe string has correct parenthesis.");
            }

        }

    }
}

/* 2. Value types holds the data in its own memory space whereas Reference types stores only the references of the data.
 * Value types are stored on the stack whereas reference types are stored on the heap.
 *  All numeric data types, structs, enums are value types
 *  Classes, strings, Delegates etc are reference types. */

/* Heaps stores data randomly and also allocation/de-allocation has to be taken care manually. */
