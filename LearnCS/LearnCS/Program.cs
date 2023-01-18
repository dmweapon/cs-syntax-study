using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LearnCS.LearnDataType displayDataType = new LearnDataType();
            displayDataType.DataTypeSample();

            LearnCS.LearnFunction functionSample = new LearnFunction();
            functionSample.PrintFunction();

            // Human클래스 someone 생성
            Human someone = new Human();
            someone.age = 15;
            someone.height = 180.8f;
            someone.name = "sangil";
            someone.gender = "m";
            Console.WriteLine("[someone프로필]");
            Console.WriteLine("이름 : {0}, 나이 : {1}, 키 : {2}, 성별 : {3}", someone.name, someone.age, someone.height, someone.gender);

            someone.Eat();
            someone.Move();

            // Moster클래스 diablo 생성
            Monster diablo = new Monster();
            diablo.hp = 1000000;
            Console.WriteLine(diablo.hp);
            diablo.Attack();
            
            TestPrivate testPrivate = new TestPrivate();
            

            // enum값 테스트
            CITY city = CITY.SEOUL;
            Console.WriteLine("도시이름 : {0}", city);
            city = (CITY) 3;
            Console.WriteLine("도시이름 : {0}", city);

        }

        // 왜 기본 생성자가 실행되지 않지...?
        Child child = new Child();


    }
}
