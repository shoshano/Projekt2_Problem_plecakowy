using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Problem_plecakowy
{
    internal class Problem
    {
        int number_of_items;    // liczba możliwych przedmiotów
        int seed;
        List<Item> items = new List<Item>();


        // konstruktor 
        public Problem(int nr, int s)
        {
            number_of_items = nr;
            seed = s;
            FillandSortList(this.number_of_items, this.seed);
        }

        public void FillandSortList( int nr, int s)
        {
            Random random = new Random();
            for (int i = 0; i < nr; i++)
            {
                int w = random.Next(1, 30);
                int v = random.Next(100);
                Item item = new Item(v, w);
                items.Add(item);
            }
            items = items.OrderByDescending(item => item.Ratio).ToList();
            //PrintList(items);
        }

        public void PrintList(List<Item> list)
        {
            foreach(Item item in list)
            {
                Console.WriteLine(item.Ratio);
            }   
            Console.WriteLine("+++++++++++++++");
        }

        

        public string Solve(int capacity)
        {
            Result result = new Result(0 , 0);
            result.Results = new List<Item>();

            foreach (Item item in items)
            {
                if (item.Weight <= capacity)
                {
                    result.Results.Add(item);
                    result.Total_weight += item.Weight;
                    result.Total_value += item.Value;
                    capacity -= item.Weight;
                }
                
            }
            //PrintList(result.Results);
            return result.ToString();
        }
    }
}
