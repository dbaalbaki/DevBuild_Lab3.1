using System;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
            
            string[] name = { "Tom", "Nick", "Hassan", "Ali" };
            string[] food = { "Pizza", "Burgers", "Donuts", "Crab" };
            string[] job = { "Police", "Nurse", "Pilot", "Cop" };
            int UserInput;
             


            Console.WriteLine("\nWelcome to our Dev.Build class. Which student would you like to learn more about?");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("\nEnter a number: ");
                    int num = Int32.Parse(Console.ReadLine());



                    if (num == 0)
                    {
                        Console.WriteLine($"\nStudent 0 is {name[num]}. What would you like to know about {name[num]}? ");
                        Console.Write("\nSelect 1 for Favorite food or Select 2 for previous job? ");
                        UserInput = Int32.Parse(Console.ReadLine());
                        if (UserInput == 1)
                        {
                            Console.WriteLine("\nPizza");
                        }
                        else if (UserInput == 2)
                        {
                            Console.WriteLine("Police");
                        }
                        else
                        {
                            Console.WriteLine("\nThat data does not exist");
                        }

                    }
                    if (num == 1)
                    {
                        Console.WriteLine($"\nStudent 1 is {name[num]}. What would you like to know about {name[num]}? Favorite food or previous job?");
                        Console.Write("\nSelect 1 for Favorite food or Select 2 for previous job? ");
                        UserInput = Int32.Parse(Console.ReadLine());
                        if (UserInput == 1)
                        {
                            Console.WriteLine("\nBurgers");
                        }
                        else if (UserInput == 2)
                        {
                            Console.WriteLine("\nNurse");
                        }
                        else
                        {
                            Console.WriteLine("\nThat data does not exist");
                        }
                    }
                    if (num == 2)
                    {
                        Console.WriteLine($"\nStudent 2 is {name[num]}. What would you like to know about {name[num]}? Favorite food or previous job?");
                        Console.Write("\nSelect 1 for Favorite food or Select 2 for previous job? ");
                        UserInput = Int32.Parse(Console.ReadLine());
                        if (UserInput == 1)
                        {
                            Console.WriteLine("\nDonuts");
                        }
                        else if (UserInput == 2)
                        {
                            Console.WriteLine("\nPilot");
                        }
                        else
                        {
                            Console.WriteLine("\nThat data does not exist");
                        }
                    }
                    if (num == 3)
                    {
                        Console.WriteLine($"\nStudent 3 is {name[num]}. What would you like to know about {name[num]}? Favorite food or previous job?");
                        Console.Write("\nSelect 1 for Favorite food or Select 2 for previous job? ");
                        UserInput = Int32.Parse(Console.ReadLine());
                        if (UserInput == 1)
                        {
                            Console.WriteLine("\nCrab");
                        }
                        else if (UserInput == 2)
                        {
                            Console.WriteLine("\nCop");
                        }
                        else
                        {
                            Console.WriteLine("\nThat data does not exist");
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nThat student does not exist.");
                    }

                    Console.Write("\nWould you like to enter another student? Enter: (Yes or No) ");
                    string Choice = Console.ReadLine();
                    if (Choice == "No")
                    {
                        Console.WriteLine("\nThanks!");
                        
                    }
                    else if (Choice == "Yes")
                    {
                        Console.WriteLine();
                        continue;
                    }
                    break;

                }
                
                     // Console.WriteLine(name[num]);
                     // Console.WriteLine(food[num]);
                     // Console.WriteLine(job[num]);
                
            }
            

            
            









        }
    }
}
