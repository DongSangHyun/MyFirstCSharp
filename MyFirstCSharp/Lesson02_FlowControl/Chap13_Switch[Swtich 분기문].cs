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
    public partial class Chap13_Switch : Form
    {
        // switch, case, break, default (switch 의 포멧)
        // IF 문과 함께 자주 사용되는 분기문
        // 많은 분기를 제어할 경우 IF 문 보다 깔끔하게 로직을
        // 표현 할 수 있다.

        public Chap13_Switch()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            // IF 문으로 과일 이름, 가격 나타내기

            // 1. 변수 설정
            string sFruitName = txtFruit.Text; // 과일이름
            int iFruitPrice   = 0;             // 과일가격.

            if (sFruitName == "사과")
            {
                iFruitPrice = 2000;
            }
            else if (sFruitName == "복숭아")
            {
                iFruitPrice = 2000;
            }
            else if (sFruitName == "참외")
            {
                iFruitPrice = 2500;
            }
            else if (sFruitName == "딸기")
            {
                iFruitPrice = 18000;
            }
            else if (sFruitName == "수박")
            {
                iFruitPrice = 18000;
            }
            // iFruitPrice 가 0으로 초기화 되어 진행 되므로 아래 else 구문은 구현 필요 없음.
            //else 
            //{
            //    // 취급하는 과일을 입력하지 않은 경우
            //    iFruitPrice = 0;
            //}

            if (iFruitPrice == 0)
            {
                MessageBox.Show("취급하지 않는 과일입니다.");
            }
            else
            {
                MessageBox.Show($"{sFruitName} 의 가격은 {iFruitPrice} 입니다.");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // switch 를 통한 과일 이름과 가격 찾기.

            // 입력한 과일 이름 변수 등록.
            string sFruitName = txtFruit.Text;

            // 과일의 가격 정수 변수.
            int iFruitPrice = 0;

            switch(sFruitName) // 비교 할 대상.
            { 
                case "복숭아":
                case "사과" :
                    iFruitPrice = 2000;
                break;

                case "참외":
                    iFruitPrice = 2500;
                break;

                case "수박":
                case "딸기": 
                    iFruitPrice = 18000;
                break;
            }

            if (iFruitPrice == 0)
            {
                MessageBox.Show("취급하지 않는 과일입니다.");
            }
            else
            {
                MessageBox.Show($"{sFruitName} 의 가격은 {iFruitPrice} 입니다.");
            }
        }
    }
}
