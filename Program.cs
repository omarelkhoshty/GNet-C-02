using System.ComponentModel;
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

    #region Question 3
    //Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it. int pages = "464";

    //int pages = 464; /// i solved it by removing the quotes from 464 and making it an integer instead of a string ///

    #endregion

    #region Question 4
    //Q04.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
    //internal class  program
    //{
    //   static void Main(string[] args)
    //    {
    //        int num01 = 10;
    //        int num02 = 0;
    //        try
    //        {
    //            int result = num01 / num02;
    //        }
    //        catch (DivideByZeroException)
    //        {
    //            Console.WriteLine("Cannot divide by zero");
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Done");
    //        }
    //    }
    //}

    #endregion

    #region Question 5
    ////Q05.  Declare an int pages = 300; then store it in a double variable without using a cast.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int pages = 300;
    //        double pagesDouble = pages;
    //        Console.WriteLine(pagesDouble);
    //    }
    //}
    #endregion

    #region Question 6
    //Q06.  Declare a double price = 49.99; then convert it into an int using a cast.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double price = 49.99;
    //        int priceInt = (int)price;
    //        Console.WriteLine(priceInt);
    //    }
    //}
    #endregion

    #region Question 7
    //Q07.  Given string pagesText = "464";, convert it into an int using the Convert class.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string pagesText = "464";
    //        int pagesInt = Convert.ToInt32(pagesText);
    //        Console.WriteLine(pagesInt);
    //    }
    //}
    #endregion

    #region Question 8
    //Q08.Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
    internal class program
    {
        static void Main(string[] args)
        {
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            if (int.TryParse(badText, out int badNumber)) // i don't know what is out parameter but i think it is used to return a value from the method , code didn't work without it so i added it and it worked 
            {
                Console.WriteLine(badNumber);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
    #endregion
}