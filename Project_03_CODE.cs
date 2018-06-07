using System;
using System.Collections;
using System.Diagnostics;

namespace Projekt_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            double OpElapsedTime = 0;
            int Size = 50000;
            int Tmp;
            bool Check = true;
            Random rnd = new Random();
            char Menu;
            int Bajt = 255;

            while (Check)
            {
                Console.WriteLine("Rodzaj zmiennych do sortowania:\n[1] Byte\n[2] Double\n[3] Integer\n");
                char Menu2 = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (Menu2)
                {
                    case '1':
                        #region Wartości BYTE
                        Console.WriteLine("Wybierz metodę sortowania:\n\n[1] Insertion Sort\n[2] Selecion Sort\n[3] Heap Sort\n[4] Cocktail Sort\n[5] QuickSort (rekurencyjnie)\n[6] QuickSort (iteracyjnie)");
                        Menu = Console.ReadKey().KeyChar;
                        Console.Clear();

                        switch (Menu)
                        {
                            case '1':
                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Rosnaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.Next(0, 255); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Malejaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.Next(0, 255); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Losowa = new int[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.Next(0, 255); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] V = new int[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.Next(0, 255); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = Tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Stala = new int[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 255; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '2':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Rosnaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.Next(0, 255); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Malejaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.Next(0, 255); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Losowa = new int[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.Next(0, 255); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] V = new int[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.Next(0, 255); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = Tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Stala = new int[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 255; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '3':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Rosnaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.Next(0, 255); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Malejaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.Next(0, 255); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Losowa = new int[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.Next(0, 255); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] V = new int[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.Next(0, 255); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = Tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Stala = new int[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 255; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '4':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Rosnaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.Next(0, 255); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Malejaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.Next(0, 255); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Losowa = new int[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.Next(0, 255); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] V = new int[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.Next(0, 255); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = Tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Stala = new int[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 255; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '5':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY A-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] A = new int[Size];
                                    for (int j = 0; j < Size; j++) { A[j] = rnd.Next(0, 255); }
                                    Array.Sort(A);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = A[k];
                                        A[k] = A[k + 1];
                                        A[k + 1] = Tmp;
                                    }
                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    quickSortRecursive(A, 0, Size - 1);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '6':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY A-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] A = new int[Size];
                                    for (int j = 0; j < Size; j++) { A[j] = rnd.Next(0, 255); }
                                    Array.Sort(A);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = A[k];
                                        A[k] = A[k + 1];
                                        A[k + 1] = Tmp;
                                    }
                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    quickSortIterative(A);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;
                        }
                        break;
                    #endregion
                    case '2':
                        #region Wartości DOUBLE
                        Console.WriteLine("Wybierz metodę sortowania:\n\n[1] Insertion Sort\n[2] Selecion Sort\n[3] Heap Sort\n[4] Cocktail Sort\n[5] QuickSort (rekurencyjnie)\n[6] QuickSort (iteracyjnie)");
                        Menu = Console.ReadKey().KeyChar;
                        Console.Clear();

                        switch (Menu)
                        {
                            case '1':
                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Rosnaca = new double[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSortDBL(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Malejaca = new double[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSortDBL(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Losowa = new double[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSortDBL(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] V = new double[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        double tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSortDBL(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Stala = new double[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 1.2; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSortDBL(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '2':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Rosnaca = new double[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSortDBL(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Malejaca = new double[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSortDBL(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Losowa = new double[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSortDBL(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] V = new double[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        double tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSortDBL(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Stala = new double[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 1.2; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSortDBL(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '3':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Rosnaca = new double[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSortDBL(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Malejaca = new double[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSortDBL(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Losowa = new double[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSortDBL(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] V = new double[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        double tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSortDBL(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Stala = new double[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 1.2; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSortDBL(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '4':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Rosnaca = new double[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSortDBL(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Malejaca = new double[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSortDBL(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Losowa = new double[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSortDBL(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] V = new double[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.NextDouble() * ((10.0 + 10.0) - 10.0); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        double tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSortDBL(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] Stala = new double[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 1.2; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSortDBL(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '5':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY A-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] A = new double[Size];
                                    for (int j = 0; j < Size; j++) { A[j] = j + 1; }
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        double tmp = A[k];
                                        A[k] = A[k + 1];
                                        A[k + 1] = tmp;
                                    }
                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    quickSortRecursiveDBL(A, 0, Size - 1);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '6':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY A-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    double[] A = new double[Size];
                                    for (int j = 0; j < Size; j++) { A[j] = j + 1; }
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        double tmp = A[k];
                                        A[k] = A[k + 1];
                                        A[k + 1] = tmp;
                                    }
                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    quickSortIterativeDBL(A);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            default: break;
                        }
                        break;
                    #endregion
                    case '3':
                        #region Wartości INT
                        Console.WriteLine("Wybierz metodę sortowania:\n\n[1] Insertion Sort\n[2] Selecion Sort\n[3] Heap Sort\n[4] Cocktail Sort\n[5] QuickSort (rekurencyjnie)\n[6] QuickSort (iteracyjnie)");
                        Menu = Console.ReadKey().KeyChar;
                        Console.Clear();

                        switch (Menu)
                        {
                            case '1':
                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Rosnaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Malejaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Losowa = new int[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.Next(-100000, 100000); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] V = new int[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = Tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Stala = new int[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 1; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    insertionSort(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '2':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Rosnaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Malejaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Losowa = new int[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.Next(-100000, 100000); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] V = new int[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = Tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Stala = new int[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 1; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    selectionSort(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '3':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Rosnaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Malejaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Losowa = new int[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.Next(-100000, 100000); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] V = new int[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = Tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Stala = new int[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 1; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    heapSort(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '4':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY ROSNĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Rosnaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Rosnaca[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(Rosnaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(Rosnaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY MALEJĄCEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Malejaca = new int[Size];
                                    for (int j = 0; j < Size; j++) { Malejaca[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(Malejaca);
                                    Array.Reverse(Malejaca);

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(Malejaca);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY LOSOWEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Losowa = new int[Size];
                                    for (int j = 0; j < Size; j++) { Losowa[j] = rnd.Next(-100000, 100000); }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(Losowa);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY V-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] V = new int[Size];
                                    for (int j = 0; j < Size; j++) { V[j] = rnd.Next(-100000, 100000); }
                                    Array.Sort(V);
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = V[k + 1];
                                        V[k + 1] = V[k];
                                        V[k] = Tmp;
                                    }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(V);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Size = 50000;

                                Console.WriteLine("\t\t\nCZAS DLA TABLICY STAŁEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] Stala = new int[Size];
                                    for (int j = 0; j < Size; j++) { Stala[j] = 1; }

                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    cocktailSort(Stala);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '5':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY A-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] A = new int[Size];
                                    for (int j = 0; j < Size; j++) { A[j] = j + 1; }
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = A[k];
                                        A[k] = A[k + 1];
                                        A[k + 1] = Tmp;
                                    }
                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    quickSortRecursive(A, 0, Size - 1);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            case '6':

                                Check = false;
                                Console.WriteLine("\t\tCZAS DLA TABLICY A-KSZTAŁTNEJ\n");
                                for (int i = 0; i < 15; i++, Size += 10000)
                                {
                                    OpElapsedTime = 0;
                                    int[] A = new int[Size];
                                    for (int j = 0; j < Size; j++) { A[j] = j + 1; }
                                    for (int k = 0; k < Size - 1; k += 2)
                                    {
                                        Tmp = A[k];
                                        A[k] = A[k + 1];
                                        A[k + 1] = Tmp;
                                    }
                                    var Timer = new Stopwatch();
                                    Timer.Start();
                                    quickSortIterative(A);
                                    Timer.Stop();
                                    OpElapsedTime += ((1.0 * Timer.ElapsedTicks) / Stopwatch.Frequency);
                                    Console.WriteLine(Size + " elementów: " + OpElapsedTime.ToString("F5") + " [s]");
                                }
                                Console.ReadKey();
                                break;

                            default: break;
                        }
                        break;
                    #endregion
                    default: break;
                }
            }
        }
        #region Metody sortowania dla INT oraz BYTE
        public static int[] insertionSort(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                    if (tab[j - 1] > tab[j])
                    {
                        int temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
            return tab;
        }
        public static int[] selectionSort(int[] tab)
        {
            int pos_min, temp;

            for (int i = 0; i < tab.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < tab.Length; j++)
                    if (tab[j] < tab[pos_min]) { pos_min = j; }

                if (pos_min != i)
                {
                    temp = tab[i];
                    tab[i] = tab[pos_min];
                    tab[pos_min] = temp;
                }
            }
            return tab;
        }
        public static int[] heapSort(int[] tab)
        {
            int heapSize = tab.Length;

            for (int p = (heapSize - 1) / 2; p >= 0; --p) { maxHeapify(ref tab, heapSize, p); }

            for (int i = tab.Length - 1; i > 0; --i)
            {
                int temp = tab[i];
                tab[i] = tab[0];
                tab[0] = temp;

                --heapSize;
                maxHeapify(ref tab, heapSize, 0);
            }
            return tab;
        }
        private static void maxHeapify(ref int[] tab, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && tab[left] > tab[index]) { largest = left; }
            else { largest = index; }

            if (right < heapSize && tab[right] > tab[largest]) { largest = right; }

            if (largest != index)
            {
                int temp = tab[index];
                tab[index] = tab[largest];
                tab[largest] = temp;

                maxHeapify(ref tab, heapSize, largest);
            }
        }
        public static int[] cocktailSort(int[] tab)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i <= tab.Length - 2; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) { break; }

                swapped = false;
                for (int i = tab.Length - 2; i >= 0; i--)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            return tab;
        }
        public static void quickSortIterative(int[] t)
        {
            int i, j, l, p, sp;
            int[] stos_l = new int[t.Length],
            stos_p = new int[t.Length];
            sp = 0; stos_l[sp] = 0; stos_p[sp] = t.Length - 1;
            do
            {
                l = stos_l[sp];
                p = stos_p[sp];
                sp--;
                do
                {
                    int x;
                    i = l; j = p; x = t[(l + p) / 2];
                    do
                    {
                        while (t[i] < x) i++;
                        while (x < t[j]) j--;
                        if (i <= j)
                        {
                            int buf = t[i]; t[i] = t[j]; t[j] = buf;
                            i++; j--;
                        }
                    } while (i <= j);
                    if (i < p) { sp++; stos_l[sp] = i; stos_p[sp] = p; }
                    p = j;
                } while (l < p);
            } while (sp >= 0);
        }
        public static void quickSortRecursive(int[] t, int l, int p)
        {
            int i, j, x;
            i = l;
            j = p;
            x = t[(l + p) / 2];
            do
            {
                while (t[i] < x) { i++; }
                while (x < t[j]) { j--; }
                if (i <= j)
                {
                    int buf = t[i];
                    t[i] = t[j];
                    t[j] = buf;
                    i++; j--;
                }
            }
            while (i <= j);
            if (l < j) quickSortRecursive(t, l, j);
            if (i < p) quickSortRecursive(t, i, p);
        }
        #endregion
        #region Metody sortowania dla DOUBLE
        public static double[] insertionSortDBL(double[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                    if (tab[j - 1] > tab[j])
                    {
                        double temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
            return tab;
        }
        public static double[] selectionSortDBL(double[] tab)
        {
            int pos_min;
            double temp;

            for (int i = 0; i < tab.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < tab.Length; j++)
                    if (tab[j] < tab[pos_min]) { pos_min = j; }

                if (pos_min != i)
                {
                    temp = tab[i];
                    tab[i] = tab[pos_min];
                    tab[pos_min] = temp;
                }
            }
            return tab;
        }
        public static double[] heapSortDBL(double[] tab)
        {
            int heapSize = tab.Length;

            for (int p = (heapSize - 1) / 2; p >= 0; --p) { maxHeapifyDBL(ref tab, heapSize, p); }

            for (int i = tab.Length - 1; i > 0; --i)
            {
                double temp = tab[i];
                tab[i] = tab[0];
                tab[0] = temp;

                --heapSize;
                maxHeapifyDBL(ref tab, heapSize, 0);
            }
            return tab;
        }
        private static void maxHeapifyDBL(ref double[] tab, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && tab[left] > tab[index]) { largest = left; }
            else { largest = index; }

            if (right < heapSize && tab[right] > tab[largest]) { largest = right; }

            if (largest != index)
            {
                double temp = tab[index];
                tab[index] = tab[largest];
                tab[largest] = temp;

                maxHeapifyDBL(ref tab, heapSize, largest);
            }
        }
        public static double[] cocktailSortDBL(double[] tab)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i <= tab.Length - 2; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        double temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) { break; }

                swapped = false;
                for (int i = tab.Length - 2; i >= 0; i--)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        double temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            return tab;
        }
        public static void quickSortIterativeDBL(double[] t)
        {
            int i, j, sp;
            int l, p;
            int[] stos_l = new int[t.Length],
            stos_p = new int[t.Length];
            sp = 0; stos_l[sp] = 0; stos_p[sp] = t.Length - 1;
            do
            {
                l = stos_l[sp];
                p = stos_p[sp];
                sp--;
                do
                {
                    int x;
                    i = l; j = p; x = Convert.ToInt32(t[(l + p) / 2]);
                    do
                    {
                        while (t[i] < x) i++;
                        while (x < t[j]) j--;
                        if (i <= j)
                        {
                            int buf = Convert.ToInt32(t[i]); t[i] = t[j]; t[j] = buf;
                            i++; j--;
                        }
                    } while (i <= j);
                    if (i < p) { sp++; stos_l[sp] = i; stos_p[sp] = p; }
                    p = j;
                } while (l < p);
            } while (sp >= 0);
        }
        public static void quickSortRecursiveDBL(double[] t, int l, int p)
        {
            int i, j, x;
            i = l;
            j = p;
            x = Convert.ToInt32(t[(l + p) / 2]);
            do
            {
                while (t[i] < x) { i++; }
                while (x < t[j]) { j--; }
                if (i <= j)
                {
                    double buf = t[i];
                    t[i] = t[j];
                    t[j] = buf;
                    i++; j--;
                }
            }
            while (i <= j);
            if (l < j) quickSortRecursiveDBL(t, l, j);
            if (i < p) quickSortRecursiveDBL(t, i, p);
        }
        #endregion
    }
}

