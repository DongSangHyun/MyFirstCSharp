using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap20_MiddleTest_05_T : Form
    {
        public Chap20_MiddleTest_05_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 외부 변수 를 이용한 문자열 찾기 카운트 계산. 

            string sTitle = lblTitle.Text;

            // 기준 문자열 (0 index 로 부터 한칸씩 옆으로 이동해 비교할 문자)
            string sBaseString = string.Empty;

            // 결과 index ((첫번째 ? index) + (세번째 ? index))
            int iResultIndex = 0;

            // ? 를 찾은 횟수 체크 변수.
            int iFindCount = 0;

            // i : 기준값의 index 문자열.
            for (int i = 0; i < sTitle.Length; i++)
            {
                sBaseString = sTitle.Substring(i, 1); // i 번째 index 문자를 1글자 잘라서 대입(할당).
                if (sBaseString == "?")
                {
                    // "?" 를 찾았을때 첫번째 인지, 세번째 인지 판단후 
                    // 해당 ? 의 index 를 누적 대입 하는 로직.
                    
                    ++iFindCount; // ? 찾은 횟수 1 증가.
                    if (iFindCount == 2) continue; // ? 를 찾은 횟수가 2 일때 는 index 합산하지 않기.
                    // 찾은 index 를 누적
                    iResultIndex += i;  // 첫번째 index 4 가 등록.
                    if (iFindCount == 3) break; // ? 를 세번째 까지 찾았을경우 반복문을 종료. 
                }
            }

            //반복 문 종료 후 iResultIndex 에는 첫번째 ? 와 세번째 ? 의 
            // index 합이 누적되어 있다. 

            // 결과 의 누적 index 에 있는 곳으로부터 3자리 를 xxx 치환.
            string sFindString = sTitle.Substring(iResultIndex, 3);
            txtResult.Text = sTitle.Replace(sFindString, "XXX");
        }
    }
}
