
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Product { get; set; }
    }

    public interface IRpository<T>
    {
        void Add(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }


    public class UserRepository : IRpository<User>
    {
        private static UserRepository instance;
        private List<User> users = new List<User>();

        private UserRepository() { }

        public static UserRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new UserRepository();
            }
            return instance;
        }

        public void Add(User user)
        {
            users.Add(user);
        }

        public User GetById(int id)
        {
            return users.Find(u => u.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }


        public interface IUnitOfWork
        {
            void Commit();
            void Rollback();
        }

        public class UnitOfWork : IUnitOfWork
        {
            public void Commit()
            {
                Console.WriteLine("Changes committed to the database.");
            }

            public void Rollback()
            {
                Console.WriteLine("Changes rolled back.");
            }
        }

    }
}

//    public class user
//    {
//        public int  id { get; set; }
//        public string name { get; set; }
//    }

//    public class order
//    {
//        public int orderNo { get; set; }
//        public string username { get; set; }
//        public string product { get; set; }
//    }

//    public interface Createrepository<T>
//    {


//        void Add(T item);
//        T GetById(int id);
//        IEnumerable<T> GetAll();
//    }



//    public class patterns : ICreaterepository<user>
//    {

//        private List<user> users = new List<user>();

//        private static patterns instance;
//        private patterns() { }

//        public static patterns getInstance()
//        {
//            if( instance == null){
//                instance = new patterns();
//            }

//            return instance;

//        }

//        public void Add(user user)
//        {
//            users.Add(user);


//        }

//        public user GetById(int id)
//        {
//            return users.Find(u == u.id => id);
//        }
//        public IEnumerable<user> GetAll()
//        {
//            getInstance ().GetAll();
//        }

//        }

//    }
//}

