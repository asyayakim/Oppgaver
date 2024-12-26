using System.ComponentModel.DataAnnotations;

namespace Oppgaver.TestProject
{
    public class StudentInClass
    {
        private List<StudentInClass> _students;
        private string _name { get; set; }
        private int _id { get; set; }
        private int _age { get; set; }

        public StudentInClass(string name, int id, int age)
        {
            _name = name;
            _id = id;
            _age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Id: {_id}");
        }

        public void FindYoungest()
        {
            var youngest = _students[0];
            foreach (var student in _students)
            {
                if (student._age < youngest._age)
                {
                    youngest = student;
                }
            }
            Console.WriteLine($"The youngest student is {youngest._name}, Age: {youngest._age}, ID: {youngest._id}");
            
        }
    }
}

