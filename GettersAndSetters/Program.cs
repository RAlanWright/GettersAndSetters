using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR
            // if Movie.rating not in ratingCheck[], 
            // then display error message
            // utilize getts & setters

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
