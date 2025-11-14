// See https://aka.ms/new-console-template for more information

using My_Application;
using System;


class Program
{
    static void Main(string[] args)
    {

        register reg = new register("", "", "", "");

        Console.WriteLine("Welcome to to your food and reciepe manager...");

       
        string choice;

        do
        {
            Console.WriteLine("Do you want to log in or register? ('l' to login /'r' to register)");
        
            choice = Console.ReadLine().ToLower();


            if (choice == "l")
            {
                Console.WriteLine("Login selected.");
            }
            else if (choice == "r")
            {
                reg.Register();
                mainMenu();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'l' to login or 'r' to register.");
            }
        }
       
        while (choice != "l" && choice != "r");

        
    } 


    public static void mainMenu()
    {
        Console.WriteLine("______________Main Menu______________");
        Console.WriteLine("1. View Recipes");
        Console.WriteLine("2. Add Recipe");
        Console.WriteLine("3. View Ingredients");
        Console.WriteLine("4. Add Ingredient"); 
        Console.WriteLine("5. Logout");
    }
} 





