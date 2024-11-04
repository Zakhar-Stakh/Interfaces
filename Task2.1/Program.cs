using System;

interface IPrintable
{
    void Print();
}

interface IBorrowable
{
    void BorrowItem();
    void ReturnItem();
    bool IsAvailable();
}

class Book : IPrintable, IBorrowable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }
    private bool isAvailable;

    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
        isAvailable = true; 
    }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {YearPublished}, Available: {isAvailable}");
    }

    public void BorrowItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine($"You have borrowed '{Title}'.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{Title}' is currently not available.");
        }
    }

    public void ReturnItem()
    {
        if (!isAvailable)
        {
            isAvailable = true;
            Console.WriteLine($"You have returned '{Title}'.");
        }
        else
        {
            Console.WriteLine($"'{Title}' was not borrowed.");
        }
    }

    public bool IsAvailable()
    {
        return isAvailable;
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів книг
        Book book1 = new Book("1984", "George Orwell", 1949);
        Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);

        // Виведення інформації про книги
        book1.Print();
        book2.Print();
        book3.Print();

        Console.WriteLine();

        // Перевірка доступності та взяття книг
        book1.BorrowItem(); 
        book1.Print(); 
        book1.BorrowItem(); 

        Console.WriteLine();

        // Повернення книги
        book1.ReturnItem(); 
        book1.Print(); 
        book1.ReturnItem(); 

        Console.WriteLine();

        // Перевірка доступності інших книг
        book2.BorrowItem();
        Console.WriteLine($"Is '{book2.Title}' available? {book2.IsAvailable()}");
        book2.ReturnItem();
        Console.WriteLine($"Is '{book2.Title}' available? {book2.IsAvailable()}");
    }
}