using System;
using System.Diagnostics;

namespace Projekt_1
{
    public struct Arrays
    {
        public int[] Array;
    }
    class Program
    {
        static int Assignment = 0, Increment = 0, IsEqual = 0, BiggerSmaller = 0, Addition = 0, Subtraction = 0, Division = 0;
        static double MaxCount = 0.0;
        static int AS = 0, INC = 0, EQ = 0, BS = 0, ADD = 0, SUB = 0, DIV = 0;
        static void Main(string[] args)
        {
            const int NIter = 10;
            bool Check = true;
            double Sum = 0, ElapsedTime = 0;
            Random rnd = new Random();
            Arrays p;
            Console.WindowWidth = 155;
            Console.WindowHeight = 40;

            Console.Write("Podaj ilość tablic do wygenerowania: ");
            int Amount = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Podaj element do wyszukania w tablicach (zakres wartości elementu od -100 do 100, liczby całkowite): ");
            int losElementos = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\tŚREDNI POMIAR CZASU I OPERACJI WYSZUKIWANIA BINARNEGO\n");
            Console.WriteLine("\n\tWystępowanie\tt[ms]\t\tPrzypisania\tPorównania\tInkrementacja\tPrzyrównania\tDodawania\tOdejmowania\tDzielenia\n");
            for (int i = 0; i < Amount; i++)
            {
                Check = true; Sum -= Sum; ElapsedTime -= ElapsedTime;
                Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0; Addition = 0; Subtraction = 0; Division = 0;
                p = new Arrays { Array = new int[100] };
                for (int j = 0; j < p.Array.Length; j++) { p.Array[j] = rnd.Next(-100, 100); }
                Array.Sort(p.Array);
                for (int n = 0; n < (NIter); ++n)
                {
                    Check = true;
                    var Watch = new Stopwatch();
                    Watch.Start();
                    if (BinarySearchAv(p.Array, losElementos) == true) { Check = false; }
                    Watch.Stop();
                    Sum += ((1000.0 * Watch.ElapsedTicks) / Stopwatch.Frequency);
                    AS += Assignment; EQ += IsEqual; INC += Increment; BS += BiggerSmaller; ADD += Addition; SUB += Subtraction; DIV += Division;
                }
                ElapsedTime += (Sum / NIter);
                AS /= NIter; EQ /= NIter; INC /= NIter; BS /= NIter; ADD /= NIter; SUB /= NIter; DIV /= NIter;
                MaxCount += AS + EQ + INC + BS + ADD + SUB + DIV;
                Console.WriteLine(ResultAv(Check, ElapsedTime, AS, BS, INC, EQ, ADD, SUB, DIV));
            }
            Console.WriteLine("\n Średni koszt złożoności wynosi: " + (MaxCount / Amount));

            Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0; Addition = 0; Subtraction = 0; Division = 0;
            AS = 0; INC = 0; EQ = 0; BS = 0; ADD = 0; SUB = 0; DIV = 0;
            Console.WriteLine("\n\n\t\t\t\t\t\tPESYMISTYCZNY POMIAR CZASU I OPERACJI WYSZUKIWANIA BINARNEGO\n");
            Console.WriteLine("\n\tWystępowanie\tt[ms]\t\tPrzypisania\tPorównania\tInkrementacja\tPrzyrównania\tDodawania\tOdejmowania\tDzielenia\n");
            for (int i = 0; i < Amount; i++)
            {
                Check = true; ElapsedTime -= ElapsedTime;
                Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0; Addition = 0; Subtraction = 0; Division = 0;
                AS = 0; INC = 0; EQ = 0; BS = 0; ADD = 0; SUB = 0; DIV = 0;
                p = new Arrays { Array = new int[100] };
                for (int j = 0; j < p.Array.Length; j++)
                {
                    p.Array[j] = rnd.Next(-100, 100);
                    if (p.Array[j] == losElementos) { p.Array[j] += 1; }
                }
                Array.Sort(p.Array);
                var Watch = new Stopwatch();
                Watch.Start();
                if (BinarySearchAv(p.Array, losElementos) == true) { Check = false; }
                Watch.Stop();
                ElapsedTime += ((1000.0 * Watch.ElapsedTicks) / Stopwatch.Frequency);
                MaxCount += Assignment + IsEqual + Increment + BiggerSmaller + Addition + Subtraction + Division;
                Console.WriteLine(ResultAv(Check, ElapsedTime, Assignment, BiggerSmaller, Increment, IsEqual, Addition, Subtraction, Division));
            }
            Console.WriteLine("\n Maksymalny koszto złożoności wynosi: " + (MaxCount / Amount));

            Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0; Addition = 0; Subtraction = 0; Division = 0;
            AS = 0; INC = 0; EQ = 0; BS = 0; ADD = 0; SUB = 0; DIV = 0;
            Console.WriteLine("\n\n\t\t\t\t\t\tŚREDNI POMIAR CZASU I OPERACJI WYSZUKIWANIA LINIOWEGO\n");
            Console.WriteLine("\n\tWystępowanie\tt[ms]\t\tPrzypisania\tPorównania\tInkrementacja\tPrzyrównania\tDodawania\tOdejmowania\tDzielenia\n");
            for (int i = 0; i < Amount; i++)
            {
                Check = true; Sum -= Sum; ElapsedTime -= ElapsedTime;
                p = new Arrays { Array = new int[100] };
                for (int j = 0; j < p.Array.Length; j++) { p.Array[j] = rnd.Next(-100, 100); }
                for (int n = 0; n < NIter; ++n)
                {
                    Check = true; Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0;
                    var Watch = new Stopwatch();
                    Watch.Start();
                    if (LinearSearchAv(p.Array, losElementos) == true) { Check = false; }
                    Watch.Stop();
                    Sum += ((1000.0 * Watch.ElapsedTicks) / Stopwatch.Frequency);
                    AS += Assignment; EQ += IsEqual; INC += Increment; BS += BiggerSmaller;
                }
                ElapsedTime += (Sum / NIter);
                AS /= NIter; EQ /= NIter; INC /= NIter; BS /= NIter;
                MaxCount += AS + EQ + INC + BS;
                Console.WriteLine(ResultAv(Check, ElapsedTime, AS, BS, INC, EQ, Addition, Subtraction, Division));
            }
            Console.WriteLine("\n Średni koszt złożoności wynosi: " + (MaxCount / Amount));

            Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0; Addition = 0; Subtraction = 0; Division = 0;
            AS = 0; INC = 0; EQ = 0; BS = 0; ADD = 0; SUB = 0; DIV = 0;
            Console.WriteLine("\n\n\t\t\t\t\t\tPESYMISTYCZNY POMIAR CZASU I OPERACJI WYSZUKIWANIA LINIOWEGO\n");
            Console.WriteLine("\n\tWystępowanie\tt[ms]\t\tPrzypisania\tPorównania\tInkrementacja\tPrzyrównania\tDodawania\tOdejmowania\tDzielenia\n");
            for (int i = 0; i < Amount; i++)
            {
                Check = true; ElapsedTime -= ElapsedTime; Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0;
                p = new Arrays { Array = new int[100] };
                for (int j = 0; j < p.Array.Length; j++)
                {
                    p.Array[j] = rnd.Next(-100, 100);
                    if (p.Array[j] == losElementos) { p.Array[j] += 1; }
                }
                var Watch = new Stopwatch();
                Watch.Start();
                if (LinearSearchAv(p.Array, losElementos) == true) { Check = false; }
                Watch.Stop();
                ElapsedTime += ((1000.0 * Watch.ElapsedTicks) / Stopwatch.Frequency);
                MaxCount += Assignment + IsEqual + Increment + BiggerSmaller + Addition + Subtraction + Division;
                Console.WriteLine(ResultAv(Check, ElapsedTime, Assignment, BiggerSmaller, Increment, IsEqual, Addition, Subtraction, Division));
            }
            Console.WriteLine("\n Maksymalny koszto złożoności wynosi: " + (MaxCount / Amount));

            Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0; Addition = 0; Subtraction = 0; Division = 0;
            AS = 0; INC = 0; EQ = 0; BS = 0; ADD = 0; SUB = 0; DIV = 0;
            Console.WriteLine("\n\n\t\t\t\t\t\t   PRZEDSTAWIENIE WŁAŚCIWOŚCI WYSZUKIWANIA LINIOWEGO\n");

            p = new Arrays { Array = new int[101] };
            Check = true;
            for (int j = 0; j < p.Array.Length; j++)
            {
                p.Array[j] = rnd.Next(-100, 100);
                if (p.Array[j] == losElementos) { p.Array[j] += 1; }
            }
            LinearSearch(p.Array, losElementos);
            Console.ReadKey();

            Assignment = 0; IsEqual = 0; Increment = 0; BiggerSmaller = 0; Addition = 0; Subtraction = 0; Division = 0;
            AS = 0; INC = 0; EQ = 0; BS = 0; ADD = 0; SUB = 0; DIV = 0;
            Console.WriteLine("\n\n\t\t\t\t\t\t   PRZEDSTAWIENIE WŁAŚCIWOŚCI WYSZUKIWANIA BINARNEGO\n");
            p = new Arrays { Array = new int[100] };
            Check = true;
            for (int j = 0; j < p.Array.Length; j++)
            {
                p.Array[j] = rnd.Next(-100, 100);
                if (p.Array[j] == losElementos) { p.Array[j] += 1; }
            }
            BinarySearch(p.Array, losElementos);
            Console.ReadKey();
        }

        public static string ResultAv(bool Thingy, double Time, int AS, int BS, int INC, int EQ, int ADD, int SUB, int DIV)
        {
            if (Thingy == false) { return "\tTAK\t\t" + Time.ToString("F5") + "\t\t" + AS + "\t\t" + BS + "\t\t" + INC + "\t\t" + EQ + "\t\t\t" + ADD + "\t\t" + SUB + "\t\t" + DIV; }
            else { return "\tNIE\t\t" + Time.ToString("F5") + "\t\t" + AS + "\t\t" + BS + "\t\t" + INC + "\t\t" + EQ + "\t\t\t" + ADD + "\t\t" + SUB + "\t\t" + DIV; }
        }

        public static bool BinarySearchAv(int[] Vector, int Number)
        {
            Assignment = 2; Subtraction = 1;
            int Left = 0, Right = Vector.Length - 1, Middle;
            while (Left <= Right)
            {
                Assignment++; BiggerSmaller++; Addition++; Division++;
                Middle = (Left + Right) / 2;
                IsEqual++;
                if (Vector[Middle] == Number) { return true; }
                else if (Vector[Middle] > Number) { BiggerSmaller++; Assignment++; Subtraction++; Right = Middle - 1; }
                else { Assignment++; Addition++; Left = Middle + 1; }
            }
            return false;
        }

        public static bool LinearSearchAv(int[] Vector, int Number)
        {
            Assignment = 1;
            for (int i = 0; i < Vector.Length; i++, Increment++)
            {
                BiggerSmaller++;
                IsEqual++;
                if (Vector[i] == Number) { return true; }
            }
            return false;
        }
        public static bool BinarySearch(int[] Vector, int Number)
        {
            Assignment = 2; Subtraction = 1;
            double ElapsedTime = 0;
            int Left = 0, Right = Vector.Length - 1, Middle;
            double OperationCounter = 0;
            Console.WriteLine("\t\t\t\t\t\tIlość \t\t\tt[ms]");
            Console.WriteLine("\t\t\t\t\t\toperacji \t\t\n");
            while (Left <= Right)
            {
                AS = 0; INC = 0; EQ = 0; BS = 0; ADD = 0; SUB = 0; DIV = 0;
                Assignment++; BiggerSmaller++; Addition++; Division++;
                var Watch = new Stopwatch();
                Watch.Start();
                Middle = (Left + Right) / 2;
                IsEqual++;
                if (Vector[Middle] == Number) { return true; }
                else if (Vector[Middle] > Number) { BiggerSmaller++; Assignment++; Subtraction++; Right = Middle - 1;
                    Watch.Stop();
                    ElapsedTime += ((1000.0 * Watch.ElapsedTicks) / Stopwatch.Frequency);
                    AS += Assignment; EQ += IsEqual; INC += Increment; BS += BiggerSmaller; ADD += Addition; SUB += Subtraction; DIV += Division;
                    OperationCounter += AS + EQ + INC + BS + ADD + SUB + DIV;
                    Console.WriteLine("\t\t\t\t\t\t" + OperationCounter + " \t\t\t" + ElapsedTime.ToString("F7"));
                }
                else { Assignment++; Addition++; Left = Middle + 1;
                    Watch.Stop();
                    ElapsedTime += ((1000.0 * Watch.ElapsedTicks) / Stopwatch.Frequency);
                    AS += Assignment; EQ += IsEqual; INC += Increment; BS += BiggerSmaller; ADD += Addition; SUB += Subtraction; DIV += Division;
                    OperationCounter += AS + EQ + INC + BS + ADD + SUB + DIV;
                    Console.WriteLine("\t\t\t\t\t\t" + OperationCounter + " \t\t\t" + ElapsedTime.ToString("F7"));
                }                
            }
            Console.WriteLine("\n\t\t\t\t\t\tŚrednia ilość operacji wyszukiwania: " + Convert.ToDouble((OperationCounter / Vector.Length)));
            return false;
        }
        public static bool LinearSearch(int[] Vector, int Number)
        {
            double ElapsedTime = 0;
            double OperationCounter = 0;
            Assignment = 1;
            Console.WriteLine("\t\t\t\t\t\tIndeks \t\t\tIlość \t\t\tt[ms]");
            Console.WriteLine("\t\t\t\t\t\ttablicy\t\t\toperacji \t\t\n");
            for (int i = 0; i < Vector.Length; i++, Increment++)
            {
                AS = 0; EQ = 0; INC = 0; BS = 0;
                var Watch = new Stopwatch();
                Watch.Start();
                BiggerSmaller++;
                IsEqual++;               
                if (Vector[i] == Number) { return true; }
                Watch.Stop();
                ElapsedTime += ((1000.0 * Watch.ElapsedTicks) / Stopwatch.Frequency);
                AS += Assignment; EQ += IsEqual; INC += Increment; BS += BiggerSmaller;
                OperationCounter += AS + EQ + INC + BS;
                if (i % 10 == 0 || i == 0) { Console.WriteLine("\t\t\t\t\t\t" + i + " \t\t\t" + OperationCounter + " \t\t\t" + ElapsedTime.ToString("F7")); }
            }
            Console.WriteLine("\n\t\t\t\t\t\tŚrednia ilość operacji wyszukiwania: " + Convert.ToDouble((OperationCounter / Vector.Length)));
            return false;
        }
    }
}
