using System;

interface ITask
{
    void Start();
    void Complete();
    string GetTaskInfo();
}

class WorkTask : ITask
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; private set; }

    public WorkTask(string title, string description)
    {
        Title = title;
        Description = description;
        IsCompleted = false;
    }

    public void Start()
    {
        Console.WriteLine($"Starting work task: {Title}");
    }

    public void Complete()
    {
        IsCompleted = true;
        Console.WriteLine($"Work task '{Title}' completed.");
    }

    public string GetTaskInfo()
    {
        return $"Work Task: {Title}, Description: {Description}, Completed: {IsCompleted}";
    }
}

class PersonalTask : ITask
{
    public string Title { get; set; }
    public string DueDate { get; set; }
    public bool IsCompleted { get; private set; }

    public PersonalTask(string title, string dueDate)
    {
        Title = title;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public void Start()
    {
        Console.WriteLine($"Starting personal task: {Title}");
    }

    public void Complete()
    {
        IsCompleted = true;
        Console.WriteLine($"Personal task '{Title}' completed.");
    }

    public string GetTaskInfo()
    {
        return $"Personal Task: {Title}, Due Date: {DueDate}, Completed: {IsCompleted}";
    }
}

class StudyTask : ITask
{
    public string Subject { get; set; }
    public int PagesToRead { get; set; }
    public bool IsCompleted { get; private set; }

    public StudyTask(string subject, int pagesToRead)
    {
        Subject = subject;
        PagesToRead = pagesToRead;
        IsCompleted = false;
    }

    public void Start()
    {
        Console.WriteLine($"Starting study task: {Subject}");
    }

    public void Complete()
    {
        IsCompleted = true;
        Console.WriteLine($"Study task '{Subject}' completed.");
    }

    public string GetTaskInfo()
    {
        return $"Study Task: {Subject}, Pages to Read: {PagesToRead}, Completed: {IsCompleted}";
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів різних типів завдань
        ITask workTask = new WorkTask("Finish project report", "Complete the report by end of the week");
        ITask personalTask = new PersonalTask("Grocery shopping", "2024-11-10");
        ITask studyTask = new StudyTask("Read C# book", 50);

        // Тестування методів для кожного завдання
        workTask.Start();
        Console.WriteLine(workTask.GetTaskInfo());
        workTask.Complete();
        Console.WriteLine(workTask.GetTaskInfo());

        Console.WriteLine();

        personalTask.Start();
        Console.WriteLine(personalTask.GetTaskInfo());
        personalTask.Complete();
        Console.WriteLine(personalTask.GetTaskInfo());

        Console.WriteLine();

        studyTask.Start();
        Console.WriteLine(studyTask.GetTaskInfo());
        studyTask.Complete();
        Console.WriteLine(studyTask.GetTaskInfo());
    }
}