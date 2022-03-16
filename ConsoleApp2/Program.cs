using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            double c = 999D;
            char op;

            Console.Write("請輸入第一個數字：");
            num1 =  Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入第二個數字(不能為0)：");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入運算子(+、-、*、/)：");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+':
                    Console.WriteLine("{0}", num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("{0}", num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("{0}", num1 * num2);
                    break;
                case '/':
                    Console.WriteLine("{0}", Convert.ToDouble(num1) / num2);
                    break;
                default:
                    Console.WriteLine("無法執行你的運算");
                    break;
            }
            if (c!=999D)
            Console.WriteLine("計算結果是：{0}",c);
            Console.ReadLine();
        }
    }
}
