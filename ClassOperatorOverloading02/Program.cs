﻿namespace Custom
{
    class Test
    {
        public int _intNum;
        public float _floatNum;

        public Test(int intNum, float floatNum)
        {
            _intNum = intNum;
            _floatNum = floatNum;
        }

        public override string ToString()
        {
            return $"_intNum = {_intNum}, _floatNum = {_floatNum}";
        }
    }


    class Number
    {
        int _intNum;
        float _floatNum;
        double _doubleNum;
        string _stringNum;


        public Number(int intNum, float floatNum, double doubleNum, string stringNum)
        {
            _intNum = intNum;
            _floatNum = floatNum;
            _doubleNum = doubleNum;
            _stringNum = stringNum;
        }

        // 아래 Main 함수의 코드가 작동하도록 형변환 연산자를 만들어 넣으세요.
        // 명시적 형변환을 하세요....
        public static explicit operator int(Number c)
        {
            return c._intNum;
        }

        public static explicit operator float(Number c)
        {
            return c._floatNum;
        }

        public static explicit operator double(Number c)
        {
            return c._doubleNum;
        }

        public static explicit operator string(Number c)
        {
            return c._stringNum;
        }

        public static explicit operator Test(Number c)
        {
            Test test = new Test(c._intNum, c._floatNum);

            return test;
        }


    }
}




namespace _202509231654_OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Custom.Number number = new Custom.Number(100, 12.23f, 1234.45, "일백만원");

            int num = (int)number;
            float fnum = (float)number;
            double dnum = (double)number;
            string snum = (string)number;
            Custom.Test test = (Custom.Test)number;

            Console.WriteLine($"num = {num}, fnum = {fnum}, dnum = {dnum}, snum = {snum}");
            Console.WriteLine($"Custom.Test = {test}");




        }
    }
}
