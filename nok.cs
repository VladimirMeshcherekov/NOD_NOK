using System;

namespace nok
{
    class Program
    {
        static int NOd(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int nok = 0;
            Console.WriteLine("Алгоритм Евклида");
            Console.Write("кол-во чисел = ");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] data = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}-е число", i + 1);
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (n == 2)
            {
                Console.WriteLine((data[0] * data[1])/NOd(data[0], data[1]));
            }
            else
            {
                int temp = NOd(data[0], data[1]);
                nok = (data[0] * data[1]) / temp;
                for (int i = 2; i < n-1; i++)
                {
                    temp = NOd(data[i], data[i+1]);
                    nok = (nok * data[i]) / temp;
                }
                Console.WriteLine("нок получифся " + nok);
            }




        }
    }
}
