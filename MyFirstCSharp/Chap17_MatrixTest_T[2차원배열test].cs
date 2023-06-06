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
    public partial class Chap17_MatrixTest_T : Form
    {
        public Chap17_MatrixTest_T()
        {
            InitializeComponent();
        }

        private void btnChang_Click(object sender, EventArgs e)
        {
            // 행 역전 배열 생성 및 표현.
            int[,] IValues = new int[2, 4] { { 1, 2, 3, 4 }, 
                                             { 5, 6, 7, 8 } };

            int iRowCount    = IValues.GetLength(0); // 2 배열의 행의 개수.
            int iColumnCount = IValues.GetLength(1); // 2 배열의 컬럼개수

            // 역전 될 배열이 담길 배열 변수
            int[,] iResults = new int[iRowCount, iColumnCount];

            // 원본 배열의 행을 역으로 거슬러 올라가는 행의 주소 i
            int iResultRowindex = 0; // 복사된 배열 의 등록될 행의수
            for (int i  = iRowCount -1; i >= 0; i--)
            {
                for (int j = 0; j < iColumnCount; j++)
                {
                    iResults[iResultRowindex, j] = IValues[i, j];
                }
                iResultRowindex++;
            }

            // 위 로직을 아래와 같이 풀이 할 수 있다
            //for (int i = iRowCount - 1; i >= 0; i--)
            //{
            //    for (int j = 0; j < iColumnCount; j++)
            //    {
            //        iResults[iRowCount - (i+1), j] = IValues[i, j];
            //    }
            //}
        }
    }
}
