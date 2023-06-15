using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson05_Class
{
    public partial class Chap31_ClassTest_Main : Form
    {
        public static string sRunStop = "대기중";


        // 1. 일반 인스턴스 변수 
        private string sNowState = "대기중"; // 가동/비가동 클래스에서 전역변수로 전달 시 값형으로 변형 (X)

        // 2. 클래스(참조) 를 전달. 
        // int[], List<>
        public Chap31_ClassTest_Main()
        {
            InitializeComponent();
        }

        private void btnMonitering_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"현재 설비의 상태는 {this.Tag}  입니다.");
        }

        private void btnRunCall_Click(object sender, EventArgs e)
        {
            // 가동 등록 화면 호출.
            //Chap31_ClassTest_Run Cahp31 = new Chap31_ClassTest_Run(ref sNowState);
            Chap31_ClassTest_Run Cahp31 = new Chap31_ClassTest_Run(this); // 참조 전달 형식으로 자기 자신의 클래스를 전달.

            this.Visible = false; // 현재 화면을 숨김처리. 
            // Show : 비동기. 
            // ShowDialog : 동기.
            Cahp31.ShowDialog();

            this.Visible = true;

        }

        private void btnStopCall_Click(object sender, EventArgs e)
        {
            Chap31_ClassTest_Stop Chap31 =  new Chap31_ClassTest_Stop();
            this.Visible=false; // 숨김
            Chap31.ShowDialog(); // 모달창 ( 동기식으로 호출) 
            this.Visible = true; 
        }
    }
}
