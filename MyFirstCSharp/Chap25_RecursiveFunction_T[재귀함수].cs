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
    public partial class Chap25_RecursiveFunction_T : Form
    {
        int iLoopCount = 0; // 반복 문이 실행 되는 횟수,
        public Chap25_RecursiveFunction_T()
        {
            InitializeComponent();
        } 

        private void btnList_Click(object sender, EventArgs e)
        {
            // 리스트 를 통한 피보나치 수열 의 값 구하기
            int iLoopCount = 0; // 반복 횟수 초기화

            // 리스트의 초기 값 0 과 1 등록. ( 피보나치 수열에서 전전 값과, 전 값이 등록되어 보관될 용도 )
            List<int> iList = new List<int>()
            { 
                     0,    1
                // [0],  [1]
            };

            bool bCheck = int.TryParse(txtInput.Text, out int iTurn) ; // out int iResutl iResult 를 생성 하면서 out  값을 할당 받기.
            if (!bCheck) return;

            // 입력한 순차 iTurn 
            if (iTurn > 2)  // 입력한 차수 가 3 이상일때.
            {
                // i : list 에 등록될 값의 index
                for (int i = 2; i < iTurn; i++)
                {
                    iList.Add(iList[i - 2] + iList[i - 1]);
                    ++iLoopCount;
                }
                ++iLoopCount;
            }
            MessageBox.Show($"피보나치 수열 {iTurn} 번째의 값은 {iList[iTurn - 1]} 입니다. 총 반복횟수  : {iLoopCount} ");
        }
    }
}
