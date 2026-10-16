using System;

class Student
{
    public string Name { get; }
    public int Id { get; }
    private double _grade;

    public double Grade
    {
        get { return _grade; }
        set
        {
            if (value < 0 || value > 20)
            {
                Console.WriteLine("Invalid grade. Must be between 0 and 20.");
                return;
            }
            _grade = value;
        }
    }

    public Student(string name, int id, double grade)
    {
        Name = name;
        Id = id;
        Grade = grade;
    }

    public bool IsPassed()
    {
        return Grade >= 10;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id} | Name: {Name} | Grade: {Grade} | Passed: {IsPassed()}");
    }
}