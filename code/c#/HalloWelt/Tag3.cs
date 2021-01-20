using System;
using System.Drawing;

namespace HalloWelt
{

    class Tag3
    {
        public Tag3()
        {
        }


        static void willkommen()
        {
            Console.WriteLine("Bitte geben Sie ihren Namen ein");
            string myFirstName;
            myFirstName = Console.ReadLine();
            String myString = "Willkommen " + myFirstName + " zu Tag 3";
            Console.WriteLine(myString);
            Point p = new Point();
            p.X = 0;
            p.Y = 0;

        }
        static void Main2(string[] args)
        {

            willkommen();

        }
    }

}