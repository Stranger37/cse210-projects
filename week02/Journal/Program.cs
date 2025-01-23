//For exceeding requirments I created a "Menu" class to Display the options to the user and to control the navigation
//through each option. In this class called "Menu" the other classes will be accessed to make the program work.

using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    
    static void Main(string[] args)
    {
        bool open = true;

        //INSTANCE OF JOURNAL CLASS OUT OF THE WHILE LOOP TO NOT RESET THE LIST VALUES
        Journal newEntry = new Journal();
        newEntry._entries = new List<Entry>();
        
        //LOOP TO MAINTAIN THE PROGRAM RUNNING TILL THE USER CHOOSE TO CLOSE IT
        while(open){
            Menu menu = new Menu();
            menu.printMenu();
            open = menu.navigation(newEntry);
        }
    }
}