using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            for (; ;)
            {

           
            Console.WriteLine("Podaj liczbę z zakresu od 1 -10");
            float rating;
            bool result = float.TryParse( Console.ReadLine(), out rating);

            if (rating == 11)
            {
                    break;
            }
                if (result)
                {
                if (rating > 0 && rating <= 10)
                     {
                          diary.addRating(rating);
                     }

                else
                    {
                        Console.WriteLine("Wprowadziłeś złą liczbę, wprowadz lidzbę z zakresu od 1 -10");
                    }

                }
           
           
        }
            Console.WriteLine("Twoja średnia to " +  diary.CalculateAvarage());
            Console.WriteLine("Minimalna ocena to " + diary.MinRating());
            Console.WriteLine("Maksymalna ocena to " + diary.MaxRating());
            Console.ReadKey();
        }
    }
}
