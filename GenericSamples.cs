using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class GenericSamples
    {

    }

    public class GenericList<T>
    {
        public void Add(T value)
        {
            Console.WriteLine("Genric Add");
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    /// <summary>
    /// Types of constraints in Generics.
    /// ---------------------------------
    /// 1. where T : IComparable
    /// 2. where T : Products
    /// 3. where T : struct
    /// 4. where T : class
    /// 5. where T : new()
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)  
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        //public T Max<T>(T a, T b) where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}
    }

    public class Nullable<T> where T : struct
    {
        public Nullable(T value)
        {

        }


        public T Value { get; set; }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            Console.WriteLine("Generic Dictionary Add method");
        }
    }

    public class ObjectList
    {
        public void Add(object value)
        {
            Console.WriteLine("Object add");
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class BookList
    {
        public void Add(Book book)
        {
            Console.WriteLine("Book Add");
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }

    }
}
