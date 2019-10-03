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
        public string genre;
        Random generator = new Random(); 
        // Denna publika konstruktor finns för att ge världen till alla variabler som skapats i klassen.
        public Book()
        {
            name = "Speedwagon";
            price = generator.Next(200);
            rarity = generator.Next(10);
            category = genre;
           
        }
        public void print()
        { // med dessa instanser kan användaren ge input på vilken genre/category hen önskar samt få se namn, pris och rarity på boken
        var genre = Console.ReadLine();
            Console.WriteLine("Detta är en: " + genre + " bok");
            

            Console.WriteLine("Denna bok heter: "  + name);
            Console.WriteLine("Priset för denna bok är: " + price);
            Console.WriteLine("Från 0-10 är denna bok " + rarity + " i sällsynthet");
                
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välj bok genre");
           
           
            

            Book bok = new Book();
            bok.print();

           

            


            Console.ReadLine();

        }
    }
}
