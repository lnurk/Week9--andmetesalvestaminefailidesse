using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\lisan\samples\ShoppingList";
            string fileName = @"\\myshoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myshoppinglist = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add an item to shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myshoppinglist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string wish in myshoppinglist)
            {
                Console.WriteLine($"Your wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myshoppinglist);
        }
    }
}
