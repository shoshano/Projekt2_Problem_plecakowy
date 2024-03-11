using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Problem_plecakowy
{
    internal class Result
    {
        int total_weight;
        int total_value;

        List<Item> results = new List<Item>();

        public int Total_weight
        {  
            get { return total_weight; }
            set { total_weight = value; } 
        }

        public int Total_value
        {
            get { return total_value; }
            set { total_value = value; }
        
        }

        public List<Item> Results
        { 
            get { return results; }
            set {  results = value; }
        }

        public Result(int tw, int tv)
        {
            total_value = tv;
            total_weight = tw;
        
        }

        public override string ToString()
        {
            string str = "Items in backpack: \n";
            foreach(Item item in results)
            {
                str += item.ToString();
            }
            str += "\n" + "Total waight: " + Convert.ToString(total_weight) + "\nTotal value: " + Convert.ToString(total_value);
            return str;
        }
    }
}
