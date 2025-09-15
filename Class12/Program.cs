namespace _202509121616_Method_Hiding
{

    // 메소드 하이딩(Method Hiding)
    // 부모 데소드의 영향을 주지않고 특정 메서드를 다시 구형해야 하는 경우
    // 메소드 숨기기의 목적은 부모클래스의 멤버를 보호하는 것입니다.

    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }

        public void MyMethod(string str)
        {
            Console.WriteLine($"Base.MyMethod{str}");
        }
    }

    class Derived : Base
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class Deriveds : Derived
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
            base.MyMethod();
        }

    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();

        }
    }
}
