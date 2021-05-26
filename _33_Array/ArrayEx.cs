using System;

namespace _33_Array
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            // 국어, 영어, 수학점수를 입력받고
            // 총합과 평균을 구하세요
            int[] scores = new int[3];
            int total = 0;
            double avg = 0.0;
            Console.Write("국어점수 입력: ");
            scores[0] = Int32.Parse(Console.ReadLine());
            Console.Write("영어점수 입력: ");
            scores[1] = Int32.Parse(Console.ReadLine());
            Console.Write("수학점수 입력: ");
            scores[2] = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < scores.Length; i++)
                total += scores[i];
            Console.WriteLine("총합: " + total);
            avg = (double)total / scores.Length;
            Console.WriteLine("평균: {0:0.##}", avg);
        }
    }
}
