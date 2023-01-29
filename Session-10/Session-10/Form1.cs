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
            grvStudents.AutoGenerateColumns = false;

            List<Student> students = new List<Student>();
            Student st1 = new Student()
            {
                Name = "Antigoni",
                Surname = "Kasioura",
                Age = 39,
                RegistrationNumber = 123,
                Gender= Student.GenderEnum.Female,
                Undergraduate=true
            };
            students.Add(st1);

            Student st2 = new Student()
            {
                Name = "Dimitris",
                Surname = "Raptodimos",
                Age = 40,
                RegistrationNumber = 124,
                Gender =Student.GenderEnum.Male
            };
            students.Add(st2);
            grvStudents.DataSource= students;
            grvStudents.AutoGenerateColumns = false;
            DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            colGender.Items.Add(Student.GenderEnum.Male);
            colGender.Items.Add(Student.GenderEnum.Female);
            colGender.Items.Add(Student.GenderEnum.Other);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}