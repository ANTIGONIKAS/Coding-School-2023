using System;

public class University : Institute
{   //properties
	public Student[] Students { get; set; }
	public Course[] Courses { get; set; }
	public Grade[] Grades { get; set; }
	public Schedule[] ScheduledCourse { get; set; }

	public University()
	{

	}
	public University(Guid id, string name, int yearsInService) : base(id, name, yearsInService)
	{


	}
	public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses, Grade[] grades, Schedule[] scheduledCourse) :
		base(id, name, yearsInService)
	{

		Students = students;
		Courses = courses;
		Grades = grades;
		ScheduledCourse = scheduledCourse;
	}


	// //methods 
	public void getStudents()
	{

	}
	public void getCourses()
	{

	}
	public void getGrades()
	{

	}
	public void setSchedule(Guid courseID, Guid ProfessorID, DateTime dateTime)
	{

	}
}