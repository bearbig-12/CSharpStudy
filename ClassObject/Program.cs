namespace _202509151200_object_class
{
    // Object class
    // C#에서는 모든 클래스는 최상위 클래스(superset)인 Object에서 상속을 받습니다.
    // 기본 제공 데이타 타입이나 사용자 정의 클래스도 자동으로 Object 클래스에서 상속됩니다.

    class A
    {
        public int _value;

        public A(int value)
        {
            _value = value;
        }
    }

    class B : A
    {
        public B(int value)
           : base(value)
        {

        }

    }

    class C : B
    {
        public C(int value)
           : base(value)
        {

        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            //Object
            A aObj = new A(10);
            B bObj = new B(20);
            C cObj = new C(30);

            Console.WriteLine($"aObj.toString() = {aObj.ToString()}");
            Console.WriteLine($"aObj.toString() = {bObj.ToString()}");
            Console.WriteLine($"aObj.toString() = {cObj.ToString()}");

            Console.WriteLine($"aObj.toString() = {aObj.GetType().FullName}");
            Console.WriteLine($"aObj.toString() = {bObj.GetType().IsClass}");
            Console.WriteLine($"aObj.toString() = {cObj.GetType().IsArray}");



            A aaObj = new A(10);

            A refaaObj = aaObj;


            bool isEqual = aaObj.Equals(aObj);

            Console.WriteLine($"isEqual = {isEqual}");

            isEqual = aaObj.Equals(refaaObj);

            Console.WriteLine($"isEqual = {isEqual}");


            isEqual = object.Equals(aaObj, aObj);
            Console.WriteLine($"isEqual = {isEqual}");

            // 값타입 비교.

            int a = 3;
            int b = 3;

            bool ret = a.Equals(b);

            Console.WriteLine($"ret = {ret}");



        }
    }
}
