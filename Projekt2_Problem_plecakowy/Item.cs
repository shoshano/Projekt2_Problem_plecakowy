using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Problem_plecakowy
{
    internal class Item
    {
        int id;
        int value;      // wartosc przedmiotu 
        int weight;   // waga przedmiotu 
        double ratio;      // przypisany numer

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

        public double Ratio
        {
            get { return this.ratio; }
            set { this.ratio = value; }
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value;}
        }


        public Item(int id ,int value, int weight)
        {
            this.id = id;
            this.value = value;
            this.weight = weight;
            this.ratio = (double)value/weight;
        }
        public override string ToString()
        {
            return "ID " + ID + " Value: " + Convert.ToString(value) + " Weight: " + Convert.ToString(weight) + " Ratio: " + Convert.ToString(ratio) + "\n";
        }

    }
}
