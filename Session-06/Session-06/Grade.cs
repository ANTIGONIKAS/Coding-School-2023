using System;

public class Grade
{
    public Guid ID { get; set }
    public Guid StudentID { get; set; } 
    public Guid CourseID { get; set; } 
    public int Grade { get; set; } 

    public Grade()
	{
	}
    public Grade(Guid id, Guid studentID, Guid courseID, int grade)
    {
        ID = id;
        studentID = studentID;
        CourseID = courseID;
        Grade = grade;

    }

}
