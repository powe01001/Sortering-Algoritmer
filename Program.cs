using System;
using System.Diagnostics;

namespace Sorterings_Inlämnings_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch SW = new Stopwatch(); // Huvudprogramet för timer
            SW.Start();
            Random slump = new Random();

            // Tio element array
            int[] Tio = new int[10];
            for (int i = 0; i < Tio.Length; i++)
            {
                Tio[i] = slump.Next(100); // Hur stor värde talen får ha
            }
            //Tio | Bubblesort
            SW.Restart();
            int maxTio = Tio.Length - 1;

            for (int i = 0; i < maxTio; i++)
            {

                int nrLeft = maxTio - i;

                for (int j = 0; j < nrLeft; j++)
                {
                    if (Tio[j] > Tio[j + 1])
                    {
                        int temp = Tio[j];
                        Tio[j] = Tio[j + 1];
                        Tio[j + 1] = temp;
                    }
                }
            }
            // Tio Bubble Sort array klocka
            Console.WriteLine("10 Elements");
            Console.WriteLine("Bubblesort: " + SW.Elapsed.TotalMilliseconds + " Milliseconds ");
            Console.WriteLine(" ");
            // Tio | Selection Sort
            SW.Restart();
            for (int i = 0; i < Tio.Length; i++)
            {
                int min_index = i;
                for (int y = i; y < Tio.Length; y++)
                {
                    if (Tio[min_index] > Tio[y])
                    {
                        min_index = y;
                    }
                }
            }
            // Tio Selection Sort array klocka
            Console.WriteLine("10 Elements");
            Console.WriteLine("Selection Sort: " + SW.Elapsed.TotalMilliseconds + " Milliseconds ");
            Console.WriteLine(" ");



            // Tusen element array
            int[] Tusen = new int[1000];
            for (int i = 0; i < Tusen.Length; i++)
            {
                Tusen[i] = slump.Next(10000); // Hur stor värde talen får ha
            }
            // Tusen | Bubblesort
            SW.Restart();
            int maxTusen = Tusen.Length - 1;

            for (int i = 0; i < maxTusen; i++)
            {

                int nrLeft = maxTusen - i;

                for (int j = 0; j < nrLeft; j++)
                {
                    if (Tusen[j] > Tusen[j + 1])
                    {
                        int temp = Tusen[j];
                        Tusen[j] = Tusen[j + 1];
                        Tusen[j + 1] = temp;
                    }
                }
            }
            // Tusen array klocka
            Console.WriteLine("1000 Elements");
            Console.WriteLine("Bubblesort: " + SW.Elapsed.TotalMilliseconds + " Milliseconds ");
            Console.WriteLine(" ");
            // Tusen | Selection Sort
            SW.Restart();
            for (int i = 0; i < Tusen.Length; i++)
            {
                int min_index = i;
                for (int y = i; y < Tusen.Length; y++)
                {
                    if (Tusen[min_index] > Tusen[y])
                    {
                        min_index = y;
                    }
                }
            }
            // Tusen Selection Sort array klocka
            Console.WriteLine("1000 Elements");
            Console.WriteLine("Selection Sort: " + SW.Elapsed.TotalMilliseconds + " Milliseconds ");
            Console.WriteLine(" ");



            // Miljon element array
            int[] Miljon = new int[100000];
            for (int i = 0; i < Miljon.Length; i++)
            {
                Miljon[i] = slump.Next(1000000); // Hur stor värde talen får ha
            }
            // Miljon | Bubblesort
            SW.Restart();
            int maxMiljon = Miljon.Length - 1;

            for (int i = 0; i < maxMiljon; i++)
            {

                int nrLeft = maxMiljon - i;

                for (int j = 0; j < nrLeft; j++)
                {
                    if (Miljon[j] > Miljon[j + 1])
                    {
                        int temp = Miljon[j];
                        Miljon[j] = Miljon[j + 1];
                        Miljon[j + 1] = temp;
                    }
                }
            }
            // Miljon array klocka
            Console.WriteLine("100 000 Elements");
            Console.WriteLine("Bubblesort: " + SW.Elapsed.TotalMilliseconds + " Milliseconds ");
            Console.WriteLine(" ");
            // Miljon | Selection Sort
            SW.Restart();
            for (int i = 0; i < Miljon.Length; i++)
            {
                int min_index = i;
                for (int y = i; y < Miljon.Length; y++)
                {
                    if (Miljon[min_index] > Miljon[y])
                    {
                        min_index = y;
                    }
                }
            }
            // Miljon Selection Sort array klocka
            Console.WriteLine("100 000 Elements");
            Console.WriteLine("Selection Sort: " + SW.Elapsed.TotalMilliseconds + " Milliseconds ");
            Console.WriteLine(" ");

            SW.Stop();
            Console.WriteLine("Done!");
        }
    }
}
