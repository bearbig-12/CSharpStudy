namespace _202509290504_Linq
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] fruits = { "strawberry", "mango", "banana", "apple", "blueberry", "melon" };


    //        var sortedfruits = from fruit in fruits
    //                           orderby fruit descending
    //                           select fruit;

    //        foreach (var str in sortedfruits)
    //        {
    //            Console.WriteLine($"{str}, ");
    //        }


    //    }
    //}


    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "a", "z" };

    //        var sortedDigits = from digit in digits
    //                           orderby digit.Length descending
    //                           select digit;

    //        foreach (var data in sortedDigits)
    //        {
    //            Console.WriteLine($"[{data}] ");

    //        }

    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


    //        var Digits =
    //           from digit in digits
    //           where digit[1] == 'i' || digit[1] == 'n'
    //           select digit;

    //        foreach (var data in Digits)
    //        {
    //            Console.WriteLine(data);
    //        }

    //        Console.WriteLine();
    //        var reversedIDigits =
    //           (from digit in digits
    //            where digit[1] == 'i' || digit[1] == 'n'
    //            select digit)
    //           .Reverse();


    //        foreach (var data in reversedIDigits)
    //        {
    //            Console.WriteLine($"{data} ");
    //        }

    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "A", "a", "B", "b", "c", "C", "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words
               .OrderBy(a => a.Length)
               .ThenBy(a => a);


            foreach (var data in sortedWords)
            {
                Console.WriteLine($"{data}, ");
            }

        }
    }
}
