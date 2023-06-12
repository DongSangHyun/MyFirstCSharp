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

            string sMessage = "불금되세요";
            ShowMessage2(sMessage);
        }

        void ShowMessage2(string message) // 인자. 
        {
            // ShowMessage2 를 호출하기 위해서는 문자열 을 전달 하면서 호출해야 한다. 
            // 호출된 ShowMessage2 메서드는 전달 받은 문자열을 메세지 박스로 표현한다. 
            MessageBox.Show(message);
        }

        #endregion

        #region < 아무 값을 반환하지 않는 메서드 리턴 Void >
        private void btnVoidReturn_Click(object sender, EventArgs e)
        {
            VoidReturnMethod("안녕하세요"); // 메서드를 호출.
        }

        void VoidReturnMethod(string smessage)
        {
            // Void [메서드 이름]
            // Void : 아무런 값을 반환하지 않는 메서드.
            //       . 아무런 값을 반환하지 않아도 된다는 약속을 한 메서드 이므로. 
            //       . 메서드 내에 return; 구문이 없어도 된다.

            MessageBox.Show(smessage);
            txtTitle.Text = smessage;
            return;  // 메서드를 호출한 곳으로 로직을 반환 
                     // 메서드를 종료 하라는 의미 보다는 호출한 곳으로 돌아가라는 의미가 더 맞는표현
                     
            
            // 바로 직전 로직에서 return ; 이 있으므로 실행되지 않는 구문.
            lblTitle.Text = smessage;
        }
        #endregion

        #region < string 값을 반환하는 리턴 메서드 >
        private void btnStringReturn_Click(object sender, EventArgs e)
        {
            // 반환 데이터 형식이 지정된 메서드 
            //   . 1. 메서드를 호출한 곳에서 반환값을 전달받아 후속 로직을 구현할 수 있도록 해준다.
            
            string sResult = StringReturnMethod("문자열을 전달합니다.");
            MessageBox.Show(sResult); // 문자열을 반환합니다.

            // 2. 반환 데이터가 있는 메서드를 호출 할때 값을 전달 받지 않아도 무관.
            StringReturnMethod("반환값을 받지 않는 메서드 호출");

        }

        string StringReturnMethod(string sMessage)
        {
            // string 형식의 데이터를 호출한 곳으로 반환하기로 약속한 메서드. 
            // 3. return 구문으로 string 을 반환해 주지 않으면 오류가 발생.(컴파일)
            
            MessageBox.Show(sMessage); // 문자열을 전달합니다.
            sMessage = "문자열을 반환합니다."; // 할당.
            return sMessage;
        }
        #endregion

        #region < int 값을 반환하는 리턴 메서드 > 
        private void btnIntReturn_Click(object sender, EventArgs e)
        {
            int iValue1 = 10;
            int iValue2 = 20;

            
            MessageBox.Show(intSumReturnMethod(iValue1, iValue2).ToString());
            // 위 로직은 아래와 같이 표현 할 수 있다. 
            //int iResult = 0;
            //iResult = intSumReturnMethod(iValue1, iValue2); // iValue1 과 iValue2 의 합 을 할당.
            //MessageBox.Show(iResult.ToString());
        }
        
        int intSumReturnMethod(int iV1, int iV2)
        {
            // 정수 2개 를 인자로 받아 합한 결과를 리턴 메서드
            int iResult = iV1 + iV2; // iV1 과 iV2 인자에 어떠한 정수값이 오더라도 
                                     // 합한 결과를 반환하는 공통 메서드.

            // int 형을 반환하기로 약속한 메서드
            return iResult;
        }
        #endregion

        #region < 인자가 기본 값을 가지는 메서드 ( 선택적 인수 ) >
        private void btnDefaultParameter_Click(object sender, EventArgs e)
        {
            // 메서드 에서 전달 받을 인자 의 유형에 상관없이 메서드를 호출 하고 싶을때. 


            //1. 예를 들어 생성되어있는 메서드를 호출 한 로직이 여러번 구현되어있을때
            
            //2. 1번사용
            DefaultParameter(10, 20);

            //3. 다른로직에서 등록한 메서드 사용.
            DefaultParameter(30, 40);

            //4. 다른 로직에서 등록한 메서드를 사용.
            DefaultParameter(60, 20);

            //5. 어떤 이유로 인하여 값을 3개를 합해야 하는 상황이 발생.
            //7. 기존의 메서드호출하는 구현부 에서 오류 가 발생.
            //8. 선택적 인수 라는 개념을 적용 할 수 있다.

            //10. 새로운 로직을 적용하여 기존의 메서드를 재사용 할수 있다. 
            DefaultParameter(10, 20, 30); // 3번째 인수로 30 을 전달 할 경우 10 + 20 + 30 의 결과를 확인 할 수 있다.
        }

        // 선택적 인수 로 호출 할 수 있는 메서드를 생성.
        //void DefaultParameter(int iValue, int iValue2, int iValue3)// 6. 필요에 의해 인자를 1개 더 추가. 
        void DefaultParameter(int iValue, int iValue2 , int iValue3 = 10) // 9. 인자에 기본값을 설정 (선택적 인수 적용)
        {
            // 인자 값에 기본값을 설정 할 경우 
            // 중간에 있는 인자에 만 기본값 설정 인자로 만들수 없다. 
            // 마지막인자 들 에만 선택적 인수를 적용 할 수 있다. 
            MessageBox.Show((iValue + iValue2 + iValue3).ToString()); // 전달 받은 인자를 합하여 표현.
        }
        #endregion

        #region < 클래스를 인수로 전달 하는 메서드 > 
        private void btnCatch1_Click(object sender, EventArgs e)
        {
            // 두개의 버튼 클래스의 Text 속성을 변경 하는 로직 이 반복적으로 나타날 경우
            // 버튼 클래스를 인자로 받는 메서드를 생성 후 
            // 인수로 던져주는 버튼 클래스 별로 가변적으로 처리 될 수 있도록 구현 할 수 있다.
         
            btnChtch(btnCatch1, btnCatch2);
            //btnCatch1.Text = "";
            //btnCatch2.Text = "나잡아 봐라~";
        }
        private void btnCatch2_Click(object sender, EventArgs e)
        {
            btnChtch(btnCatch2, btnCatch1);
            //btnCatch2.Text = "";
            //btnCatch1.Text = "나잡아 봐라~";
        }
        // 버튼을 클릭 하였을 경우 text 를 옮겨 다니는 기능을 할 메서드
        void btnChtch(Button btn_Hide , Button btn_Show)
        {
            btn_Hide.Text = "";
            btn_Show.Text = "나잡아 봐라~";
        }

        #endregion

        #region < 인수를 배열로 전달하는 경우 ( 참조 주소값을 전달 ) > 
        private void btnArrayArgument_Click(object sender, EventArgs e)
        {
            // 배열 을 인수로 전달 하는, 배열을 인자로 받는 메서드.

            string[] sValues = { "안녕하세요", "반갑습니다.", "C#프로그래밍" };

            // 배열을 전달 후 배열의 결과 확인.
            ArrayArgMethod(sValues);
            MessageBox.Show(sValues[0]); // 안녕하세요. 

            // 배열을 전달 후 메서드 내에서 수정이 이루어 졌을 경우 
            // 호출한 곳에 있는 전달 한 배열의 결과 확인.
            ArrayChangeMethod(sValues);
            MessageBox.Show(sValues[0]); // C# 프로그래밍 

            // 값 형식의 데이터를 전달 하는 경우 
            // Stack 에 있는 값 자체를 복사 하므로 
            // 메서드 내에 값이 변경 되더라도 인수의 값은 변형 되지 않는다. 
            string sMessage = "안녕하세요";
            Setstring(sMessage); // Setstring 메서드 내에서 문자열을 변환하는 로직 . 
            MessageBox.Show(sMessage); // 안녕하세요.
        }

        void ArrayArgMethod(string[] _sValues)
        {
            // 배열을 인자로 받은 반환형이 없는 메서드 
            MessageBox.Show(_sValues[0]); // 안녕하세요
            txtTitle.Text = _sValues[1];
            lblTitle.Text = _sValues[2];
        }

        void ArrayChangeMethod(string[] _Svalues) // string[] _Svalues = sValues;
        {
            // 배열을 인자로 받고 배열을 갱신 한 뒤 반환형은 없는 메서드.
            MessageBox.Show(_Svalues[0]); // 안녕하세요.
            _Svalues[0] = _Svalues[2];
            MessageBox.Show(_Svalues[0]); // C# 프로그래밍. 
        }


        void Setstring(string sMessage)
        {
            MessageBox.Show(sMessage);
            sMessage = "값을 지웠습니다.";
        }
        #endregion

        #region < 배열을 리턴 하는 경우 >
        private void btnArrayReturn_Click(object sender, EventArgs e)
        {
            // 배열을 반환하는 메서드 
            // 1. 배열 인자 생성. 
            int[] iValues = { 10, 20 };

            // 2.메서드 호출.
            iValues = ArrayReturnMethod(iValues);
            MessageBox.Show($"[0] : {iValues[0]} , [1] : {iValues[1]}");
        }

        int[] ArrayReturnMethod(int[] _iValues)
        {
            // 배열 인수를 일정한 갑ㅅ과 합하는 메서드.
            int[] iSumints = { 5, 10 };
            iSumints[0] = iSumints[0] + _iValues[0];
            iSumints[1] += _iValues[1];

            return iSumints;
        }
        #endregion
    }
}
