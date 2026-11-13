using System.Runtime.InteropServices;

namespace C__Coding
{
    #region Question 1
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public Book (string title, int pages)
        {
            Title = title;
            Pages = pages;
        }
        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Book book1 = new Book("Route Book", 1010);
                Console.WriteLine(book1.ToString());
            }
        }


    }
    #endregion
}


