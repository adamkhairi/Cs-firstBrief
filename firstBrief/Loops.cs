﻿using System;

namespace firstBrief
{
    public class Loops
    {
        public static void boucles()
        {
            // II-1
            for (int firstNum = 1; firstNum <= 30; firstNum++)
            {
                int secondNum = 5;

                //Multiple
                int sum = firstNum * secondNum;
                Console.WriteLine("Result of tow first numbers :" + sum);
            }

            // // II-2
            // for (float i = 1; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            //     i += i / 2;
            // }
            //
            // // II-3
            // int g = 1;
            // while (g <= 15)
            // {
            //     Console.WriteLine("On y arrive présque: " + g);
            //     g++;
            // }
            //
            // // II-4
            // for (int i = 20; i >= 0; i--)
            // {
            //     Console.WriteLine("C'est presque " + i);
            // }
            //
            // // II-5
            // for (int a = 1; a <= 100; a += 15)
            // {
            //     Console.WriteLine("On tient le bon bout... " + a);
            // }
            //
            // // II-6
            // for (int i = 100; i >= 1; i -= 15)
            // {
            //     Console.WriteLine("Enfin !!! " + i);
            // }
        }

    }
}