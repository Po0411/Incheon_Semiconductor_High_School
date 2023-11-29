using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Data
{
    /* https://whgkfkd.tistory.com/77 */ // 출력 강의 사이트
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("다양한 출력");
            Console.WriteLine("해보기");

            Console.WriteLine("{0} * {1} = {2}", 2, 10, 200);

            Console.WriteLine("    *    ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****  ");

            int a = 0b11111111; //2진수 리터럴 접두사0b(0B)
            int b = 0xFF;       //16진수 리터럴 접두사0x(0X)

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: " + b);

            char ak = 'A'; //아스키 코드값: 65
            int num = a;

            Console.WriteLine("문자: {0}, 아스키코드값: {1}, 문자로 캐스트 연산: {2}", a, num, (char)num);

            const int MAX = 100; //상수
            const int MIN = 0;

            Console.WriteLine("MIN:{0}  ~ MAX:{1}", MIN, MAX);

            Console.ReadKey();
        }
    }
}