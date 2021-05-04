using System;

namespace NOD
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
            Console.WriteLine("Алгоритм Евклида");
            Console.Write("кол-во чисел = ");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] data = new int[n];
            for (int i = 0; i < n; i++) {
                Console.WriteLine("{0}-е число", i+1);
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (n == 2)
            {
                Console.WriteLine(NOd(data[0], data[1]));
            }
            else {
                int temp = NOd(data[0], data[1]);
                for (int i = 2; i < n; i++) { 
                temp = NOd(temp, data[i]);
                }
                Console.WriteLine("нод получифся " + temp);
            }
           



        }
    }
}
