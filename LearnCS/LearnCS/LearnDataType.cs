using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class LearnDataType
    {
        public void DataTypeSample()
        {
            // 자료형 : 정수, 실수
            Console.WriteLine("=== 자료형 : 정수, 실수 ===");
            {
                byte a1 = 255; // 1byte 크기 : 0 ~ 255
                sbyte a2 = -128; // 1byte 크기 : -128 ~ 127
                short b1 = 32767; // 2byte 크기 : -32,768 ~ 32,767
                ushort b2 = 65535; // 2byte 크기 : 0 ~ 65535
                int c1 = 2147483647; // 4byte 크기 : -2,147,483,648 ~ 2,147,483,647
                uint c2 = 4294967295; // 4byte 크기 : 0 ~ 4,294,967,295
                long d1 = 922337203685477507; // 8byte 크기 : -922,337,203,685,477,508 ~ 922,337,203,685,477,507
                ulong d2 = 18446744073709551615; // 8byte 크기 : 0 ~ 18,446,744,073,709,551,615

                Console.WriteLine("a1 = " + a1);
                Console.WriteLine("a2 = " + a2);
                Console.WriteLine("b1 = " + b1);
                Console.WriteLine("b2 = " + b2);
                Console.WriteLine("c1 = " + c1);
                Console.WriteLine("c2 = " + c2);
                Console.WriteLine("d1 = " + d1);
                Console.WriteLine("d2 = " + d2);

                float e1 = 123.456789f; // 4byte 크기 : -3.402823e38 ~ 3.402823e38 (접미사 f 필요)
                double e2 = 1234.56789; // 8byte 크기 : 소숫점 15자리까지 표현 (접미사 없음)
                decimal e3 = 123424.10536415m; // 소숫점 33자리까지 표현  (접미사 m 필요)

                Console.WriteLine("e1 = " + e1);
                Console.WriteLine("e2 = " + e2);
                Console.WriteLine("e3 = " + e3);

            }
            
            // 자료형 : 상수 (변하지 않는 값)
            Console.WriteLine("=== 자료형 : 상수 (변하지 않는 값) ===");
            {
                // 상수는 선언과 동시에 초기값을 선언해야함!
                const int ca = 1; // 값 변경 불가
            }

            // 자료형 : 문자, 문자열
            Console.WriteLine("=== 자료형 : 문자, 문자열 ===");
            {
                char aa = 'H'; // 2byte 크기 : 문자 하나 표현 (홑따옴표)
                string bb = "ellow World"; // 24byte 또는 32byte 크기 : 문자열 표현, 공백도 문자열에 포함 (쌍따옴표)
                Console.WriteLine(aa + bb);
                Console.WriteLine("{0}{1}", aa, bb);
                // C#에서 string과 String은 결론은 같다.
                // String은 문자열을 다루는 클래스(System.String)
                // string은 C#에서 사용하는 System.String의 별칭(Alias)
            }
            
            // 자료형 : 논리
            Console.WriteLine("=== 자료형 : 논리 ===");
            {
                bool tt = true;
                bool ff = false;
                Console.WriteLine("tt : {0}, ff : {1}", tt, ff);
            }
            
            // 자료형 : 객체(object) - 박싱
            Console.WriteLine("=== 자료형 : 객체(object) - 박싱 ===");
            {
                object oa = 40;
                object ob = 12.1234f;
                object oc = true;
                object od = "잘부탁드립니다.";

                Console.WriteLine("정수 : {0}, 실수: {1}, 논리: {2}, 문자열: {3}", oa, ob, oc, od);
            }
            
            // 형 변환
            Console.WriteLine("=== 형 변환 ===");
            {
                // 암시적 형 변환(작은 크기의 data를 더 큰 그릇에 담을 때 자동으로 형변환)
                int aaa = 30;
                float bbb = aaa;
                Console.WriteLine("aaa : {0}, bbb : {1}", aaa, bbb);

                // 명시적 형 변환(큰 크기의 data를 작은 그릇에 담을 때)
                float ccc = 123.34f;
                int ddd = (int) ccc; // 소숫점 부분은 버림
                Console.WriteLine("ccc : {0}, ddd : {1}", ccc, ddd);

                // 숫자를 문자로 변환
                int eee = 87;
                float fff = 3298.22f;
                string sa = eee.ToString();
                string sb = fff.ToString();
                Console.WriteLine("int:{0}, float:{1}, string sa:{2}, string sb:{3}", eee, fff, sa, sb);

                // 문자형인 숫자를 숫자로 변환
                string sc = "123";
                string sd = "123.456";
                Console.WriteLine("문자 123 + 123.456 = " + (sc + sd) );
                
                int se = int.Parse(sc); // 문자열을 정수로 변환
                float sf = float.Parse(sd); // 문자열을 실수로 변환
                Console.WriteLine("string sc:{0}, string sd{1}, int se:{2}, float sf:{3}", sc, sd, se, sf);

            }
            
            // 수식연산
            Console.WriteLine("=== 수식연산 ===");
            {
                int cA = 155;
                int cB = 4;

                Console.WriteLine("cA + cB = {0}", cA + cB);
                Console.WriteLine("cA - cB = {0}", cA - cB);
                Console.WriteLine("cA * cB = {0}", cA * cB);
                Console.WriteLine("cA / cB = {0}", cA / cB);
                Console.WriteLine("cA % cB = {0}", cA % cB);
            }
            
            // 할당 연산자, 대입 연산자
            Console.WriteLine("=== 할당 연산자, 대입 연산자 ===");
            {
                int setA = 36;
                int setB = 44;
                setA += setB; // setA = setA + setB
                Console.WriteLine("setA : {0}", setA);
                setA -= setB; // setA = setA - setB
                Console.WriteLine("setA : {0}", setA);
                setA *= setB; // setA = setA * setB
                Console.WriteLine("setA : {0}", setA);
                setA /= setB; // setA = setA / setB
                Console.WriteLine("setA : {0}", setA);
                setA %= setB; // setA = setA % setB
                Console.WriteLine("setA : {0}", setA);
            }
            
            // 증감 연산자
            Console.WriteLine("=== 증감 연산자 ===");
            {
                int indeA = 1;
                Console.WriteLine(indeA);
                Console.WriteLine(++indeA); // 전위 증가 연산자, indeA의 값을 먼저 1 증가시키고 indeA의 값 출력(기능실행)
                Console.WriteLine(indeA--); // 후위 증가 연산자. 먼저 값 출력(기능실행) 후 indeA의 값을 1 증가
                Console.WriteLine(indeA);

                Console.WriteLine(--indeA); // 전위 감소 연산자, indeA의 값을 먼저 1 감소시키고 indeA의 값 출력(기능실행)
                Console.WriteLine(indeA--); // 후위 감소 연산자, 먼저 값 출력(기능실행) 후 indeA의 값을 1 감소
            }
            
            // 관계(논리) 연산자
            Console.WriteLine("=== 관계(논리) 연산자 ===");
            {
                int reA = 5;
                int reB = 3;
                Console.WriteLine(reA < reB); // False
                Console.WriteLine(reA <= reB); // False
                Console.WriteLine(reA > reB); // True
                Console.WriteLine(reA >= reB); // True
                Console.WriteLine(reA == reB); // False
                Console.WriteLine("하이" == "하이"); // True
                Console.WriteLine("하이" != "안녕"); // False
            }
            
            // 비트 연산
            Console.WriteLine("=== 비트 연산 ===");
            {
                int bitA = 6;
                int bitB = 12;
                int bitC = 0;

                // 논리합 |
                bitC = bitA | bitB;

                // 논리곱 &
                bitC = bitA & bitB;
                Console.WriteLine(Convert.ToString(bitA, 2).PadLeft(8, '0'));
                Console.WriteLine(Convert.ToString(bitB, 2).PadLeft(8, '0'));
                Console.WriteLine(Convert.ToString(bitC, 2).PadLeft(8, '0'));

                // 부정 ^
                bitC = bitA ^ bitB;

                // 비트 보수 연산 ~
                Console.WriteLine(Convert.ToString(bitA, 2).PadLeft(32, '0'));
                Console.WriteLine(Convert.ToString(~bitA, 2).PadLeft(8, '0'));
                Console.WriteLine(bitA);
                Console.WriteLine("뒤집어:{0}", ~bitA);
                Console.WriteLine("보수:{0}", ~bitA+1); // 보수는 변수를 뒤집은 후 1 더하기

                // 왼쪽 시프트 연산 <<
                Console.WriteLine(Convert.ToString(bitB, 2).PadLeft(32, '0'));
                Console.WriteLine(Convert.ToString(bitB << 4, 2).PadLeft(32, '0'));
                Console.WriteLine(bitB);
                Console.WriteLine(bitB << 4);

                // 오른쪽 시프트 연산 >>
                // 생략ㅎㅎ
            }
            
            // 조건문(if문) ==========================================================
            // if문이 switch문보다 더 많은 코드를 읽어야함.
            Console.WriteLine("=== 조건문(if문) ===");
            {
                // 변수 선언
                int ifA = 11;
                int ifB = 5;
                int ifC = 2;
                bool isFact = true;

                // 조건문 기본구조
                if (ifA < ifB) // 여기서 참이면 "else if"와 "else" 구문을 건너뜀. if문을 두번 쓰면 두 if문 모두 읽어야 해서 비효율적이다.
                {
                    Console.WriteLine("참이면 실행1 - if");
                } else if (ifA > ifB)
                {
                    Console.WriteLine("참이면 실행2 - else if");
                }
                else {
                    Console.WriteLine("거짓이면 실행 - else");
                }

                // 조건문 간소화
                if (ifA == ifB) Console.WriteLine("ifA와 ifB는 같다");
                if (ifA != ifB)
                    Console.WriteLine("ifA와 ifB는 다르다");

                // 조건문 + 관계(논리)연산자
                if (isFact == true) Console.WriteLine("isTrue값은 참이다");
                if (isFact != true) Console.WriteLine("isTrue값은 참이 아니다");
                if (!isFact == true) Console.WriteLine("isTrue값의 반대값은 참이다");
                if (isFact && ifA > ifB) Console.WriteLine("두 조건 모두 참이다.");
                if (isFact || ifA < ifB) Console.WriteLine("두 조건 중 하나 이상 참이다.");
                // 왼쪽에서 오른쪽으로 순차적으로 판단
                if (isFact && ifA < ifB || ifA < ifC) Console.WriteLine("3조건 중 조건1과 조건2가 참이거나 조건3이 참이다.");

                // 조건문 중첩



            }

            // 조건문(switch문) =========================================================
            // if문보다 간결하고 빠르나 else에 대한 처리 필요
            Console.WriteLine("=== 조건문(switch문) ===");
            {
                string name = "";

                switch (name)
                {
                    case "Tom":
                        Console.WriteLine();
                         break;
                    case "Jeue":
                        Console.WriteLine();
                        break;
                }

                // 랜덤 값 생성
                Random ran = new Random();
                int ranA = ran.Next(11, 14); //0~9까지의 값 중 값 1개 반환 (시작 수, 마지막 수-1)
                Console.WriteLine("랜덤값A = " + ranA);

                switch (ranA)
                {
                    case 11:
                        Console.WriteLine("스위치문 = 11");
                        break;
                    case 12:
                        Console.WriteLine("스위치문 = 12");
                        break;
                    case 13:
                        Console.WriteLine("스위치문 = 13");
                        break;
                }
            }

            // 반복문(for, while, do while, foreach) ======================================
            Console.WriteLine("=== 반복문(for, while, do while, foreach문) ===");
            {
                Random ranF = new Random();

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("i = {0}", ranF.Next(1, 101));
                }

                int whileA = 0;
                while (whileA < 5)
                {
                    Console.WriteLine("whileA = {0}", whileA++);
                }

                int doA = 0;
                do
                {
                    Console.WriteLine("do while은 최소 한 번은 실행");
                    Console.WriteLine("doA = {0}", doA++);
                } while (doA < 0);

                int[] foreachA = { 101, 102, 103, 104, 105 };

                foreach(int foreachB in foreachA)
                {
                    Console.WriteLine("foreachB = {0}", foreachB);
                }

            }

            // 제어문(break, continue, goto) ==============================================
            Console.WriteLine("=== 제어문(break, continue, goto) ===");
            {
                // break
                for(int forA = 0; forA < 9; forA++)
                {
                    Console.WriteLine("i = {0}", forA);
                    if (forA == 5) break; // forA가 5이면 for문에서 나옴
                }

                int whileB = 0;
                while(whileB < 5)
                {
                    Console.WriteLine("whileB = {0}", whileB++);
                    if (whileB == 3) break; // whileB가 5이면 for문에서 나옴
                }

                //continue
                for (int forB = 0; forB < 5; forB++)
                {
                    if (forB == 2) continue; // i가 5이면 이하 코드 건너뛰고 다시 반복문 이어서 진행
                    Console.WriteLine("forB = {0}", forB);
                }

                // 별찍기 예제 (for문 활용)
                Console.WriteLine("=== 별찍기 예제(for문 활용) ===");
                {
                    // 별찍기 예제 : 증가 + 왼쪽 정렬
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < i + 1; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine("");
                    }

                    // 별찍기 예제 : 감소 + 왼쪽 정렬
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5 - i; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine("");
                    }

                    // 별찍기 예제 : 증가 + 오른쪽 정렬
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 4 - i; j++)
                        {
                            Console.Write(" ");
                        }
                        
                        for (int j = 0; j < i + 1; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine("");
                    }

                    // 별찍기 예제 : 감소 + 오른쪽 정렬
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < 5 - i; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine("");
                    }
                }
                
            }

            // 1차원 배열(array) =========================================
            Console.WriteLine("=== 1차원 배열(array) ===");
            {
                // 배열 선언
                int[] arrA = new int[8]; // 8은 배열 크기
                Random rand = new Random();

                for (int i = 0; i < arrA.Length; i++)
                {
                    arrA[i] = rand.Next(100);
                    Console.WriteLine("arrA[{0}] = {1}",i, arrA[i]);
                }

                // 배열 선언&값 대입
                // 값 만큼 크기 자동 설정
                int[] arrB = new int[] { 5, 12, 62, 84, 93, 12 };
                int cnt = 0;

                foreach (int i in arrB)
                {
                    Console.WriteLine("arrB[{0}] = {1}", cnt++, i);
                }

                string[] arrDay = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
                foreach (string i in arrDay) Console.WriteLine(i);

                // 배열 정렬 --------------------------------
                Console.WriteLine("--- 배열 정렬 ---");
                // 임의 배열 정의
                Random rand2 = new Random();
                int[] arrC = new int[4];

                for(int i = 0; i < arrC.Length; i++)
                {
                    arrC[i] = rand2.Next(10);
                    Console.WriteLine("arrC[{0}] : {1}", i, arrC[i]);
                }
                
                // 오름차순(수동)
                for (int i = 0; i < arrC.Length; i++)
                {
                    for (int j = i+1; j < arrC.Length; j++)
                    {
                        if (arrC[i] > arrC[j])
                        {
                            // 둘의 값 변경
                            int temp = arrC[i]; // arrC[i]의 값을 임시저장
                            arrC[i] = arrC[j];
                            arrC[j] = temp;
                        }
                    }
                }
                Console.WriteLine("오름차순");
                foreach (int i in arrC) Console.WriteLine(i);

                // 오름차순(함수) - 내림차수 함수는 따로 없어서 Reverse를 통해서 내림차순으로 다시 정렬
                //Array.Sort(arrC);
                Array.Reverse(arrC);
                Console.WriteLine("내림차순");
                foreach (int i in arrC) Console.WriteLine(i);
            }

            // 2차원 배열(arry) =========================================
            Console.WriteLine("=== 2차원 배열(array) ===");
            {
                //int[,] arr2A = new int[,] {
                int[,] arr2A = new int[3,4] { 
                    {1,2,3,4},
                    {4,5,6,7},
                    {7,8,9,10}
                };

                // 특정 배열 값 출력
                Console.WriteLine(arr2A[2,3]);

                // 모든 배열 값 출력1
                for(int i = 0; i < arr2A.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2A.GetLength(1); j++)
                    {
                        Console.WriteLine("arr[{0},{1}] : {2}", i,j, arr2A[i,j]);
                    }
                }

                // 모든 배열 값 출력2
                foreach (int i in arr2A) Console.WriteLine(i);


                Console.WriteLine("배열문제 기본 시작");
                // 배열문제 기본 ( 배열에 1~25 숫자 대입)
                int[,] arr = new int[5, 5];
                int idx = 1;

                for (int i = 0; i < arr.GetLength(0); i++) {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = idx++;
                    }
                }
                // 배열문제 기본 출력
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", arr[i,j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("배열문제 기본 끝");

                Console.WriteLine("배열문제1 시작");
                // 배열문제1
                int[,] arr1 = new int[5, 5];
                int idxAsc1 = 1;
                int idxDes1 = 25;

                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        arr1[i, j] = idxDes1--;
                    }
                }
                // 배열문제1 출력
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", arr1[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("배열문제1 끝");

                Console.WriteLine("배열문제2 시작");
                // 배열문제2
                int[,] arr2 = new int[5, 5];
                int idxAsc2 = 1;
                int idxDes2 = 25;

                for (int i = 0; i < arr2.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2.GetLength(1); j++)
                    {
                        //arr2[j, i] = idxAsc2++; // 대입하는 행과 열의 배치만 교체...!
                        // 주석만 사용하거나 아래 방법으로
                        arr2[i, j] = (5 * j) + idxAsc2;
                    }
                    // 주석 해제시 아래 라인 삭제
                    idxAsc2++;
                }
                // 배열문제2 출력
                for (int i = 0; i < arr2.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", arr2[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("배열문제2 끝");

                Console.WriteLine("배열문제3 시작");
                // 배열문제3
                int[,] arr3 = new int[5, 5];
                int idx3 = 1;

                for (int i = 0; i < arr3.GetLength(0); i++)
                {
                    for (int j = 0; j < arr3.GetLength(1); j++)
                    {
                        if (i%2 == 0)
                        {
                            arr3[i, j] = idx3++;
                        } else
                        {
                            arr3[i, j] = (arr3.GetLength(1) * (i+1)) - j;
                            idx3++;
                        }
                    }
                }
                // 배열문제3 출력
                for (int i = 0; i < arr3.GetLength(0); i++)
                {
                    for (int j = 0; j < arr3.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", arr3[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("배열문제3 끝");

                Console.WriteLine("배열문제4 시작");
                // 배열문제4
                int[,] arr4 = new int[5, 5];
                int idx4 = 1;

                for (int i = 0; i < arr4.GetLength(0); i++)
                {
                    for (int j = 0; j < arr4.GetLength(1); j++)
                    {
                        
                    }
                }
                // 배열문제4 출력
                for (int i = 0; i < arr4.GetLength(0); i++)
                {
                    for (int j = 0; j < arr4.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", arr4[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("배열문제4 끝");



            }
        }
    }
}
