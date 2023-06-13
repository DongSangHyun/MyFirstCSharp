using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap20_MiddleTest_06_T : Form
    {
        public Chap20_MiddleTest_06_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 부족 금액 계산 하기 . 
            Random random = new Random();
            int iPirce = random.Next(100, 3000);       // 놀이기구 이용금액. 
            int iMyMoney = random.Next(10000, 500000); // 나의 자본금.
            int iPlayCNT = random.Next(1, 20); // 놀이기구 이용 횟수.

            // 남는 금액을 계산. ( 자본금 - 총 이용금액 )

            // 초기금액을 남는 금액으로 설정.
            int iRemainMoney = iMyMoney;

            // i : 놀이기구 이용 횟수.
            for (int i = 1; i <= iPlayCNT; i++)
            {
                // 누적 감소 연산자를 통한 반복 이용 금액 차감.
                iRemainMoney -= (iPirce * i);
            }

            // 잔액 이 존재 하는 지 확인 후 메세지 등록.
            string sRemainResult = string.Empty;
            if (iRemainMoney > 0)
            {
                sRemainResult = " 남습니다.";
            }
            else if (iRemainMoney == 0)
            {
                sRemainResult = " 남지 않습니다.";
            }
            else
            {
                sRemainResult = " 모자랍니다.";
            }

            MessageBox.Show($"초기금액 {iMyMoney} 원 일때 이용 금액 " +
                            $"{iPirce} 인 놀이기구를 {iPlayCNT} 회 이용하였을때 " +
                            $"{iRemainMoney} 원이 {sRemainResult}");
        }
    }
}
