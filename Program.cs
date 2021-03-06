﻿using System;
using library.Models;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Library myLibrary = new Library("The Library!", "People of Boise", "Boise");
            System.Console.WriteLine(myLibrary.Name);
            Book hp = new Book("Harry Potter", "JKR");
            Book lotr = new Book("The Hobbit", "Tolken");
            Book narnia = new Book("Narnia", "CS Lewis", false);
            myLibrary.AddBook(hp);
            myLibrary.AddBook(lotr);
            myLibrary.AddBook(narnia);

            bool inLibrary = true;
            myLibrary.Greeting();
            while(inLibrary) 
            {
                Console.ReadLine();
                Console.Clear();
                bool stayInLibrary = myLibrary.PrintDirectory();
                if (!stayInLibrary) 
                {
                    inLibrary = false;
                    System.Console.WriteLine("GoodBye");
                }
            }
        }
    }
}
