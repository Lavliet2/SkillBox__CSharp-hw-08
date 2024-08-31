// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();

        while (true)
        {
            int number;
            bool isOk = false;
            do
            {
                Console.Write("Введите целое число: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out number))
                {
                    isOk = true;                    
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            } while (!isOk);

            if(isOk)
            {
                if ( set.Add(number) ) Console.WriteLine($"Число: {number}  успешно сохранено!");
                else Console.WriteLine($"[Error] - Число: {number} уже вводилось ранее");
            }
        }
    }
}

