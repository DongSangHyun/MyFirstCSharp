using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap24_Method02 : Form
    {
        public Chap24_Method02()
        {
            InitializeComponent();
        }

        #region < Ref 참조 형식 (값 을 참조형식으로 전달 하는 방법) > 
        private void btnRef_Click(object sender, EventArgs e)
        {
            // ref 
            // [ref 인수] 값(값형식) 을 참조 형식으로 변형시켜 [ref 인자] 에 연결되어있는
            // 주소 를 공유 할 수 있도록 만들어 주는 키워드.

            // ref : 반드시 값이 할당 된 상태에서 사용 하여야 한다.
            //      . 메서드 내에서 던져주는 값을 이용하여 로직을 수행할때 
            //      . 메서드 내에서 처리되는 결과(N개) 를 반환받아서 호출하는 로직에서 사용하고 싶을때.

            int iValue1 = 10;
            int iValue2 = 20;

            MessageBox.Show($"iValue1 에 있는 현재 값은 : {iValue1} 입니다.");
           // MessageBox.Show($"iValue2 에 있는 현재 값은 : {iValue2} 입니다.");

            //RefMethod(iValue1, iValue2); // 값 을 전달 하는 경우.
            RefMethod(ref iValue1, ref iValue2);

            MessageBox.Show($"iValue1 에 있는 현재 값은 : {iValue1} 입니다.");
            MessageBox.Show($"iValue2 에 있는 현재 값은 : {iValue2} 입니다.");
        }
        //void RefMethod(int _iValue1, int _iValue2) // 값을 전달 받는 메서드 .
        void RefMethod(ref int _iValue1, ref int _iValue2)
        {
            MessageBox.Show($"_iValue1 의 값은 : {_iValue1} 입니다.");
            _iValue1 = _iValue2; // _iVasue2 의 값을 할당.
            _iValue2 = 100;
            MessageBox.Show($"_iValue1 의 값은 : {_iValue1} 입니다.");
        }
        #endregion

        #region < Out 참조 전달 > 


        private void btnOut_Click(object sender, EventArgs e)
        {
            // out 
            // [out 인수] 값(값형식) 을 참조 형식으로 변형시켜 [out 인자] 에 연결되어있는
            // 주소 를 공유 할 수 있도록 만들어 주는 키워드.

            // Out : 인수로 전달시 값이 할당되어 있을 필요가 없다. ( 메서드 가 인자 로 전달 받을때 초기화 )
            //      . * 메서드 내에서 전달 받은 인자의 초기화 과정을 반드시 수행.
            //      . 메서드 내에서 처리되는 결과(N개) 를 반환받아서 호출하는 로직에서 사용하고 싶을때.

            // 초기화 되어있지 않은 값형 데이터를 전달 가능 
            int iValue1;     // 값이 초기화 되어 있지 않든.
            int iValue2 = 10;// 값이 초기화 되어 있든. 
            // out 는 메서드 내에서 초기화 하므로 인수의 값 초기화 여부는 무관하다.

            OutMethod(out iValue1, out iValue2);

            MessageBox.Show($"iValue1 에 있는 현재 값은 : {iValue1} 입니다."); // 20 
            MessageBox.Show($"iValue2 에 있는 현재 값은 : {iValue2} 입니다."); // 100
        }
        void OutMethod(out int _iValue1, out int _iValue2)
        {
            _iValue1 = 10;
            _iValue2 = 20;
            MessageBox.Show($"_iValue1 의 값은 : {_iValue1} 입니다.");
            _iValue1 = _iValue2; // _iVasue2 의 값을 할당.
            _iValue2 = 100;
            MessageBox.Show($"_iValue1 의 값은 : {_iValue1} 입니다.");
        }
        #endregion

        #region < In 읽기전용 속성 전달 >
        private void btnin_Click(object sender, EventArgs e)
        {
            // in
            // 읽기전용 속성으로 변경하여 전달. 
            // 메서드 내에서 수정, 변경 할 수 없다. 

            int iValue = 10;
            InMethod("문자열열열", in iValue);
        }
        
        void InMethod(string sMessage, in int _iValue)
        {
            sMessage = "값이 바뀝니다.";
            //_iValue = 100; // 값이 바뀌지 않는다.
            // in 같은 경우는 메서드 에 전달 해 주는 인수 를 변형 하지 않기 위해 사용하는듯 하나. 
            // 메서드 내의 로직을 구현할때 . 변형 되면 안되는 로직으로 구현해야 하는게 맞으므로. 
            // 사용 빈도는 낮다. 
        }
        #endregion

        #region < TryParse 기능 구현해 보기 >
        private void btnTryParse_Click(object sender, EventArgs e)
        {
            // tryParse 의 원형 포멧. 
            
            bool bCheck = false; // 숫자로 변형 가능한 문자 였을 경우 결과 true : 변환 완료, false : 변환실패.
            int iResult; // 문자 가 숫자로 변형되어 담길 변수. out 형식을 사용하므로 초기화 하지 않는다.
            bCheck = int.TryParse("200", out iResult);

            // 결과 
            // bCheck = true 를 반환받는다. 
            // iResult = 200 정수가 할당되어 있을것.
        }

        class _int
        {
            static bool TryParse(string sTarget, out int iResult)
            { 
                try
                {
                    iResult = Convert.ToInt32(sTarget);
                    return true;
                }
                catch
                {
                    iResult = 0;
                    return false;
                }
            }
        }

        #endregion
    }
}
