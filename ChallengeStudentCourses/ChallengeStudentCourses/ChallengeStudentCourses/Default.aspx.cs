using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultLabel.Text = "";
        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             Create a List of Courses (add three example Courses...make up the details).  Each Course should have at least two Students enrolled in them.  Use Object and Collection Initializers.  Then, iterate through each Course and print out the Course's details and the Students that are enrolled in each Course.
             */

            List<Course> courses = new List<Course>()
            {
                new Course() { CourseId = 131, Name="Invertebrate Biology", Students=new List<Student>() {
                    new Student() { StudentId = 100, Name = "Bill Osgood" },
                    new Student() { StudentId = 105, Name = "Cynthia Kowalsky" }}},
                new Course() { CourseId = 585, Name="German Expressionism", Students=new List<Student>() {
                    new Student() { StudentId = 110, Name = "Graciella Montrosi" },
                    new Student() { StudentId = 115, Name = "Tyrone DuBay"}}},
                new Course() { CourseId = 823, Name="Abnormal Psychology", Students=new List<Student>() {
                    new Student() { StudentId = 120, Name = "Fazil Uwald" },
                    new Student() { StudentId = 125, Name = "Patricia Smart" }}},
            };
        
           
            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("Course: {0} - {1}<br/>", course.CourseId, course.Name.ToUpper());
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;Student: {0} - {1}<br/>", student.StudentId, student.Name);
                }
            }

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             Create a Dictionary of Students (add three example Students...make up the details).  Use the StudentId as the key.  Each student must be enrolled in two Courses.  Use Object and Collection Initializers.  Then, iterate through each student and print out to the web page each Student's info and the Courses the Student is enrolled in.
             */

            Course course1 = new Course(){ CourseId=165, Name="19th-Century Science Fiction"};
            Course course2 = new Course(){ CourseId=408, Name="Wetlands of the Desert Southwest"};
            Course course3 = new Course(){ CourseId=773, Name ="Feline Neuroplasticity"};
            Course course4 = new Course(){ CourseId=955, Name ="Victor Herbert and the Second Viennese School"};

            Dictionary<int, Student> students = new Dictionary<int, Student>() {
                {200, new Student {/*StudentId = 200,*/ Name ="Terrence Clancy", Courses = new List<Course> {course1, course2}}},
                {205, new Student {/*StudentId = 205,*/ Name = "Fondania Tschirhardt", Courses = new List<Course>{course3, course1}}},
                {210, new Student {/*StudentId = 210,*/ Name = "Erlend Ng", Courses = new List<Course>{course2, course4}}},
            };
            // StudentId duplicates Dictionary key, so don't need both in this particular case

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("Student: {0} - {1}<br/>", student.Key, student.Value.Name.ToUpper());

                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;Course: {0} - {1}<br/>", course.CourseId, course.Name);
                }
            }


        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             We need to keep track of each Student's grade (0 to 100) in a particular Course.  This means at a minimum, you'll need to add another class, and depending on your implementation, you will probably need to modify the existing classes to accommodate this new requirement.  Give each Student a grade in each Course theyare enrolled in (make up the data).  Then, for each student, print out each Course they are enrolled in and their grade.
             */
         
            Student student1 = new Student();
            student1.StudentId = 300;
            student1.Name = "Norbert Norton";
            student1.CourseRecords = new List<CourseRecord>() {
                new CourseRecord { Grade = 85, Course = new Course { CourseId = 639, Name = "Urban Estuaries"}},
                new CourseRecord { Grade = 97, Course = new Course { CourseId = 487, Name = "Oral History of the Prussian War"}}
            };

            Student student2 = new Student();
            student2.StudentId = 305;
            student2.Name = "Dava Grove";
            student2.CourseRecords = new List<CourseRecord>() {
                new CourseRecord { Grade = 94, Course = new Course { CourseId = 372, Name = "Ancient Shipwrecks of the Mediterranean"}},
                new CourseRecord { Grade = 92, Course = new Course { CourseId = 487, Name = "Oral History of the Prussian War"}}
            };

            List<Student> students = new List<Student>() { student1, student2 };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("Student {0}: {1}<br/>", student.StudentId, student.Name.ToUpper());
                    foreach (var courseRecord in student.CourseRecords)
                    {
                        resultLabel.Text += String.Format("&nbsp;&nbsp;Course: {0} - Grade: {1}<br/>", courseRecord.Course.Name, courseRecord.Grade);
                    }
            }

        }

    }
}