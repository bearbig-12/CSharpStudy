using System;

namespace _202509241356_Nested_Class2
{
    public class School
    {
        public void PrintSchool()
        {
            Console.WriteLine("PrintSchool() Method 호출");
        }

        public class Teacher // 중첩 클래스
        {
            public void PrintTeacher()
            {
                School school = new School();
                school.PrintSchool();
                Console.WriteLine("PrintTeacher() Method 호출");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            School.Teacher teacher = new School.Teacher();

            teacher.PrintTeacher();

        }
    }
}

