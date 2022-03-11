using System;

namespace IndividueleOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de demo Objectgeoriënteerd Programmeren");
            Console.WriteLine("Topic van de uit te voeren oefening");
            Console.WriteLine("1.DateTime ");
            Console.WriteLine("2. ");

            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                DateTimeOefeningen.ToonSubmenu();
            }
            else if (keuze == 2)
            {

            }
        }
    }
}
