using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    // I denna klass har jag skapat alla variabler för Book
    class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;

        Random generator = new Random(); 
        // Denna publika konstruktor finns för att ge världen till alla variabler som skapats i klassen.
        public Book()
        {
            price = generator.Next(200);


        }
        public void print()
        {
            Console.WriteLine("Priset för denna bok är: " + price);


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book bok = new Book();
            bok.print();


            Console.WriteLine(bok);


            Console.ReadLine();

        }
    }
}
