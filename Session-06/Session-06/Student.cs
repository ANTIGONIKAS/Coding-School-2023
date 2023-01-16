using System;

public class Student : Person
{   //properties
    public int RegistrationNumber { get; set; }
    public Courses[] Courses { get; set; }

    public Student()
    {
    }


    public Student(Guid id) : base(Gui id)
    {
    }
    public Student(Guid id, string name) : base(id, name)
    {

    }

    public Student(Guid id, string name, int age, int RegistrationNumber) : base(id, name, age)
    {
        RegistrationNumber = registrationNumber;
    }
    public Student(Guid id, string name, int age, int registrationNumber, Courses[] courses) : base(id, name, age)
    {
        RegistrationNumber = registrationNumber;
        Courses = courses;

    }

    /*

    public Person()
    public Person(Guid id)
    public Person(Guid id, string name)
    public Person(Guid id, string name, int age)

    */
    public void Attend(Course course, DateTime datetime)
    {

    }
    public void WriteExam(Course course, DateTime datetime)
    {


    }
}