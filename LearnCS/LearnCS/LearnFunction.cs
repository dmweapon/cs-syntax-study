using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LearnCS
{
    internal class LearnFunction
    {
        // 함수 출력!
        public void PrintFunction()
        {
            // 문자 출력 함수
            string hi = "안녕하세요";
            PrintHI(hi);

            // 덧샘 함수
            Add(12, 13);
            Console.WriteLine(AddInt(4,6));
            Console.WriteLine(AddString("4", "6"));

            // 배열 내 모든 값의 합 출력 함수
            Console.WriteLine("배열합 출력 함수");
            int[] arr = new int[] {1, 3, 4, 56, 3331, 7234, 5, 322};
            TotalSum(arr);

            Console.WriteLine("함수 참조 샘플");
            int a = 1;
            int b = 2;
            Console.WriteLine("값 호출 실행전 : a = {0}, b = {1}", a, b);
            Swap(a, b);
            Console.WriteLine("값 호출 실행후 : a = {0}, b = {1}", a, b);

            Console.WriteLine("참조 호출 실행전 : a = {0}, b = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("참조 호출 실행후: a = {0}, b = {1}", a, b);


            Console.WriteLine("out 파라미터 함수 테스트");
            int c;
            parameterTypeOut(out c, 10, 20);
            Console.WriteLine("c의 값 : {0}", c);

            Console.WriteLine("TotalNumber 함수 출력(가변 파라미터)");
            Console.WriteLine(TotalNumber(123,54,45,2,32,5,3425,342,5));

            //모든 파라미터 받기
            Console.WriteLine("모든 파라미터 받는 함수");
            object[] obj = TotalEvery("asdf", true, 12312, 1212f, "hello");
            foreach (object i in obj) Console.WriteLine(i);
            for(int i = 0; i < obj.Length; i++)
            {
                /*Type t = obj[i].GetType();
                if (t.Equals(typeof(int)))
                {
                    Console.WriteLine("Type int : {0}", obj[i]);
                }*/

                if (obj[i].GetType().Equals(typeof(int)))
                {
                    Console.WriteLine("Type int : {0}", obj[i]);
                }
            }
            

        }


        // 함수 기본형
        static void PrintHI(string message)
        {
            Console.WriteLine(message);
        }

        static int AddInt(int a, int b)
        {
            return a + b;
        }

        static string AddString(string a, string b)
        {
            return a + b;
        }

        // 기본형 함수 응용
        static void TotalSum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr) sum += i;
            Console.WriteLine(sum);
        }

        // 함수 오버로딩
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Add(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        static void Add(string a, string b, string c)
        {
            Console.WriteLine(a + b + c);
        }


        // 함수 참조 - 값에 의한 호출
        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // 함수 참조 - 참조에 의한 호출
        // 파라미터에 대입하는 인자의 원본에 접근한다
        // ref int x는 a의 주소를 받음
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        
        static void parameterTypeOut(out int x, int y, int z)
        {
            // 변수가 선언만 되어있고 초기화가 되어있지 않을 때
            // 인자x의 값을 받아올 때 원본 변수에까지 대입
            x = y + z;
        }

        // 가변 파라미터
        static int TotalNumber(params int[] list)
        {
            int total = 0;
            foreach (int i in list) total += i;
            return total;
        }

        // 오브젝트 리스트 리턴
        static object[] TotalEvery(params object[] list) 
        {
            return list;
        }

        // 재귀 함수
        static int Factorial(int n) 
        { 
            if (n == 0) return 0;  // 매개변수 n의 값이 0이면 재귀함수 종료
            else return n + Factorial(n - 1);  // 0이 아니라면 자기 자신을 다시 호출
        }



    }
}
