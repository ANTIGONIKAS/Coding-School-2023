using UniversityLib;

namespace Session_10
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            List<Course> courses = new List<Course>();
            List<Grade> grades = new List<Grade>();

            Student student1 = new Student()
            {
                Name = "Dimitris",
                Age = 40,
                RegistrationNumber = 1,


            };


            students.Add(student1);



            Student student2 = new Student()
            {
                Name = "Antigoni",
                Age = 39,
                RegistrationNumber = 2,

            };
            students.Add(student2);

            grvStudents.DataSource = students;
            grvStudents.AutoGenerateColumns = false;


            Course c1 = new Course()
            {
                Code = "123",
                Subject = "History"
            };

            courses.Add(c1);

            Course c2 = new Course()
            {

                Code = "124",
                Subject = "Programming",
            };
            courses.Add(c2);
            grvStudents.DataSource = courses;
            grvStudents.AutoGenerateColumns = false;
        }

    }
}



