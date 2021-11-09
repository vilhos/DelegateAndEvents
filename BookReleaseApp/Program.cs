using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReleaseApp
{
    public delegate void Delegate(string name);
    class PrintHouse
    {
        public event Delegate Notify;

        public void Release(string name)
        {
            Notify?.Invoke($"Released new book: {name}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            PrintHouse book = new PrintHouse();
            book.Notify += BookStore.Info;
            book.Notify += BookApp.Info;
            book.Notify += Handler;
            book.Release("CLR via C#");

            Console.ReadLine();
        }
        static void Handler(string name)
        {
            Console.WriteLine(name);
        }
    }

    class BookStore
    {
        public static string ReleasedBook;

        public static void Info(string name)
        {
            ReleasedBook = name;
        }
    }

    class BookApp
    {
        public static string ReleasedBook;
        public static void Info(string name)
        {
            ReleasedBook = name;
        }
    }
}
