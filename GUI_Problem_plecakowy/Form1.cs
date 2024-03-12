using Projekt2_Problem_plecakowy;
using System.Web;
namespace GUI_Problem_plecakowy
{
    public partial class Form1 : Form
    {
        bool correct_nr = false;
        bool correct_seed = false;
        bool correct_capacity = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_number_of_items_TextChanged(object sender, EventArgs e)
        {
            string str = textBox_number_of_items.Text;
            int numericValue;
            bool isNumber = int.TryParse(str, out numericValue);
            if (isNumber)
            {
                textBox_number_of_items.BackColor = Color.LimeGreen;
                correct_nr = true;
                if (numericValue < 0)
                {
                    textBox_number_of_items.BackColor = Color.IndianRed;
                    correct_nr = false;
                }
            }
            else if (str == "") 
            {
                textBox_number_of_items.BackColor = Color.White;
                correct_nr = false;
            }
            else
            {
                textBox_number_of_items.BackColor = Color.IndianRed;
                correct_nr = false;
            }
        }

        private void textBox_seed_TextChanged(object sender, EventArgs e)
        {
            string str = textBox_seed.Text;
            int numericValue;
            bool isNumber = int.TryParse(str, out numericValue);
            if (isNumber)
            {
                textBox_seed.BackColor = Color.LimeGreen;
                correct_seed = true;
                if (numericValue < 0)
                {
                    textBox_seed.BackColor = Color.IndianRed;
                    correct_nr = false;
                }
            }
            else if (str == "")
            {
                textBox_seed.BackColor = Color.White;
                correct_seed = false;
            }
            else
            {
                textBox_seed.BackColor = Color.IndianRed;
                correct_seed = false;
            }
        }

        private void textBox_capacity_TextChanged(object sender, EventArgs e)
        {
            string str = textBox_capacity.Text;
            int numericValue;
            bool isNumber = int.TryParse(str, out numericValue);
            if (isNumber)
            {
                textBox_capacity.BackColor = Color.LimeGreen;
                correct_capacity = true;
                if (numericValue < 0)
                {
                    textBox_capacity.BackColor = Color.IndianRed;
                    correct_nr = false;
                }
            }
            else if (str == "")
            {
                textBox_capacity.BackColor = Color.White;
                correct_capacity = false;
            }
            else
            {
                textBox_capacity.BackColor = Color.IndianRed;
                correct_capacity = false;
            }
        }

        private void buttom_start_Click(object sender, EventArgs e)
        {
            if (correct_nr && correct_seed && correct_capacity)
            {
                int nr = int.Parse(textBox_number_of_items.Text);
                int s = int.Parse(textBox_seed.Text);
                int c = int.Parse(textBox_capacity.Text);

                Problem newProblem = new Problem(nr, s);
                textBox_list_of_items.Text = newProblem.PrintList();
                Result newResult = newProblem.Solve(c);

                textBox_items_in_backpack.Text = newResult.ToString();
            }
            else
            {
                textBox_items_in_backpack.Text = "";
                textBox_list_of_items.Text = "Podaj poprawne wartoœci!";
            }
        }
        private void textBox_items_in_backpack_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
