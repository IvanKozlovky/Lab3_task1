using System;

namespace StudentProfessorApp
{
    public class Person
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }

    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }

    public class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }

    public class StudentProfessorTest
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(20);
            student.Greet();
            student.ShowAge();

            Professor professor = new Professor();
            professor.SetAge(45);
            professor.Greet();
            professor.Explain();
        }
    }
}
