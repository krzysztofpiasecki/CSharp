using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        List<float> ratings = new List<float>();

       public void addRating( float rating)
            {
            ratings.Add(rating);
            }

        public float CalculateAvarage()
        {
           float sum = 0;
           float avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();

            return avg;

        }

        public float MaxRating()
        {
            return ratings.Max();
        }

        public float MinRating()
        {
           return ratings.Min();
        }
    }
}
