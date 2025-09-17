using System;

namespace _202509151209_BoxingUnBoxing
{
    // Boxing, UnBoxing

    // 값타입(value type) : 기본데이타타입(string 제외), 구조체, 열거체
    // 참조타입(reference type) : string, class, array

    class A
    {
        public int _value;

        public void Print()
        {
            Console.WriteLine($"_value = {_value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;

            object obj = i; // boxing;

            object obj2 = i; // Boxing

            int j = (int)obj; // Unboxing;

            Console.WriteLine($"boj = {obj}");

            obj = new A();      // C# 모든 객체는 Object 타입에서 상속 받습니다. UpCasting

            ((A)obj)._value = 20;  // 다운캐스팅

            A a = (A)obj;
            a.Print();





        }
    }
}

