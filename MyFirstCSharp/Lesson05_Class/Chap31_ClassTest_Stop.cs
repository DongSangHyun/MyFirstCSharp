using MyFirstCSharp.Lesson05_Class;
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
    public partial class Chap31_ClassTest_Stop : Form
    {
        public Chap31_ClassTest_Stop()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Chap31_ClassTest_Main.sRunStop = "비가동";
            MessageBox.Show("비가동 상태를 등록 하였습니다.");
            this.Close(); // 현재 클래스를 종료 (현재 클래를 메모리 에서 소거)
        }
    }
}
