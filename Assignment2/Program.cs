using System.Security.Cryptography;

namespace Assignment2
{
    #region Question 1 
    //Q01: Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
         internal class Program
         {
             static void Main(string[] args)
             {
                string title = "clean code";
                string upperTitle = title.ToUpper();
                Console.WriteLine("Original title: " + title);
                Console.WriteLine("Uppercase title: " + upperTitle);
             }
         }
    #endregion

}
