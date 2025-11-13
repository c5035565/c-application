using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Application
{
     class register
    { 
        private string _username; 
        private string _password;
        private string _email; 
        private string _phoneNumber;

        public register(string username, string password,string email, string phonenumber) 
        { 
            this._username = username; 
            this._password = password; 
            this._email = email; 
            this._phoneNumber = phonenumber;

        }
        public  void Register()
        {
            Console.WriteLine("Register selected");
            
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine(); 
            
            Console.WriteLine("Please enter your email"); 
            string email = Console.ReadLine(); 
            
            Console.WriteLine("Please enter your phone number");     
            string phonenumber = Console.ReadLine();
            
            Console.WriteLine($"Welcome {username}\nYou can start tracking your reciepies"); 
            

            return;


        }
    } 

} 
