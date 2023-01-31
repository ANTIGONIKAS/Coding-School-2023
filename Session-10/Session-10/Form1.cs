using UniLib;

namespace Session_10
{
    public partial class Form1 : Form
    {
       public University university;
       public List<Student> students { get; set; }
       public List<Course> courses { get; set; }     
       public List<Grade> grades { get; set; }     
       public List<Schedule> scheduleCourses { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              PopulateStudents();
              SetControlProperties();
              PopulateCourses();
              PopulateGrades();


            
        }
        public void PopulateStudents()
        {
            List<Student> students = new List<Student>();
            Student st1 = new Student()
            {
                Name = "Antigoni",
                Surname = "Kasioura",
                Age = 39,
                RegistrationNumber = 123,
                Gender = Student.GenderEnum.Female,
                Undergraduate = true
            };
            students.Add(st1);

            Student st2 = new Student()
            {
                Name = "Dimitris",
                Surname = "Raptodimos",
                Age = 40,
                RegistrationNumber = 124,
                Gender = Student.GenderEnum.Male
            };
            students.Add(st2);
            grvStudents.AutoGenerateColumns = false;
            grvStudents.DataSource = students;


        }
        public void PopulateCourses()
        {
            List<Course> courses = new List<Course>();
            Course c1 = new Course()
            {

                
                Subject = "Mathematics"

            };
            courses.Add(c1);

            Course c2 = new Course()
            {
                
                Subject = "Programming"
            };
            courses.Add(c2);

            
        }
        public void PopulateGrades()
        {
            List<Grade> grades = new List<Grade>();
            Grade grade = new Grade()
            {

                StudentID = university.Students[0].ID,
                CourseID = university.Courses[0].ID,
                GradeVal = 8
            };
            grades.Add(grade);

            grade = new Grade()
            {
                StudentID = university.Students[0].ID,
                CourseID = university.Courses[1].ID,
                GradeVal = 7
            };
            grades.Add(grade);

            grvGrades.DataSource = grades;

        }
        private void SetControlProperties()
        {
            DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            colGender.Items.Add(Student.GenderEnum.Male);
            colGender.Items.Add(Student.GenderEnum.Female);
            colGender.Items.Add(Student.GenderEnum.Other);
            grvStudents.AutoGenerateColumns = false;
            grvCourses.DataSource = courses;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
      
}

