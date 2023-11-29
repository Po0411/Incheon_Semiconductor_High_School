using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
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

            float pi = 3.14159f; //실수형 선언 (뒤에 "f"는 필수)
            Console.WriteLine($"원주율: {pi}");

            string message = "Hello, World!";
            Console.WriteLine(message); // message 안에 있는 Hello, World! 출력

            string name = "홍길동";
            int age = 25;

            Console.WriteLine($"제 이름은 {name}이고 나이는 {age}살입니다.");
            // 제 이름은 홍길동이고 나이는 25살입니다.

            Console.ReadKey();
        }
    }
}