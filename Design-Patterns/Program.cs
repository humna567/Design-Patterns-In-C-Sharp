
using DesignPatterns;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Drawing;
using static DesignPatterns.UserRepository;
//using static DesignPatterns.OCP;


var computerShop = new ComputerShop();
var computer = computerShop.BuildComputer(new OfficeComputerBuilder());
Console.WriteLine(computer.CPU);

var things = new thing();
var software = things.BuildUtensils(new softwarehouse1());


Console.WriteLine(software.Kitchen);
Console.WriteLine(software.Room);
Console.WriteLine(software.Garage);


Singleton obj1 = new Singleton();
Singleton obj2 = new Singleton();

Console.WriteLine(obj1 == obj2);
obj1.mymethod();
obj2.mymethod();



Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;



logger1.LogMessage("Log message 1");
logger2.LogMessage("Log message 2");

logger1.PrintLogs();
logger2.PrintLogs();


Irepository<Book> bookRepository = new BookRepository();

bookRepository.Add(new Book { Title = "Book 1", Author = "Author 1" });
bookRepository.Add(new Book { Title = "Book 2", Author = "Author 2" });

var allBooks = bookRepository.GetAll();
foreach (var book in allBooks)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
}
TaskRepository taskRepository = new TaskRepository();
UnitOfWork unitOfWork = new UnitOfWork(taskRepository);

// Adding a new task
Task newTask = new Task { Id = 1, Title = "Buy groceries", IsCompleted = false };
taskRepository.Add(newTask);

// Completing a task using UnitOfWork
unitOfWork.CompleteTask(1);

Console.WriteLine("Task status after completion: " + newTask.IsCompleted);
    }
}



Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
Circle circle = new Circle { Radius = 7 };

AreaCalculator areaCalculator = new AreaCalculator();
double rectangleArea = areaCalculator.CalculateArea(rectangle);
double circleArea = AreaCalculator.CalculateArea(circle);


u can modify it 
Console.WriteLine($"Rectangle Area: {rectangleArea}");
Console.WriteLine($"Circle Area: {circleArea}");


Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
Circle circle = new Circle { Radius = 7 };

AreaCalculator areaCalculator = new AreaCalculator();
double rectangleArea = areaCalculator.CalculateArea(rectangle);
double circleArea = areaCalculator.CalculateArea(circle);

Console.WriteLine($"Rectangle Area: {rectangleArea}");
Console.WriteLine($"Circle Area: {circleArea}");

//Persons person = new Persons();
//person.Hello();




IWorker worker = new Worker();
worker.Work();
worker.Eat();
worker.Sleep();


IWorker robot = new Robot();
robot.Work();
robot.Eat();
robot.Sleep();

TaskRepository taskRepository = new TaskRepository();
UnitOfWork unitOfWork = new UnitOfWork(taskRepository);

Task newTask = new Task { Id = 1, Title = "Buy groceries", IsCompleted = false };
taskRepository.Add(newTask);

unitOfWork.CompleteTask(1);

Console.WriteLine("Task status after completion: " + newTask.IsCompleted);



logger Logger = logger.Instance();
Logger.Logmessage("Application started ");
Logger.Logmessage(" Performing initialization ");


logger anotherLogger = logger.Instance();
anotherLogger.Logmessage("This log is from another logger instance.");

anotherLogger.Logmessage("Application shutting down.");

Logger.printmessage();

IRepository<Book> bookRepository = new BookRepository();

while (true)
{
    Console.Write("Enter Book ID (0 to exit): ");
    int id = int.Parse(Console.ReadLine());

    if (id  == 0)
    {
        break;
    }

    Console.Write("Enter Title: ");
    string title = Console.ReadLine();

    Console.Write("Enter Year: ");
    string year = Console.ReadLine();

    Book book = new Book { Id = id, Title = title, Year = year };
    bookRepository.Add(book);
}

Console.WriteLine("\nAll Books:");

foreach (var book in bookRepository.GetAll())
{



    Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Year: {book.Year}");
}


        UserRepository userRepository = UserRepository.GetInstance();
//TaskRepository taskrepo = new TaskRepository();
IUnitOfWork unitOfWork = new UnitOfWork();


        User user = new User { Id = 1, Name = "Alice" };
        userRepository.Add(user);

        Order order = new Order { Id = 1, UserId = user.Id, Product = "Coffee" };

        Console.WriteLine("User and order added. Do you want to commit changes? (Y/N)");
        string input = Console.ReadLine();



        if (input == "y")
        {
            unitOfWork.Commit();
        }
        else
        {
            unitOfWork.Rollback();
        }



        Console.WriteLine("All Users:");
        foreach (var u in userRepository.GetAll())
        {
            Console.WriteLine($"User ID: {u.Id}, Name: {u.Name}");
}
    


        // Dictionary 
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Key-value pairs add karo
        ages["AGE1"] = 25;
        ages["AGE2"] = 30;
        ages["AGE3"] = 28;

        // retrieve associative value related to key
        int aliceAge = ages["meri"];
        Console.WriteLine($"Humna ki age: {aliceAge}");

        // start loop for existing key-value pair in dictionary
        foreach (var pair in ages)
        {
            Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value}");
        }

        // Kisi key ko check karo ke woh Dictionary mein hai ya nahi
        bool isKeyPresent = ages.ContainsKey("Dave");
        Console.WriteLine($"Is key present in Dictionary? {isKeyPresent}");


// Create a dictionary to store words and their meanings
Dictionary<string, string> englishDictionary = new Dictionary<string, string>();

englishDictionary["apple"] = "A round fruit with red or green skin and white flesh.";
englishDictionary["book"] = "A physical or digital object consisting of pages containing information.";
englishDictionary["computer"] = "An electronic device that processes data and performs tasks according to a set of instructions.";

Console.Write("Enter a word to look up its meaning: ");
string userInput = Console.ReadLine();


if (englishDictionary.ContainsKey(userInput))
{
    string meaning = englishDictionary[userInput];
    Console.WriteLine($"Meaning of '{userInput}': {meaning}");
}
else
{
    Console.WriteLine($"'{userInput}' not found in the dictionary.");
}
    