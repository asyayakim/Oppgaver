namespace Oppgaver.ClassStructure;

public class ClassHandler
{
    public class School
    {
        public School()
        {
            Name = "Videregående Skole";
            Teachers = new List<Teacher>
            {
                new Teacher("Elisabeth Turner"),
                new Teacher("Joe Dou")
            };
            Classes = new List<SchoolClass>
            {
                new SchoolClass("1a"),
                new SchoolClass("1b")
            };
            Courses = new List<Course>
            {
                new Course("Mathematics", Teachers[0], Classes[0]),
                new Course("Norsk", Teachers[1], Classes[1])
            };
            Students = new List<Student?>
            {
                new Student("Joe Dou"),
                new Student("Elisabeth Turner"),
                new Student("Jacky Dou")
            };
        }

        public class Student
        {
            public string Name { get; set; }
            public Student(string name)
            {
                Name = name;
            }
        }

        public class Course
        {
            public string Subject { get; set; }
            public List<Teacher> Teachers { get; set; }
            public List<SchoolClass> Classes { get; set; }
            

            public Course(string subject, Teacher teacher, SchoolClass @class)
            {
                Subject = subject;
                Teachers = new List<Teacher>(){ teacher };
                Classes = new List<SchoolClass> { @class };
            }
        }

        public class SchoolClass(string name)
        {
            public string Name { get; } = name;
        }

        public class Teacher
        {
            public string Name { get; }
            private List<Course> Courses { get; } = new();

            public Teacher(string name)
            {
                Name = name;
            }
        }

        public string Name { get; }
        private List<SchoolClass> Classes { get; }
        private List<Course> Courses { get; }
        private List<Teacher> Teachers { get; }
        private List<Student?> Students { get; }


        public object? GetTeacher(string name)
        {
            return Teachers.FirstOrDefault(t => t?.Name == name);
        }


        public object? GetStudent(string name)
        {
            return Students.FirstOrDefault(s => s?.Name == name);
        }
    }
}