using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\kzyukina\\OneDrive - DAE\\Документы\\06_TEST\\Test.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter sw = new StreamWriter(path, false))
            {

                int[] array = new int[10];
                Random numbers = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = numbers.Next(0, 100);
                    sw.Write("{0} ", array[i]);

                }
            }
            System.Diagnostics.Process.Start("notepad.exe", path);

            using (StreamReader sr = new StreamReader(path))
            {
                string console = sr.ReadLine();

                string[] arrayConsole = console.Split();
                int S = 0;
                int[] intArray = new int[arrayConsole.Length];
                for (int i = 0; i < arrayConsole.Length; i++)
                {
                   if (arrayConsole[i].Length>0)
                    {
                        intArray[i] = Convert.ToInt32(arrayConsole[i]);
                        S += intArray[i];
                    }
                    
                    Console.WriteLine("Сумма чисел = {0}", S);
                    Console.ReadKey();
                }
                Console.WriteLine("Сумма чисел = {0}", S);
                Console.ReadKey();

              
            }

        }
    }  }