using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Timers;

namespace C__Coding
{
    #region Question 1
    //Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in variable of type object. Print it.

    //class Book
    //{
    //    public string Title { get; set; }
    //    public int Pages { get; set; }
    //    public Book (string title, int pages)
    //    {
    //        Title = title;
    //        Pages = pages;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Title: {Title}, Pages: {Pages}";
    //    }
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Book book1 = new Book("Route Book", 1010);
    //            Console.WriteLine(book1.ToString());
    //        }
    //    }


    //}
    #endregion

    #region Question 2 
    //Q02.  Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

    //class Book
    //{
    //    public string Title { get; set; }
    //    public int Pages { get; set; }
    //    public Book(string title, int pages)
    //    {
    //        Title = title;
    //        Pages = pages;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Title: {Title}, Pages: {Pages}";
    //    }
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Book book1 = new Book("Route Book", 1010);
    //            Console.WriteLine(book1.ToString());
    //            Console.WriteLine(book1.Equals(book1));
    //            Console.WriteLine(book1.GetHashCode());
    //            Console.WriteLine(book1.GetType());
    //        }
    //    }
    //}
    #endregion

    #region Question 2
    //Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it. int pages = "464";
     
    int pages = 464;

    #endregion

}


