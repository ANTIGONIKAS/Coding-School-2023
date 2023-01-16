using System;

public class Schedule
{
    public Guid ID { get; set }
    public Guid CourseID { get; set }
    public Guid ProfessorID { get; set }
    public DateTime Callendar { get; set }
}
public Schedule()
	{
	}
public Schedule(Guid id,Guid courseID,Guid professorID,DateTime callendar)
{
    ID = id;
    CourseID = courseID;
    ProfessorID = professorID;
    DateTime = callendar;


}




}
