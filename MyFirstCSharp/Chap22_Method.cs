using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap22_Method : Form
    {
        // 메서드 

        // 1. 클래스의 주요 멤버. 클래스 멤버 - 메서드 멤버
        // 2. 프로그램 로직이 실제로 작동을 하는 코드 블럭
        //    - 다른 곳에서 해당 메서드를 호출하기 전까지는 아무런 의미가 없다. 
        //     * 객체지향의 코딩은
        //       언젠가는 호출을 하여 동작 을 하게 될 기능들은 나열해 두고 
        //       그 기능들을 조합 해서 프로그래밍(컴푸터가 알아듣게 명령) 수행 할수 있도록 하는것. 
        // 3. 반복 되는 코드를 특정위치에 등록해 두고 
        //    필요에 의해 호출하는 방식으로 재사용성을 높일 수 있다.(여러 포인트에서 같은 로직을 실행 하게 할 수 있다.)
        // 4. 메서드 내부의 로직 수정 시 일괄적으로 적용된 모든 코딩에서 변경 내용으로 구동 되게 수정 할 수있다. (유지보수성)
        // 5. 코딩이 간결해 지므로 가독성을 높일 수 있다. 

        public Chap22_Method()
        {
            InitializeComponent();
        }

        #region < 메서드의 호출 > 
        private void btnMethodCall_Click(object sender, EventArgs e)
        {
            // 메서드를 실행 , 메서드를 호출 
            // 동작을 시킬 메서드 를 호출 함으로서 메서드 내부의 로직을 수행. 
            ShowMessage();
            ShowMessage();
            ShowMessage();
        }
        void ShowMessage()
        {
            // 메서드의 기본 유형
            // [반환할 타입] [메서드 명] [전달 받을 내용]
            // Void          ShowMessage  ( ) 

            MessageBox.Show("메서드를 호출 하였습니다.");
        
        }
        #endregion

        #region < 인수와 인자 > 
        private void btnPaAr_Click(object sender, EventArgs e)
        {
            // 인수와 인자. 
            // 인자 : 메서드가 호출될때 꼭 받아야만 하는 데이터. 
            // 인수 : 메서드 를 호출할때 던져 주어야 만 하는 데이터.
            // 인자 와 인수 가 일치 해야만 메서드 기능을 동작 시킬 수 있다.

            // 메서드에 데이터를 전달하는 자료형 : 인수, 아규먼트
            // 데이터를 받는 곳, 자료형 : 인자, 매개변수, 파라매터.
            // 아! 수주 받자매 파.

            ShowMessage2("안녕하세요"); // 인수 
            ShowMessage2("반갑습니다.");
            ShowMessage2("불금되세요.");
        }

        void ShowMessage2(string message) // 인자. 
        {
            // ShowMessage2 를 호출하기 위해서는 문자열 을 전달 하면서 호출해야 한다. 
            // 호출된 ShowMessage2 메서드는 전달 받은 문자열을 메세지 박스로 표현한다. 
            MessageBox.Show(message);
        }

        #endregion
    }
}
