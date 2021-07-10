using System; //namespace
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Great Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();
            
            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!"); //console is a type of the system namespace
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
