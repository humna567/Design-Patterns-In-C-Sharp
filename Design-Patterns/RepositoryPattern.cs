using System;
using System.Collections.Generic;


namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;


public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
    }

    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByTitle(string title);
        IEnumerable<T> GetByYear(string year);
        void Add(Book book);
    }

    public class BookRepository : IRepository<Book>
    {
        private List<Book> books = new List<Book>();

        public Book GetById(int id)
        {
            return books.Find(b => b.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
            return books.FindAll(b => b.Title.Equals(title));
        }

        public IEnumerable<Book> GetByYear(string year)
        {
            return books.FindAll(b => b.Year.Equals(year));
        }

        public void Add(Book book)
        {
            Console.WriteLine($"Book added - ID: {book.Id}, Title: {book.Title}, Year: {book.Year}");
        }
         

       public void add( Book book)
        {

            books.Add(book);
        }
        public void remove (Book book)
        {
            Console.WriteLine($"Book added - ID :{Book.Id},Title: {book.Title}");
        }

        //public void printall()
        //{
            
        //}
    }

    


}




    //    public int ID { get; set; }
    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //}
    //public interface Irepository<T>

        //{
        //    T GetByid(int id);
        //    IEnumerable<T> GetAll();
        //    void Add(T item);
        //    void Update(T item);
        //    void Delete(int id);
        //}
        //public class BookRepository : Irepository<Book>
        //{
        //    private List<Book> _book = new List<Book>();

        //    private int nextid = 1;
        //    public Book GetByid(int id)
        //    {
        //        return _book.Find(copy => copy.ID == id);
        //    }
        //    public void Add(Book book)
        //    {
        //        book.ID = nextid++;
        //        _book.Add(book);
        //    }

        //    public void Update(Book Updatedbook)
        //    {
        //        int index = _book.FindIndex(copy => copy.ID == Updatedbook.ID);
        //        if(index != -1)
        //        {
        //            _book[index] = Updatedbook;
        //        }
        //    }
        //    public IEnumerable<Book> GetAll()
        //    {
        //        return _book;
        //    }

        //    public void Delete( int id )
        //    {
        //        _book.RemoveAll(copy => copy.ID == id);

        


       
    


