using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyFirstCSharp.Lesson05_Class
{

    /*
         상속 
         클래스에 있는 기능을 물려주어 (부모클래스 )
         상속받은 클래스(자식 클래스) 는 부모의 기능을 모두 사용할 수 있으면서 
         추가로 더 많은 기능을 구현하여 적용 할 수 있도록 하는 기능.
     */
    partial class Chap35_Inheritance : Form // 클래스의 기본유형 public
    {
        public Chap35_Inheritance()
        {
            InitializeComponent();
        }

        #region < 중첩 클래스 > 
        public class MyClass
        {
            // 중첩 클래스 기본유형 private
            // 클래스 내에 또 다른 클래스가 정의된 형태
            // 외부에 정의하는 것보다 자신만 사용할 수 있는 클래스를 작성하고 싶을때
            // 클래스 내부에서만 사용될 수 있도록 작성하는 형태. 
            // public 으로 설정 시 중첩 클래스의 의미가 없어진다. 
            // public 으로 설정 시 외부에 공개한다는 의미 이므로
            // 바깥쪽에(namespce) 클래스를 작성 해 주는것이 좋다.

            public string sValue;
            private void DoSomthig()
            {

            }
        }
        #endregion

        #region < 상속 예제 >
        // 기능을 물려 줄 부모 클래스 
        class Parents
        {
            public string sParents = "부모전역 문자열 변수";
            public void ParentsMethod()
            {
                MessageBox.Show("부모 클래스의 메서드를 호출 합니다.");
            }
        }

        class Child : Parents // Parenrs 클래스를 상속 받는 Child 클래스
        {
            public string sChild = "자식 전역 문자열 변수";
            public void ChildMethod()
            {
                MessageBox.Show("자식 클래스의 메서드 를 호출 하였습니다.");
            } 
        }

        private void btnInheritance_Click(object sender, EventArgs e)
        {
            // 상속한 결과를 확인
            Child child = new Child();
            MessageBox.Show(child.sParents); // 부모클래스의 필드멤버 호출. 
            child.sParents = "부모전역 변수 값의 변경이 가능합니다.";
            MessageBox.Show(child.sChild);

            child.ParentsMethod(); // 부모클래스의 메서드 멤버를 호출가능.
        }


        #endregion


        #region < 랜덤 클래스의 상속 > 
        class MyRandom : Random
        {
            // random 클래스를 상속 
            public int ReturnRandom()
            {
                // base (부모 클래스 를 지칭)   Random
                // this (자신의 클래스를 지칭)  MyRandom
                return base.Next(0, 11); 
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            MyRandom myrandom = new MyRandom();
            myrandom.ReturnRandom(); // 랜덤 클래스를 상속 받은 MyRandom 에 있는 메서드 호출.
            myrandom.Next(0, 200); // 부모 클래스에 있는 기능을 그대로 사용 가능.
        }


        // 상속을 하지 못하도록 하는 키워드 seald
        // 상속에 대한 접근을 제한.

        sealed class Parents2
        {
            // 상속을 할 수 없게 만든 클래스.
             
        }
        //class Mystring : string
        //{

        //}

        //class Child2 : Parents2
        //{
        //    // sealed 형식의 클래스는 상속 받을 수 없다.
        //}
        #endregion
    }
}
