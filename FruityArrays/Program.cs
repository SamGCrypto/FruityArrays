using System;
using System.Threading;
using System.Linq;

namespace FruityArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] theFruityGoodness = new string[3];
            theFruityGoodness = GetFruit();
            DisplayFruit(theFruityGoodness);
        }

        private static string[] GetFruit()
        {
            string[] fruitySelected = new string[3];
            Console.WriteLine("Hello there, pleasure for you to select this app.");
            Console.WriteLine("If you could, I would like to know three fruits of yours.");
            for (int i = 0; i < fruitySelected.Length; i++)
            {
                Console.WriteLine($"Fruit number {i + 1}: ");
                fruitySelected[i] = Console.ReadLine(); 
            }
            Console.WriteLine("Let us display all the fruits you put in.");
            Console.WriteLine("Here are the fruits you selected.");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Fruit number {i + 1}: {fruitySelected[i]}");
            }
            int fruitNumber=1;
            foreach(string fruit in fruitySelected)
            {
                Console.WriteLine($"Fruit number{fruitNumber++}: {fruit}");
            }
            Console.WriteLine("Please press a button to continue.");
            Console.ReadLine();
            Console.Clear();
            return fruitySelected;
        }

        private static void DisplayFruit(string[] fruityArrays)
        {
            Console.WriteLine("Here are the fruits you selected.");
            for (int i = 0; i < fruityArrays.Length; i++)
            {
                Console.WriteLine($"{ fruityArrays[i]} is the fruit in the {i+1}");
            }
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}