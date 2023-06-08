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
    public partial class Chap20_MiddleTest_08_T : Form
    {
        public Chap20_MiddleTest_08_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 버블 정렬  내림차순. 
            int[] iValues = { 1, 11, 6, 20, 11, 8, 12, 6, 16, 13, 22 };

            // 바뀔 값이 임시로 저장될 변수 
            int iChangValue = 0;

            // i : 배열 에서 기준 값을 설정할 index
            for (int i = 0; i < iValues.Length; i++)
            {
                // k : 현재 기준값 이후에 배열되어 있는 데이터의 index 
                for (int k = i + 1; k < iValues.Length; k++)
                {
                    if (iValues[i] < iValues[k])
                    {
                        // 기준값 보다 큰 수를 찾았을때
                        // 1. 임시 변수 에 바뀔 데이터 등록.
                        iChangValue = iValues[i];
                        // 2. 현재 기준 index 에 큰 값 index(k) 의 데이터 등록.
                        iValues[i] = iValues[k];
                        // 3. 현재 기준값 i 의 데이터(임시데이터에 등록된 값) 를 큰값 k 의 위치에 등록.
                        iValues[k] = iChangValue;
                    }
                }
            }
            // 내림차순 결과 textbox 에 표현
            foreach (int iValue in iValues)
            {
                txtResult.Text += iValue + " ";
            }
        }
    }
}
