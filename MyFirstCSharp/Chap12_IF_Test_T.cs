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
    public partial class Chap12_IF_Test_T : Form
    {
        // 버튼 클릭 의 누적 횟수를 담는 변수
        // ( 클래스 Cahp12_IF_Test_T 가 호출 될때(인스턴스화, 객체화) 최초 1회 0으로 초기화 됨) 
        int iButtonClickCont; // 클래스 필드 멤버 ( 클래스 전역 변수 )  클래스 멤버 가 직접 초기화

        public Chap12_IF_Test_T()
        {
            InitializeComponent();
            iButtonClickCont = 0; // 객체 생성 시 생성 자 를 통한 초기화
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            // 버튼을 총 클릭한 횟수 ( 정수 ) 
            ++iButtonClickCont; // 버튼을 클릭 했을때 1 씩 증가.(전위증가 연산)
            txtBtnClickCount.Text = iButtonClickCont.ToString();
            
            // 1. 변수 설정. 
            string sValue = txtInputValue.Text; // 입력 받을값.
            int    iValue = 0;                  // 입력받은 값이 정수로 변환될 변수.
            bool   bCheck = false;              // 입력받은 값이 정수로 변환 가능여부 검증.

            // 2. 입력한 문자가 숫자로 바뀔수 있는지 검증.(밸리데이션)
            bCheck = int.TryParse(sValue, out iValue);
            if (!bCheck)
            {
                MessageBox.Show(" 숫자만 입력하세요");
                return; // 벨리데이션 체크 후 오류 발생 검출시 로직 호출한곳으로 반환(종료).
            }


            // 3. 2 와 5 의 공배수 인지 .
            string sMessage = string.Empty; // "" 
            if (iValue % 2 == 0 && iValue % 5 == 0)
            {
                sMessage = "2 와 5의 공배수 입니다.";
            }
            else
            {
                sMessage = "2 와 5의 공배수 가 아닙니다.";
            }
            MessageBox.Show(sMessage);


            // 4. 8 의 배수 인지 확인하는 
            if (iValue % 8 == 0)
            {
                // 입력한 값과 8 을 곱하여 8의배수 텍스트박스에 표현
                txtEMultiValue.Text = Convert.ToString(iValue * 8);
            }
            else
            {
                txtEMultiValue.Text = "";
            }
        }
    }
}
