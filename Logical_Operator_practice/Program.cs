﻿using System;
using System.Threading;

namespace Logical_Operator_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool locomotiveissteam = false;
            bool locomotiveissteam1 = true;

            Console.WriteLine((locomotiveissteam1 && locomotiveissteam));
            Console.WriteLine(locomotiveissteam1 = !locomotiveissteam);
            Console.WriteLine(locomotiveissteam || locomotiveissteam1);
            Console.WriteLine(locomotiveissteam1 || locomotiveissteam);
            Console.WriteLine(locomotiveissteam1 || locomotiveissteam1);
            Console.WriteLine(locomotiveissteam || locomotiveissteam);

            Console.WriteLine("locomotive is steam powered = " + locomotiveissteam);
            Console.WriteLine("Locomotive is steam powered.. with NOT operator = " + !locomotiveissteam);
            Console.WriteLine("Locmotive is NOT steam powered = " + locomotiveissteam1);
            Console.WriteLine("Locomotive is NOT steam powered.. with NOT operator = " + !locomotiveissteam1);
           

            bool automobileisamerican = true;
            bool automobileisimported = false;


            Console.WriteLine(automobileisamerican && automobileisimported);
            Console.WriteLine(automobileisimported = !automobileisamerican);
            Console.WriteLine(automobileisamerican != automobileisimported);

            if (automobileisamerican == true)
            {
                Console.WriteLine("That is certainly a America First Car Son!");
            }

            else
            {
                Console.WriteLine("That is a imported car, give our workers a chance!");
            }
            Console.ReadKey();




          
            

        
        }
    }
}
