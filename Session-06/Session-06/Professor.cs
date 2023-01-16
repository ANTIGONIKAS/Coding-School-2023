using System;

public class Professor : Person
{   //properties
    public string Rank { get; set; }
    public Courses[] Courses { get; set; }

    public Professor()
    {
    }

    public Professor(Guid id, string name) : base(id, name)
    {

    }
    public Professor(Guid id, string name, int age) : base(id, name, age)
    {

    }

    public Professor(Guid id, string name, int age, string rank, Courses[] courses) : base(id, name, age)
    {
        Rank = rank;
        Courses = courses;


    }
    //methods
    public void Teach(Course course, DateTime datetime)
    {

    }
    public void SetGrade(Guid studentID, Guid courseID, int grade)
    {

    }

    public void GetName()
    { 
    }

}