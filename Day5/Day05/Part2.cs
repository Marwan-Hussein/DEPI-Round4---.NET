using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Day05.Program;
namespace Day05
{
    internal class Part2
    {
        // problem 6
        public static void ReverseInt(int n)
        {
            if (n == 0)
                return;
            Write(n % 10);
            ReverseInt(n / 10);
        }

        // problem 7
        public static int MaxDist(int[] arr,int pos=0, int maxD = -1)
        {
            if (pos >= arr.Length)
                return maxD;
            for (int i = arr.Length - 1; i >= pos; --i)
                if (arr[i] == arr[pos])
                    return MaxDist(arr, ++pos, Math.Max(maxD, i -pos));
            return maxD;
        }
        public static void Run()
        {
            #region p1
            problem(1);
            Write("Enter a number:");
            int.TryParse(ReadLine(), out int n1);
            for (int i = 1; i <= n1; ++i)
                Write($"{i} ");
            #endregion

            #region p2
            problem(2);
            Write("Enter a number:");
            int.TryParse(ReadLine(), out int n2);
            for (int i = 1; i <= 12; ++i)
                Write($"{n2 * i} ");
            #endregion

            #region p3
            problem(3);
            Write("Enter a number:");
            int.TryParse(ReadLine(), out int n3);
            for (int i = 1; i <= n3; ++i)
                if (i % 2 == 0)
                    Write($"{i} ");
            #endregion

            #region p4
            problem(4);
            Write("Enter a base: ");
            int.TryParse(ReadLine(), out int base_);

            Write("Enter a pow: ");
            int.TryParse(ReadLine(), out int pow);
            int res = 1;
            for (int i = 0; i < pow; ++i)
                res *= base_;
            WriteLine($"{base_}^{pow} = {res}");
            #endregion

            #region p5
            problem(5);
            Write("enter a string to reverse: ");
            string str5 = ReadLine();
            for (int i = str5.Length; i > 0; --i)
                Write(str5[i - 1]);
            #endregion

            #region p6
            problem(6);
            Write("Enter a n:");
            int.TryParse(ReadLine(), out int n6);
            ReverseInt(n6);
            WriteLine();
            #endregion

            #region p7
            problem(7);
            Write("enter an array of ints: ");
            int[] arr = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            WriteLine($"max distance = {MaxDist(arr)}"); // 7 0 0 0 0 5 6 7 5 0 7 5 3
            #endregion

            #region p8
            problem(8);
            Write("enter a sentence: ");
            string[] sentence = ReadLine().Split(' ');
            for (int i = sentence.Length - 1; i >= 0; --i)
                Write($"{sentence[i]} ");
            #endregion
        }
    }
}
