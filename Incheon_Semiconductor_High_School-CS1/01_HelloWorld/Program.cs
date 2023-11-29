using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _001_HelloWorld
{
    /* https://whgkfkd.tistory.com/77 */ // 출력 강의 사이트
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");   // Hello, World! 출력

            int number = 10;
            Console.WriteLine(number); // number안에 있는 10 출력

            int x = 5;
            int y = 7;

            Console.WriteLine($"x: {x}, y: {y}");

            Console.ReadKey();
        }
    }
}