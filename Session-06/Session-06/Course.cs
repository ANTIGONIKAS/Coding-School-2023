using System;

public class Course
{
    public Guid ID { get; set }
    public string Code { get; set; }
    public string Subject { get; set; }

    public Course()
	{
	}
    public Course(Guid id, string code, string subject)
    {
        ID = id;
        Code= code; 
        Subject= subject;   
    }

    

}
