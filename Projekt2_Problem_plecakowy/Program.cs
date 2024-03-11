namespace Projekt2_Problem_plecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe przedmiotów: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ziarno: ");
            int seed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj pojemnosc plecaka: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Problem nowy = new Problem(nr, seed);
            Result r = nowy.Solve(c);
            Console.WriteLine(r.Results[1].Weight);

           
        }
    }
}
