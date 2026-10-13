using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        // private fields

        private string title ;
        private string author;

        private int isbn;

        // public properties

        public string Title
        {
            get { return title; }
            set
            {
                // Ensure title is not blank

                if (!value.Any(char.IsDigit) && value != "")
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Book title cannot be blank.");
                }

            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                // Ensure title is not blank

                if (!value.Any(char.IsDigit) && value != "")
                {
                   author = value;
                }
                else
                {
                    Console.WriteLine("Error: Book author cannot be blank.");
                }

            }
        }
        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
           
        }
        public Book(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
