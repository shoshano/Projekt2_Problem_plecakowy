using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Problem_plecakowy
{
    internal class Item
    {
        int value;      // wartosc przedmiotu 
        int weight;   // waga przedmiotu 
        int ratio;      // przypisany numer

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public int Ratio
        {
            get { return this.ratio; }
            set { this.ratio = value; }
        }

        public Item(int value, int weight)
        {
            this.value = value;
            this.weight = weight;
            this.ratio = value/weight;
        }
        public override string ToString()
        {
            return "Value: " + Convert.ToString(value) + " Weight: " + Convert.ToString(weight) + " Ratio: " + Convert.ToString(ratio) + "\n";
        }

    }
}
