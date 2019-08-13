using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.FrameWork
{
    public class Test
    {
        public string a { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Factorial(100011111);
            //Console.WriteLine(sum);
            //Console.ReadLine();
            //Test test = new Test();
            //test.a = "1111";
            //new Program().Change(out test);
            //Console.WriteLine(test.a);
            //Console.ReadLine();


        }

        public void Change(out Test test)
        {
            test = new Test();
            test.a = "123456";
            //test = new Test();
            //test.a = "6666666";
            Console.WriteLine(test.a);
        }





        public static void Factorial(int value)
        {
            int[] result = new int[10000];
            int result_size = 1;//实时更新result的实际位数
            int carryBit = 0;   //进位的值
            result[0] = 1;//初始结果为1

            for (int i = 2; i <= value; i++)
            {
                for (int j = 0; j < result_size; j++)
                {
                    int temp = result[j] * i
                        + carryBit;
                    result[j] = temp % 10;
                    carryBit = temp / 10;
                }
                while (carryBit != 0)
                {
                    result[result_size] = carryBit % 10;
                    result_size++;
                    carryBit = carryBit / 10;
                }
            }
            Console.WriteLine("{0}的阶乘结果：", value);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
        }
    }
}