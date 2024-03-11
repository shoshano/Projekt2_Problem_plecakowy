using Projekt2_Problem_plecakowy;
namespace MSTest_problem_plecakowy
{
    [TestClass]
    public class UnitTest1
    {
        /*Sprawdzenie czy w rzeczywistoœci wewn¹trz obiektu dodaje siê podana liczba elementów.*/

        [TestMethod]
        public void CountElements()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Problem problem = new Problem(n, 1);
                Assert.AreEqual(n, problem.items.Count);
            }

        }

        /*Sprawdzenie, czy jeœli co najmniej jeden przedmiot spe³nia ograniczenia, to zwrócono co najmniej jeden element.*/

        [TestMethod]
        public void CheckIfItemIsInBackpack()
        {
            List<int> weights = new List<int>() { 12, 22, 33, 6, 58, 31, 110};
            List<int> values = new List<int>() { 10, 15, 28, 9, 8, 34, 9};
            List<Item> items = new List<Item>();
            for (int i = 0; i < weights.Count; i++)
            {
                Item test = new Item(i, values[i], weights[i]);
                items.Add(test);
            }
            items = items.OrderByDescending(item => item.Ratio).ToList();

            Problem problem = new Problem(7, 1);
            problem.items = items;
            
            Result result = problem.Solve(10);

            Assert.AreEqual(1, result.Results.Count);
        }
        
        /*Sprawdzenie, czy jeœli ¿aden przedmiot nie spe³nia ograniczeñ, to zwrócono puste rozwi¹zanie.*/

        [TestMethod]
        public void IfNonItemIsCorrect()
        {
            List<int> weights = new List<int>() { 12, 22, 33, 60, 58, 31, 110 };
            List<int> values = new List<int>() { 10, 15, 28, 9, 8, 34, 9 };
            List<Item> items = new List<Item>();
            for (int i = 0; i < weights.Count; i++)
            {
                Item test = new Item(i, values[i], weights[i]);
                items.Add(test);
            }
            items = items.OrderByDescending(item => item.Ratio).ToList();

            Problem problem = new Problem(7, 1);
            problem.items = items;

            Result result = problem.Solve(10);

            Assert.AreEqual(0, result.Results.Count);
        }

        /*Sprawdzenie, czy kolejnoœæ przedmiotów ma wp³ywa na znalezione rozwi¹zanie.*/

        [TestMethod]
        public void IfOrderMeans()
        {
            List<int> weights1 = new List<int>() { 12, 22, 33, 60, 58, 31, 110 };
            List<int> values1 = new List<int>() { 10, 15, 28, 9, 8, 34, 9 };
            List<Item> items1 = new List<Item>();
            for (int i = 0; i < weights1.Count; i++)
            {
                Item test1 = new Item(i, values1[i], weights1[i]);
                items1.Add(test1);
            }
            items1 = items1.OrderByDescending(item => item.Ratio).ToList();

            Problem problem1 = new Problem(7, 1);
            problem1.items = items1;

            Result result1 = problem1.Solve(100);

            List<int> weights2 = new List<int>() { 110, 60, 12, 33, 22, 31, 58 };
            List<int> values2 = new List<int>() { 9, 9, 10, 28, 15, 34, 8 };
            List<Item> items2 = new List<Item>();
            for (int i = 0; i < weights2.Count; i++)
            {
                Item test2 = new Item(i, values2[i], weights2[i]);
                items2.Add(test2);
            }
            items2 = items2.OrderByDescending(item => item.Ratio).ToList();

            Problem problem2 = new Problem(7, 1);
            problem2.items = items2;

            Result result2 = problem2.Solve(100);

            bool b = true;
            for(int i = 0; i < result1.Results.Count; i++)
            {
                if (result1.Results[i].Weight != result2.Results[i].Weight)
                {
                    b = false;
                }
            }


            Assert.IsTrue(b);
        }

        /*Sprawdzenie poprawnoœci wyniku dla konkretnej instancji.*/

        [TestMethod]
        public void IfInstanceCorrect()
        {
            List<int> weights = new List<int>() { 12, 22, 33, 60, 58, 31, 110 };
            List<int> values = new List<int>() { 10, 15, 28, 9, 8, 34, 9 };
            List<Item> items = new List<Item>();
            List<Item> correct = new List<Item>();
            for (int i = 0; i < weights.Count; i++)
            {
                Item test = new Item(i, values[i], weights[i]);
                items.Add(test);
                if(i < 3 || i==5)
                {
                    correct.Add(test);
                }
            }
            correct = correct.OrderByDescending(x => x.Ratio).ToList();
            items = items.OrderByDescending(item => item.Ratio).ToList();

            Problem problem = new Problem(7, 1);
            problem.items = items;

            Result result = problem.Solve(100);

            bool b = true;
            for (int i = 0; i < correct.Count; i++)
            {
                if (correct[i].ID != result.Results[i].ID)
                {
                    b = false;
                }
            }

            Assert.IsTrue(b);
        }

        /*Sprawdzenie czy jesli nie ma ¿adnych przedmiotów to plecak bêdzie pusty*/

        [TestMethod]
        public void NoItems() 
        {
            Problem problem = new Problem(0, 1);
            Result result = problem.Solve(100);
            Assert.AreEqual(0, result.Results.Count);
        }

        /*Sprawdzenie czy jesli plecak bêdzie mia³ 0 lub ujemna pojemnoœæ to nie wpadnie do niego rzaden przedmiot*/

        [TestMethod]
        public void NoPlaceInBackPack()
        {
            Problem problem1 = new Problem(30, 1);
            Result result1 = problem1.Solve(0);
            Problem problem2 = new Problem(30, 1);
            Result result2 = problem2.Solve(-1);

            Assert.AreEqual(0, result1.Results.Count, result2.Results.Count);
        }

        /*Sprawdzenie czy ratio elementu jest liczone przewid³owo*/

        [TestMethod]
        public void IsRatioCorrect() 
        {
            List<int> weights = new List<int>() { 12, 22, 33, 60, 58, 31, 110 };
            List<int> values = new List<int>() { 10, 15, 28, 9, 8, 34, 9 };
            List<Item> items = new List<Item>();
            for (int i = 0; i < weights.Count; i++)
            {
                Item test = new Item(i, values[i], weights[i]);
                items.Add(test);
            }

            List<double> correctRatio = new List<double>();
            for (int i = 0; i < weights.Count; i++)
            {
                double ratio = (double)items[i].Value/items[i].Weight;
                correctRatio.Add(ratio);
            }

            bool b = true;
            for (int i = 0; i < correctRatio.Count; i++)
            {
                if (correctRatio[i] != items[i].Ratio)
                {
                    b = false;
                }
            }

            Assert.IsTrue(b);

        }
    }
}