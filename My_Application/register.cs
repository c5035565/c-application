using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Application
{
    public class application_manager
    {
        register reg = new register("", "", "", "");

        public void startApp()
        { 
            
            string choice;

            do
            {
                Console.WriteLine("Do you want to log in or register? ('l' to login /'r' to register)");

                choice = Console.ReadLine().ToLower();
                login login = new login();
                bool loggedin = false;


                if (choice == "l")
                {

                    if (login.Login(reg.Username, reg.Password))
                    {
                        loggedin = true;
                    }

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

        public void mainMenu()
        {
            Console.WriteLine("______________Main Menu______________");
            Console.WriteLine("1. View Recipes");
            Console.WriteLine("2. Add Recipe");
            Console.WriteLine("3. View Ingredients");
            Console.WriteLine("4. Add Ingredient");
            Console.WriteLine("5. Logout");
            string  choice =  Console.ReadLine();

            if (choice == "5")
            {
                startApp();
            }
            else if(choice=="1" && choice == "2" && choice == "3" && choice =="4")
            {
                Console.WriteLine("Feature not implemented yet.");
                mainMenu();
            }
            else
            {
                Console.Write("Break");
            }


        }

        public class register
        { 
            public string Username { get { return _username; } }  
            public string Password { get { return _password; } }
            private string _username;
            private string _password;
            private string _email;
            private string _phoneNumber;

            public register(string username, string password, string email, string phonenumber)
            {
                this._username = username;
                this._password = password;
                this._email = email;
                this._phoneNumber = phonenumber;

            }
            public void Register()
            {
                Console.WriteLine("Register selected");

                Console.WriteLine("Please enter your username");
                this._username = Console.ReadLine();

                Console.WriteLine("Please enter your password");
                this._password = Console.ReadLine();

                Console.WriteLine("Please enter your email");
                this._email = Console.ReadLine();

                Console.WriteLine("Please enter your phone number");
                this._phoneNumber = Console.ReadLine();

                Console.WriteLine($"Welcome {this._username}\nYou can start tracking your reciepies");
                
                application_manager.startapp();


                return;


            }
        }
        public class login
        {
            public bool Login(string stored_username, string stored_password)
            {

                Console.WriteLine("Login selected");
                Console.WriteLine("Please enter your username");
                string enteredUsername = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                string enteredPassword = Console.ReadLine();

                if (enteredUsername == stored_username && enteredPassword == stored_password)
                {
                    Console.WriteLine($"Welcome back {stored_username}\nYou can start tracking your reciepies");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Please try again.");
                    return false;
                }



            }
        }
    }
}
