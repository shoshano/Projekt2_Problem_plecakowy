using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("MSTest_problem_plecakowy"), InternalsVisibleTo("GUI_Problem_plecakowy")] 

namespace Projekt2_Problem_plecakowy
{
    internal class Problem
    {
        int number_of_items;    // liczba możliwych przedmiotów
        int seed;
        public List<Item> items;



        // konstruktor 
        public Problem(int nr, int s)
        {
            number_of_items = nr;
            seed = s;
            items = new List<Item>();
            Random random = new Random(seed);
            FillandSortList(this.number_of_items, random);
        }

        public void FillandSortList( int nr, Random random)
        {
            
            for (int i = 0; i < nr; i++)
            {
                int w = random.Next(1, 10);
                int v = random.Next(1, 10);
                Item item = new Item(i, v, w);
                items.Add(item);
            }
            items = items.OrderByDescending(item => item.Ratio).ToList();
            
        }

        public string PrintList()
        {
            string str = "";
            List<Item> it = items.OrderBy(item => item.ID).ToList();
            foreach (Item item in it) 
            {
                str += item.ToString();
            }
            return str;
        }


        public Result Solve(int capacity)
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
            Console.WriteLine(result.ToString());
            return result;
        }

        
    }
}
