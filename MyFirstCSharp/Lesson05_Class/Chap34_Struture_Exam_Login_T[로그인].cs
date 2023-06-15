using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson05_Class
{
    public partial class Chap34_Struture_Exam_Login_T : Form
    {
        // 사용자 등록 화면에서 사용자의 리스트를 받아올 리스트
        private List<UserInfo_T> userinfos = new List<UserInfo_T>();

        public Chap34_Struture_Exam_Login_T()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // 로그인 가능 여부를 판단.
            if (userinfos.Count == 0)
            {
                MessageBox.Show("등록된 사용자가 없습니다.");
                return;
            }

            // 입력한 id , pw
            string sUserId  = txtUserId.Text;
            string sPassword = txtPassWord.Text;

            // 리스트에 등록 되어 있는 사용자 정보 와 
            // 입력한 사용자의 정보가 같은 지 확인

            foreach (UserInfo_T userinfo in userinfos)
            {
                if (userinfo.UserId == sUserId)
                {
                    // 사용자 아이디 가 같다면. 
                    if (userinfo.Password == sPassword)
                    {
                        // 비밀번호 를 체크
                        MessageBox.Show($"{userinfo.UserName} 님 반갑습니다.");
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.");
                    }
                    return;
                }
            } 
            MessageBox.Show("일치하는 사용자 ID 가 없습니다.");
        }

        private void btnUserReg_Click(object sender, EventArgs e)
        {
            // 사용자 등록 버튼을 클릭 시 
            // 사용자 에 대한 정보를 담을수 있는 리스트 를
            // 사용자 등록 클래스 전달 (참조 주소).
            Chap34_Struture_Apply_UserReg_T CHAP34 = new Chap34_Struture_Apply_UserReg_T(userinfos);
            CHAP34.ShowDialog();
        }
    }
}
