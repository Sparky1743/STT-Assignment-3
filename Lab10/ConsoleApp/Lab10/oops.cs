using System;

class Student
{
    // Properties
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }

    // Constructor to initialize values
    public Student(string name, int id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    // Method to determine grade based on marks
    public string GetGrade()
    {
        if (Marks >= 90) return "A";
        if (Marks >= 80) return "B";
        if (Marks >= 70) return "C";
        if (Marks >= 60) return "D";
        return "F";
    }

    // Method to display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}, Marks: {Marks}, Grade: {GetGrade()}");
    }
}

// Subclass StudentIITGN inheriting from Student
class StudentIITGN : Student
{
    public string Hostel_Name_IITGN { get; set; }

    // Constructor for StudentIITGN
    public StudentIITGN(string name, int id, double marks, string hostelName)
        : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostelName;
    }

    // Override display method to include hostel details
    public new void DisplayStudentDetails()
    {
        base.DisplayStudentDetails();
        Console.WriteLine($"Hostel: {Hostel_Name_IITGN}");
    }
}
