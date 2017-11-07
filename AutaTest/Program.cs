using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Car> carsList = new List<Car>();
            List<String> colors = new List<String>()
            {
                "hnědá", "béžová", "černá", "šedá", "tmavě šedá", "fakt hodně tmavě šedá"
            };
            for (int i = 0; i < 10; i++)
            {
                bool moving;
                int rndMoving = rnd.Next(1, 3);
                if (rndMoving == 1)
                {
                    moving = true;
                }
                else
                {
                    moving = false;
                }
                carsList.Add(new Car(colors[rnd.Next(0, colors.Count() - 1)], rnd.Next(0, 500000), rnd.Next(1980, 2018).ToString(), moving));
            }
            //Car car = new Car("hněď", 69, "1999", true);

            int highest = -1;
            int highestPos = 0;
            for (int i = 0; i < carsList.Count()-1; i++)
            {
                if (carsList[i].Mileage > highest)
                {
                    highest = carsList[i].Mileage;
                    highestPos = i;
                }
                Console.WriteLine("Vypisuji " + i + ". auto");
                Console.WriteLine(carsList[i]+"\n");
            }
            Console.WriteLine("Nejvíce má najeto toto auto: ");
            Console.WriteLine(carsList[highestPos]);
            
        }
    }
}
