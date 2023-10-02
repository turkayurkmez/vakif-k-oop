// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;

Console.WriteLine("Hello, World!");

Student student1 = new() { Name = "A", LastName = "A1", Age = 10, Id = 1 };
Student student2 = new() { Name = "B", LastName = "B1", Age = 5, Id = 1 };
Student student3 = new() { Name = "C", LastName = "C1", Age = 7, Id = 1 };

ClassRoom classRoom = new();
classRoom.AddStudent(student1);
classRoom.AddStudent(student2);
classRoom.AddStudent(student3);

classRoom.Sort();
foreach (var item in classRoom)
{
    Console.WriteLine(item.Name);
}