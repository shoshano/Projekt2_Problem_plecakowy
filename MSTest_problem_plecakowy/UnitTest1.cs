using Projekt2_Problem_plecakowy;
namespace MSTest_problem_plecakowy
{
    [TestClass]
    public class UnitTest1
    {
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

        //[TestMethod]
        /* public void CheckIfItemIsInBackpack()
         {
             int c = 0;
             int captiviy = 30;
             for(int i = 5; i < 20; i +=5)
             {
                 Problem problem = new Problem(i, 1);
                 problem.Solve(captiviy);
                 if(problem.items.
                 { }
                 Assert.AreEqual(i, problem.items.Count);
             }

         }*/
    }
}