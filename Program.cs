using System;

namespace c_sharp_odev_enum
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(Days.Tuesday);
            Console.WriteLine((int)Days.Tuesday);


            int temperature = 28;

            if(temperature <= (int)Weather.Cold)
            {
                Console.WriteLine("Weather is cold");
            }
            else if(temperature >= (int)Weather.Hot)
            {
                Console.WriteLine("Weather is hot");
            }else if(temperature > (int)Weather.Cold  && temperature < (int)Weather.Hot)
            {
                Console.WriteLine("Weather is okay");
            }



        }
    }


    enum Days
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday

    }


    enum Weather
    {
        VeryCold = 5,
        Cold = 15,
        Normal = 25,
        Hot = 30,
        VeryHot = 35
    }







}
