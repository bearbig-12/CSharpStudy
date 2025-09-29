namespace _202509251207_GenericMethod_Exer
{
    internal class Program
    {

        static void PrintAll<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintOne<T>(T value)
        {
            Console.WriteLine($"값: {value}");
        }


        // PrintAll 메소드가 아래의 타입에 작동하도록 
        // 일반화 메소드로 만들고 실행 시켜보세요.
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            float[] fnumbers = { 3.4f, 7.4f, 8.9f, 10.8f, 12.7f, 13.8f };
            string[] fruits = { "Apple", "Banana", "Cherry" };

            Console.WriteLine("=== Numbers ===");
            PrintAll(numbers);

            Console.WriteLine("==== float ====");
            PrintAll(fnumbers);

            Console.WriteLine("=== Fruits ===");
            PrintAll(fruits);
        }
    }
}
