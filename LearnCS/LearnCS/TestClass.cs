using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LearnCS
{

    class Human
    {
        // 상태. 맴버 변수, 필드
        public int age;
        public string name;
        public string gender;
        public float height;

        // 생성자
        // 생성자가 없으면 기본 생성자가 자동으로 호출됨
        public Human()
        {
            Console.WriteLine("클래스 생성시 기본생성자 호출");
        }

        // 기능. 맴버 함수.
        public void Eat()
        {
            Console.WriteLine("냠냠");
        }

        public void Move()
        {
            Console.WriteLine("뚜벅");
        }

    }

    public class Monster
    {
        // 상태. 맴버 변수, 필드
        public float hp;
        public float demage;

        // 기능. 맴버 함수.
        public void Attack()
        {
            Console.WriteLine("이얍");
        }

        public void Move()
        {
            Console.WriteLine("뚜벅");
        }

    }

    class TestPrivate
    {
        // 접근 제한자가 없을 경우 기본이 private으로 적용
        private int age;
        string name;

        private void Test()
        {
            Console.WriteLine("나이 : {0}, 이름 : {1}", age, name);
        }
        public void SetInfo(int _age, string _name)
        {
            age = _age;
            name = _name;
            Test();

        }

    }
    
    public enum CITY
    {
        SEOUL,
        INCHON,
        DEAGU,
        BUSAN
    }


    // 상속
    internal class Parents
    {
        protected int age = 60;
        protected string name = "gotFather";
        public Parents()
        {
            Console.WriteLine("부모의 나이 : {0}", age);
        }
    }

    // Parents 클래스를 상속 받은 파생/자식 클래스
    internal class Child : Parents
    {
        public Child()
        {
            Console.WriteLine("Overriding 전의 age값 : {0}", age);
            age = 5;
            Console.WriteLine("자식의 나이 : {0}", age);
        }
    }
}
