using System;
using System.Globalization;

namespace IndividueleOefeningen
{
    public class DateTimeOefeningen
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. H10-Klokje");
            Console.WriteLine("2. H10-dag-van-de-week");
            Console.WriteLine("3. H10-ticks-sinds-2000");
            Console.WriteLine("4. H10-schrikkelteller");
            Console.WriteLine("5. H10-simpele-timing");
            Console.WriteLine("6. H10-verjaardag-v2");

            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                Klokje();
            }
            else if (keuze == 2)
            {
                WeekdagProgramma();
            }
            else if (keuze == 3)
            {
                Ticks2000Programma();
            }
            else if (keuze == 4)
            {
                SchrikkelTeller();
            }
            else if (keuze == 5)
            {
                SimpeleTiming();
            }
            else if (keuze == 6)
            {
                VerjaardagProgramma();
            }
        }
        public static void Klokje()
        {
            do
            {
                Console.Clear();
                DateTime currentTime = DateTime.Now;
                Console.WriteLine($"{currentTime.Hour:D2}:{currentTime.Minute:D2}:{currentTime.Second:D2}");
                System.Threading.Thread.Sleep(1000);
            } while (true);
        }
        public static void WeekdagProgramma()
        {
            System.Console.WriteLine("Welke dag?");
            int dag = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Welke maand?");
            int maand = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Welk jaar?");
            int jaar = Convert.ToInt32(Console.ReadLine());
            DateTime tijdstip = new DateTime(jaar, maand, dag);
            CultureInfo infoVlaanderen = new CultureInfo("nl-BE");
            System.Console.WriteLine($"{tijdstip.Day} {tijdstip.ToString("MMMM", infoVlaanderen)} {tijdstip.Year} is een {tijdstip.ToString("dddd",infoVlaanderen)}");
        }
        public static void Ticks2000Programma()
        {
            DateTime start = new DateTime(2000,1,1);
            System.Console.WriteLine($"Sinds 1 januari 2000 zijn er {DateTime.Now.Ticks - start.Ticks} ticks voorbijgegaan");
        }
        public static void SchrikkelTeller() {
            int aantalSchrikkeljaren = 0;
            for(int jaar = 1799; jaar <= 2020; jaar++) {
                if (DateTime.IsLeapYear(jaar)) {
                    aantalSchrikkeljaren++;
                }
            }
            System.Console.WriteLine($"Er zijn {aantalSchrikkeljaren} schrikkeljaren tussen 1799 en 2020");
        }
        public static void SimpeleTiming()
        {
            DateTime voor = DateTime.Now;
            int[] ints = new int[1_000_000]; // underscore = truukje voor leesbaarheid
            for (int i = 0; i < ints.Length; i++) {
                ints[i] = i+1;
            }
            DateTime na = DateTime.Now;
            TimeSpan hoeveelheid = na - voor;
            System.Console.WriteLine($"Het duurt {hoeveelheid.Milliseconds} milliseconden om een array van een miljoen elementen aan te maken en op te vullen met opeenvolgende waarden.");
        }
        public static void VerjaardagProgramma()
        {
            System.Console.WriteLine("Welke dag ben je geboren?");
            int dag = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Welke maand ben je geboren?");
            int maand = Convert.ToInt32(Console.ReadLine());
            DateTime teControlerenDatum = DateTime.Now;
            int aantalBijgeteld = 0;
            // eerste voorwaarde verandert de eerste versie van de oefening in de tweede versie
            while (aantalBijgeteld == 0 || teControlerenDatum.Day != dag || teControlerenDatum.Month != maand)
            {
                teControlerenDatum = teControlerenDatum.AddDays(1);
                aantalBijgeteld++;
            }
            System.Console.WriteLine($"Het is nog {aantalBijgeteld} dagen tot je volgende verjaardag.");
        }
    }
}
