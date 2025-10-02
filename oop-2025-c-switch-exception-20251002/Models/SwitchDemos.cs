using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_c_switch_exception_20251002.Models
{
    internal class SwitchDemos
    {
        public static void PrintTitle()
        {
            Console.WriteLine("Hello, World!");
        }
        public static void MultiBranchIf(int number)
        {
          
            if (number == 1)
                Console.WriteLine("One");
            else if (number == 2)
                Console.WriteLine("Two");
            else if (number == 3)
                Console.WriteLine("Three");
            else if (number == 4)
                Console.WriteLine("Four");
            else if (number == 5)
                Console.WriteLine("Five");
            else if (number == 6)
                Console.WriteLine("Six");
            else if (number == 7)
                Console.WriteLine("Seven");
            else if (number == 8)
                Console.WriteLine("Eight");
            else if (number == 9)
                Console.WriteLine("Nine");
            else if (number == 10)
                Console.WriteLine("Ten");
            else
                Console.WriteLine("Number out of range");
        }   
    
        public static void IsRainbowColor(string color)
        {
            //if (color == "Red" || color == "Orange" || color == "Yellow" || color == "Green" || color == "Blue" || color == "Indigo" || color == "Violet")
            //{
            //    Console.WriteLine($"{color} is a rainbow color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{color} is not a rainbow color.");
            //}
            string normalizedColor = color.Trim().ToLower();
            switch (normalizedColor)
            {
                case "red":
                case "orange":
                case "yellow":
                case "green":
                case "blue":
                case "indigo":
                case "violet":
                    Console.WriteLine($"[{normalizedColor}] is a color in the rainbow.");
                    break;

                default:
                    Console.WriteLine($"[{normalizedColor}] is NOT a color in the rainbow.");
                    break;
            }




        }
        public static void SwitchStatement(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                default:
                    Console.WriteLine("Number out of range");
                    break;
            }
        }

    }
}
