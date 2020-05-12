using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int max = 0;
            int min = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                input = Console.ReadLine();
                if (i == 0){
                     min = int.Parse(input);
                     max = int.Parse(input);
                }
                else
                {
                    if (int.Parse(input) > max){
                         max = int.Parse(input);
                    }
                    if (int.Parse(input) < min)
                    {
                        min = int.Parse(input);
                    }
                }
            }
                Console.WriteLine("------------------------");
                Console.WriteLine("가장 큰 수: " + max);
                Console.WriteLine("가장 작은 수: " + min);
        }
    }
}
