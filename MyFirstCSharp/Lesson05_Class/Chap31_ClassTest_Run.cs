using MyFirstCSharp;
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
    public partial class Chap31_ClassTest_Run : Form
    {
        private string _sNowState;

        private Chap31_ClassTest_Main _TempClass;
        public Chap31_ClassTest_Run(ref string sNowState)
        {
            InitializeComponent();
            _sNowState = sNowState;
        }
        // 클래스생성자 OverLoad
        public Chap31_ClassTest_Run(Chap31_ClassTest_Main TempClass)
        {
            InitializeComponent();
            _TempClass = TempClass; 
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 가동 화면 클래스 에서 가동 버튼을 클릭 하였을 경우.

            // 1. 벨리데이션을 통해 거를 내역은 먼저 걸러놓고 (로직을 수행하면 안되는 경우)
            // 2. 정상 조건 일 경우 의 로직을 안전하게 구현. 
            // 3. 데이터 베이스의 세션을 종료.
            // 4. 메세지 를 통해 상태 보고. 

            //Chap31_ClassTest_Main.sRunStop = "가동중";
            //_sNowState = "가동중";
            _TempClass.Tag = "가동중";
            MessageBox.Show("가동 상태를 등록 하였습니다.");
            this.Close(); // 현재 클래스를 종료 (현재 클래를 메모리 에서 소거)
            this.Tag = true;

        }
    }
}
