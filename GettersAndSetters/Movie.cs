using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        // Private can prevent the rating
        // from being invalid

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                } else
                {
                    rating = "NR";
                }

                // Issue getting an array + for loop to work

                //string[] ratingCheck = { "G", "PG", "PG-13", "R" };
                //for (int i = 0; i < ratingCheck.Length; i++)
                //{
                //    if (value == ratingCheck[i])
                //    {
                //        rating = value;
                //    }
                //    else if (value != ratingCheck[i])
                //    {
                //        rating = "NR";
                //    }
                //}
            }
        }
    }
}
