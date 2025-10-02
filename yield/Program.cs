namespace _202510011228_yield
{
    // yield
    // yield return 값을 하나씩 반환하면서 실행을 일시 정지하는 기능을 함..

    class Program
    {
        static IEnumerator<int> GetNumber()
        {
            yield return 1;

            yield return 2;

            yield return 3;

            yield return 4;
        }


        static void Main(string[] args)
        {

            var num = GetNumber();
            num.MoveNext();
            Console.WriteLine(num.Current);
            num.MoveNext();
            Console.WriteLine(num.Current);
            num.MoveNext();
            Console.WriteLine(num.Current);
            num.MoveNext();
            Console.WriteLine(num.Current);


        }
    }
}
