using System;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            if((a + 5 >=  b))
            {
                Console.WriteLine("No");
                return;
            }
            for (int n1 = a; n1 <= b - 4; n1++)
            {
                for (int n2 = a+1; n2 <= b -3; n2++)
                {
                    for (int n3 = a +2; n3 <= b-2; n3++)
                    {
                        for (int n4 = a +3; n4 <= b-1; n4++)
                        {
                            for (int n5 = a +4 ; n5 <= b; n5++)
                            {
                                if ( n2<n3 && n3<n4 && n4<n5 && n5<b)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
