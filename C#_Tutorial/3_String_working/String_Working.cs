using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string index = "ABCDEFG";

            Console.WriteLine(index[0]); // string은 배열을 읽는 것처럼 읽을 수 있다.
            Console.WriteLine(index.Contains("ABC")); // 문자열에 ABC가 포함되어있다면 True 반환, 아니면 False 반환
            Console.WriteLine(index.Substring(3)); // DEFG 출력
            Console.WriteLine(index.Substring(2, 4)); // CDFG 출력
            Console.WriteLine(index.ToUpper()); // 전부 대문자로 출력
            Console.WriteLine(index.ToLower()); // 전부 소문자로 출력
            Console.WriteLine(index.Length); // 문자열 길이 출력
            Console.WriteLine(index.IndexOf('C')); // 문자열에서 문자 위치 찾기
        }
    }
}
