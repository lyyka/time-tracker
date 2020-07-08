using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Classes;
using TimeTracker.Controllers;

namespace EntriesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int input;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU:");
                Console.WriteLine("1. Generate projects");
                Console.WriteLine("2. Generate entries");
                input = Convert.ToInt32(Console.ReadLine());
                if(input > 0)
                {
                    switch (input)
                    {
                        case 1:
                            GenerateProjects();
                            break;
                        case 2:
                            GenerateEntries();
                            break;
                    }
                }
            } while (input > 0);
        }

        static void GenerateProjects()
        {
            Generator e = new Generator();
            Console.Clear();
            Console.WriteLine("How much projects to generate?");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                e.GenerateProjects(n);
            }
        }

        static void GenerateEntries()
        {
            Generator e = new Generator();
            Console.Clear();
            Console.WriteLine("How much entries to generate?");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                e.GenerateEntries(n);
            }
        }
    }
}
