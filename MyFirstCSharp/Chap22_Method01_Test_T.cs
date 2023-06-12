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
    public partial class Chap22_Method01_Test_T : Form
    {
        // 메서드로 간추리기 
        // 1. 반복 적으로 구현한 로직을 분리 
        // 2. 모듈( 구현하는 기능 ) 에 따라서 메서드 분할
        // 3. 메서드 가 원활히 동작 할 수 있도록 반환 유형, 인수,인자 설정. 

        // 클래스의 멤버 변수 ( 인스턴스 변수 ) 
        // 클래스 내부 어디서든 사용 할 수 있도록 클래스와 함께 메모리에 등록 되는 변수.
        // 입력한 숫자 
        int iStart = 0;
        int iEnd = 0;

        public Chap22_Method01_Test_T()
        {
            InitializeComponent();
        }

        private void btnTwo_M_Click(object sender, EventArgs e)
        {
            ValidationCheck(); // 벨리 데이션 체크 . 

            SetMulSumValue(2); // 2의 배수 합 표현.
        }

        private void btnFiv_M_Click(object sender, EventArgs e)
        {
            ValidationCheck(); // 벨리 데이션 체크 . 

            SetMulSumValue(5); // 5 의 배수 합 표현.
        }

        private void btnTen_M_Click(object sender, EventArgs e)
        {
            ValidationCheck(); // 벨리 데이션 체크 . 

            SetMulSumValue(10); // 10 의 배수 합 표현.
        }



        void ValidationCheck()
        { 
            // 데이터 입력 벨리데이션 체크. 

            // 벨리데이션 체크로 정상 진행 상황이 아닌경우를 모두 걸러내고.
            string sMessage = string.Empty;
            if (!int.TryParse(txtStart.Text, out iStart)
                ||
                !int.TryParse(txtEnd.Text, out iEnd))
            {
                // 시작 입력값과 종료 입력 값이 둘중 하나라도 숫자로 변경 할수 없는상태(false)
                sMessage = "숫자로 변경 할 수 없는 값을 입력 하였습니다.";
            }

            if (iStart * iEnd < 0)
            {
                sMessage = "음수는 입력 할 수 없습니다.";
            }

            if (sMessage != "")
            {
                MessageBox.Show(sMessage);
                return;
            }
        }

        void SetMulSumValue(int iMulValue)
        {
            // 벨리데이션 체크 후 정상 로직 진행 할수 있을때 아래 로직 진행. 
            int iResult = 0; // 합을 누적시킬 변수.
            for (int i = iStart; i <= iEnd; i++)
            {
                if (i % iMulValue == 0)
                {
                    //  iMulValue 의 배수. 합을 누적. 
                    iResult += i;
                }
            }
            MessageBox.Show($"{iMulValue}의 배수 합은 : " + iResult.ToString());
        }
    }
}
