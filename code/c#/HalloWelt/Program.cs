using System; // use System Namespace

// Bezeichner, z.B. Namespace
namespace HalloWelt
{
    class Program
    {
        // Methoden

        static void convertAscii(int code)
        {

            char c = Convert.ToChar(code);
            Console.WriteLine("Ascii of " + code + "=" + c);

        }
        static void getHandy()
        {
            Handy h = new Handy("NewHandyBrand"); // create a new Handy Object

            myWriteLine("Handy Hersteller="+h.Hersteller);
        }
        static void myWriteLine(String s)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("\t" + s);
        }

        static void showArray()
        {
            // eindimensionales array
            int[] array1 = { 7, 14, 21, 28 };

            for (int zeile = 0; zeile < array1.Length; zeile++)
            {
                myWriteLine("zeile=" + array1[zeile]);

            }

            // zwei dimensionales array
            int[,] arr = new int[2, 3];
            arr[0, 0] = 5;
            arr[0, 1] = 55;
            arr[0, 2] = 95;
            arr[1, 0] = 10;
            arr[1, 1] = 65;
            arr[1, 2] = 98;

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.Write("Werte Ebene {0}: ", i);
                for (var j = arr.GetLowerBound(1); j <= arr.GetUpperBound(1); j++)
                    Console.Write(arr[i, j].ToString(" 000  "));
                Console.WriteLine();

            }
        }
        static void getMaxInteger()
        {
            int myInt; // declaration
            //int a, b, c; // declaration von a,b und c
            long zaehler = 1;

            myWriteLine("Bitte warten ...");
            myInt = 1;
            while (myInt>0)
            {
                myInt++;
                zaehler++;
            }
            myWriteLine("Max Integer Wert=" + (zaehler-1));
        }
        static long Fakultaet(int zahl) // signatur
        {
            long ergebnis = 1; // variablen declaration mit Zuweisung
            // for schleife
            for (int i=1;i<=zahl;i++)
            {
                // Berechnung
                ergebnis *=  i; // was heisst das?
            }
            return ergebnis;
        }

        static int getZufallszahl()
        {
            Random rnd = new Random();
            int wuerfel = rnd.Next(1, 7);  // creates a number between 1 and 6;
            return wuerfel;
        }

        static void willkommen()
        {
            myWriteLine("Bitte geben Sie ihren Namen ein");
            string myFirstName;
            myFirstName = Console.ReadLine();
            String myString = "Willkommen " + myFirstName + " zu Tag 3";
            myWriteLine(myString);

        }

        static void showStrings(String s)
        {
            myWriteLine("String=" + s);

            myWriteLine("Laenge=" + s.Length);

            myWriteLine("String enthält E=" + s.Contains("e"));

            if (s.Length> 5)
            {
                myWriteLine("String substr(2,3)=" + s.Substring(2, 3));
            }
            
        }

        static void Main(string[] args)
        {
            String myString = "Hello World mit Variable";
            myWriteLine(myString);
            for(int i=1;i<5;i++)
            {
                myWriteLine(myString + ": " +  i);
            }
            int zaehler = 0;
            myString = "While Loop";
            while(zaehler < 5)
            {
                zaehler++;
                myWriteLine(myString + ": " + zaehler);
            }
            myWriteLine("Bitte Zahl zwischen 1 und 10 eingeben:");
            int x = int.Parse(Console.ReadLine());
            myWriteLine("Fakultät von " + x + "=" + Fakultaet(x));

            //willkommen();
            //getMaxInteger();

            int summe = 0;
            for (int i = 1; i <= 10; i++)
            {                
                summe += getZufallszahl();
            }
            //myWriteLine("Summe der Würfel=" + summe);

            //showStrings("Mal sehen, was alles angezeigt wird");

            showArray();

            getHandy();

            convertAscii(65);
            convertAscii(2);

        }
    }
}
