namespace Oppgaver.ClassStructure;

public class ClassHandler
{
    public class School
    {
        public string Name { get; }
        private List<Room> Rooms { get; }
        private List<Course> Courses { get; }
        private List<Teacher> Teachers { get; }
        private List<Student> Students { get; }
        private List<TimePlan> TimePlans { get; }


        public School()
        {
            Name = "Videregående Skole";
            Teachers = new List<Teacher>
            {
                new Teacher("Niha Turr"),
                new Teacher("Juki Papuku")
            };
            Rooms = new List<Room>
            {
                new Room("1a", 3),
                new Room("1b", 4)
            };
            
            Courses = new List<Course>
            {
                new Course("Mathematics", Teachers[0]),
                new Course("Norsk", Teachers[1])
            };
            Students = new List<Student>
            {
                new Student("Joe Dou"),
                new Student("Elisabeth Turner"),
                new Student("Jacky Dou"),
                new Student("Rune Grit"),
                new Student("Helen Si"),
                new Student("Ola Dou"),
            };
            TimePlans = new List<TimePlan>
            {
                new TimePlan("08:00-09:00"),
                new TimePlan("09:00-10:00"),
                new TimePlan("10:00-11:00"),
                new TimePlan("11:00-12:00"),
                new TimePlan("12:00-13:00"),
                new TimePlan("13:00-14:00"),
                new TimePlan("14:00-15:00")
            };
        }

        public class TimePlan
        {
            public string Time { get; }

            public TimePlan(string time)
            {
                Time = time;
            }
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

            public Course(string subject, Teacher teacher)
            {
                Subject = subject;
                Teachers = new List<Teacher>() { teacher };
            }
        }

        public class Room
        {
            public string Name { get; }
            public int Capacity { get; }
            public List<Student> AssignedStudents { get; }

            public Room(string name, int capacity)
            {
                Name = name;
                Capacity = capacity;
                AssignedStudents = new List<Student>();
            }
        }

        public void AssignStudentsToRooms()
        {
            var studentQueue = new Queue<Student>(Students);
            foreach (var room in Rooms)
            {
                while (studentQueue.Count > 0
                       && room.AssignedStudents.Count < room.Capacity)
                {
                    room.AssignedStudents.Add(studentQueue.Dequeue());
                }

                if (studentQueue.Count == 0) break;
            }

            if (studentQueue.Count > 0)
            {
                Console.WriteLine("No more can assign");
            }
        }

        public void PrintRooms()
        { 
            foreach (var room in Rooms)
            {
                Console.WriteLine($"Room: {room.Name} (Capacity: {room.Capacity})");
                foreach (var student in room.AssignedStudents)
                {
                    Console.WriteLine($" - {student.Name}");
                }
            }
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

        public object GetTeacher(string name)
        {
            return Teachers.FirstOrDefault(t => t.Name == name)!;
        }

        public object? GetStudent(string name)
        {
            return Students.FirstOrDefault(s => s?.Name == name);
        }

        public object GetStudentList()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student?.Name);
            }
            return Students;
        }

        public List<Schedule> GenerateSchedule()
        {
            var schedules = new List<Schedule>();
            foreach (var time in TimePlans)
            {
                foreach (var course in Courses)
                {
                    foreach (var room in Rooms)
                    {
                        if (schedules.Any(s =>
                                s.Time == time.Time && (s.Room == room.Name || s.Teacher == course.Teachers[0].Name)))
                            continue;
                        schedules.Add(new Schedule
                        {
                            Time = time.Time,
                            Room = room.Name,
                            Course = course.Subject,
                            Teacher = course.Teachers[0].Name
                        });
                        break;
                    }
                }
            }
            return schedules;
        }

        public class Schedule
        {
            public required string Time { get; set; }
            public string Room { get; set; }
            public string Course { get; set; }
            public string Teacher { get; set; }
        }
    }
}