﻿namespace _202509081449_Switch_Case_DataType
{
    class Monster
    {
        public new string ToString()
        {
            return "Monster";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            object obj = 123.43;
            obj = "MONster";

            obj = new Monster();
            // c# 9.0
            // switch-case 문에 데이타 형식을 사용가능
            switch (obj)
            {
                case int i:
                    Console.WriteLine($"i = {i}");
                    break;

                case float f when f >= 0:
                    Console.WriteLine($"f = {f}");
                    break;

                case double d:
                    Console.WriteLine($"d = {d}");
                    break;

                case string e:
                    Console.WriteLine($"e = {e}");
                    break;

                case Monster k:
                    Console.WriteLine($"k = {k.ToString()}");
                    break;

            }
        }
    }
}
