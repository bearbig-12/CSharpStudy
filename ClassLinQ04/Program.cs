using static System.Formats.Asn1.AsnWriter;

namespace _202509301211_LinQDesc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Random rand = new System.Random();

            int[] scores = new int[100];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = rand.Next(1, 100);
            }

            // scores 배열에 1~ 100사이에 값이 저장되어있습니다.
            // 배열에 저장된 값중 80보다 큰 수를 찾아서 내림차순으로 
            // 정렬하여 출력하세요..

            var result = scores
                .Where(score => score > 80)
                .OrderByDescending(score => score);

            // 쿼리문으로
            var result2 = from score in scores
                          where score > 80
                          orderby score descending
                          select score;
             
             


            Console.WriteLine("80보다 큰 점수 (내림차순):");
            foreach (var score in result)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("---------------------");

            foreach (var score in result2)
            {
                Console.WriteLine(score);
            }
        }
    }
}
