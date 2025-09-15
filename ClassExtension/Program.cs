using System;


namespace MyExtention
{

    // 상속
    // 기능의 확장적인 면에서 상속.
    class extMath : Extention.Math2
    {
        public float div(int a, int b)
        {
            return a / b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            MyExtention.extMath extmath = new extMath();

            Console.WriteLine($"{a} + {b} = {extmath.add(a, b)}");
            Console.WriteLine($"{a} - {b} = {extmath.sub(a, b)}");
            Console.WriteLine($"{a} x {b} = {extmath.mul(a, b)}");

            Console.WriteLine($"{a} / {b} = {extmath.div(a, b)}");
        }
    }
}

