using System.Collections;

namespace BuiltInInterfaces
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student? other)
        {
            if (Age > other?.Age)
            {
                return 1;
            }
            else if (Age < other?.Age)
            {
                return -1;
            }
            return 0;
        }
    }

    public class ClassRoom : IEnumerable<Student>
    {
        private List<Student> students = new();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in students)
            {
                yield return item;
            }
        }

        public List<Student> Sort()
        {
            students.Sort();
            return students;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
