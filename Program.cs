using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic Explanations / Samples
            GenericExplanation();

            Console.ReadKey();
        }
        public static void GenericExplanation()
        {
            Book book = new Book { BookId = 1, BookName = "C#Book", AuthorName = "C#Author" };

            //var bookList = new BookList();
            //bookList.Add(book);

            //// If we use the object class will cause us BOXING and UNBOXING performance penalty
            ///-----------------------------------------------------------------------------------
            //var objectList = new ObjectList();
            //objectList.Add(book);

            //// From Add method intellisense we clearly see that the ADD method is of type INT we declared above
            //////-----------------------------------------------------------------------------------------------
            //var genericList = new GenericList<int>();
            //genericList.Add(5);

            //var genericBookList = new GenericList<Book>();
            //genericBookList.Add(book);

            // From the below namespace there are in-built generic classes available in .net
            ///-----------------------------------------------------------------------------
            //System.Collections.Generic

            //var genericDictionary = new GenericDictionary<string, Book>();
            //genericDictionary.Add("KeyString", book);

            // Constraints in Generics
            //Utilities utilities = new Utilities();
            //Console.WriteLine(utilities.Max<int>(7, 6));

            Utilities<int> utilities = new Utilities<int>();
            Console.WriteLine(utilities.Max(7, 8));

        
       }
    }
}
