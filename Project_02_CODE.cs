using System;
using System.Numerics;
using System.Diagnostics;

namespace Projekt_2
{
    class Program
    {
        static BigInteger Divide = 0;
        static void Main(string[] args)
        {
            double OpElapsedTime = 0, AllTime = 0;
            BigInteger Sum = 0;
            BigInteger[] Array = new BigInteger[] { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };

            foreach (BigInteger Element in Array)
            {
                Divide = 0; OpElapsedTime -= OpElapsedTime;
                var Timer = new Stopwatch();
                Timer.Start();
                if (IsPrimeWorst(Element)) { Console.WriteLine(Element + " jest liczbą pierwszą (WORST)"); }
                else { Console.WriteLine(Element + " nie jest liczbą pierwszą (WORST)"); }
                Timer.Stop();
                OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                Sum += Divide; AllTime += OpElapsedTime;
                Console.WriteLine("Czas sprawdzania liczby [s]: " + OpElapsedTime.ToString("F3") + "\nIlość dzieleń: " + Divide + "\n");
            }
            Console.WriteLine("\tCzas całej operacji [s]: " + AllTime.ToString("F3") + "\n\tIlość dzieleń całej operacji: " + Sum + "\n");
            Console.WriteLine("-----------------------------------------------\n");

            Sum -= Sum; AllTime -= AllTime;
            foreach (BigInteger Element in Array)
            {
                Divide = 0; OpElapsedTime -= OpElapsedTime;
                var Timer = new Stopwatch();
                Timer.Start();
                if (IsPrimeMmmmkey(Element)) { Console.WriteLine(Element + " jest liczbą pierwszą (MMMMKEY)"); }
                else { Console.WriteLine(Element + " nie jest liczbą pierwszą (MMMMKEY)"); }
                Timer.Stop();
                OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                Sum += Divide; AllTime += OpElapsedTime;
                Console.WriteLine("Czas sprawdzania liczby [s]: " + OpElapsedTime.ToString("F3") + "\nIlość dzieleń: " + Divide + "\n");
            }
            Console.WriteLine("\tCzas całej operacji [s]: " + AllTime.ToString("F3") + "\n\tIlość dzieleń całej operacji: " + Sum + "\n");
            Console.WriteLine("-----------------------------------------------\n");

            Sum -= Sum; AllTime -= AllTime;
            foreach (BigInteger Element in Array)
            {
                Divide = 0; OpElapsedTime -= OpElapsedTime;
                var Timer = new Stopwatch();
                Timer.Start();
                if (IsPrimeDaBest(Element)) { Console.WriteLine(Element + " jest liczbą pierwszą (DABEST)"); }
                else { Console.WriteLine(Element + " nie jest liczbą pierwszą (DABEST)"); }
                Timer.Stop();
                OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                Sum += Divide; AllTime += OpElapsedTime;
                Console.WriteLine("Czas sprawdzania liczby [s]: " + OpElapsedTime.ToString("F3") + "\nIlość dzieleń: " + Divide + "\n");
            }
            Console.WriteLine("\tCzas całej operacji [s]: " + AllTime.ToString("F3") + "\n\tIlość dzieleń całej operacji: " + Sum + "\n");
            Console.WriteLine("-----------------------------------------------\n");
        }
        static bool IsPrimeWorst(BigInteger Num)
        {
            Divide = 0;
            if (Num < 2) { return false; }
            else if (Num < 4) { return true; }
            else if (Num % 2 == 0) { Divide++; return false; }
            else
            {
                Divide++;
                for (BigInteger u = 3; u < Num / 2; u += 2)
                {
                    Divide++;
                    if (Num % u == 0) { return false; }
                }
            }
            return true;
        }
        public static bool IsPrimeDaBest(BigInteger Num)
        {
            Divide = 0;
            Divide++;
            if (Num % 2 <= 0) { return Num == 2; }
            BigInteger Power = 9;
            for (BigInteger i = 3; Power <= Num; i += 2)
            {
                Divide++;
                if (Num % i == 0) { return false; }                 
                Power += i * 4 + 4;
            }
            return true;
        }
        static bool IsPrimeMmmmkey(BigInteger Num)
        {
            Divide = 0;
            if (Num < 2) { return false; }
            for (BigInteger i = 2; i * i <= Num; i++) { Divide++; if (Num % i == 0) { return false; } }
            return true;
        }
    }
}
