using System;

namespace Recursion
{
    internal class Program
    {
        //С помощью рекурсии найдите сумму цифр данного натурального числа.
        //
        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine(SumNum(n));
        //    Console.ReadLine();

        //}

        //private static int SumNum(int n)
        //{
        //    if (!(n > 0))
        //    {
        //        return 0;
        //    }
        //    int sum = n + SumNum(n - 1);

        //    return sum;
        //}

        //Напишите рекурсивную функцию, печатающую цифра натурального числа в а) прямом; б) обратном порядке.
        //
        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    Num(n);
        //    Console.WriteLine();
        //    NumReverse(n);
        //    Console.ReadLine();

        //}

        //private static int Num(int n)
        //{
        //    if (!(n > 0))
        //    {
        //        return 0;
        //    }

        //    int t = Num(n - 1);
        //    Console.Write("{0} ",n);

        //    return t;
        //}

        //private static int NumReverse(int n)
        //{
        //    if (!(n > 0))
        //    {
        //        return 0;
        //    }
        //    Console.Write("{0} ", n);
        //    int t = NumReverse(n - 1);

        //    return t;
        //}

        //Даны a и N. Вычислите aN без использования логарифма и экспоненты.
        //
        //static void Main(string[] args)
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine(Degree(a, n));
        //    Console.ReadLine();
        //}

        //static int Degree(int a, int n)
        //{
        //    if (!(n > 1))
        //    {
        //        return a;
        //    }

        //    int t = a*Degree(a,n - 1);

        //    return t;
        //}

        //Заданы две строки a и b с длинами m и n. Найдите максимальную длину их общей подпоследовательности символов.
        //Например, для "орел" и "осел" это "оел" длины 3.
        //
        //static void Main(string[] args)
        //{
        //    string a = Console.ReadLine();
        //    string b = Console.ReadLine();
        //    string c = !(a.Length > b.Length) ? a : b;
        //    Console.WriteLine(Compare(a, b, c.Length));
        //    Console.ReadLine();
        //}

        //static int Compare(string a, string b, int c)
        //{
        //    if (!(c > 0))
        //    {
        //        return 0;
        //    }
        //    int temp = a[c-1] == b[c-1] ? 1 + Compare(a, b, c - 1) : Compare(a, b, c - 1);
        //    return temp;
        //}
        //
        //static int Compare(string a, string b)
        //{
        //    string c = !(a.Length > b.Length) ? a : b;
        //    int temp = 0;
        //    for (int i = 0; i < c.Length; i++)
        //    {
        //        if (a[i] == b[i])
        //        {
        //            temp++;
        //        }
        //    }
        //    return temp;
        //}
    }
}
