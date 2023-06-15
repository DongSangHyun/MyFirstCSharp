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
    public partial class Chap34_Struture_Apply_UserReg_T : Form
    {
        // 클래스의 전역 변수 로 사용자 정보 데이터 유형을 나열할 수 있는 List
        private List<UserInfo_T> userinfos_reg = new List<UserInfo_T>();

        public Chap34_Struture_Apply_UserReg_T(List<UserInfo_T> TempList)
        {
            InitializeComponent();
            userinfos_reg = TempList;
        }

        private void Chap34_Struture_Apply_UserReg_T_Load(object sender, EventArgs e)
        {

        }

        private void btnUserReg_Click(object sender, EventArgs e)
        {
            // 사용자 등록 을 하기 전 벨리데이션 체크. 
            string sUserid      = txtUserID.Text;
            string sPassWord    = txtPW.Text;
            string sUserName    = txtUserName.Text;
            string sMailAddress = txtUserMail.Text;

            if (sUserid == "" || sPassWord == "" || sUserName == "" || sMailAddress == "")
            {
                MessageBox.Show("필수 입력 항목이 누락 되었습니다.");
                return;    
            }

            //// 사용자 정보 를 담을수 있는 데이터 자료형 에 등록하는 사용자에 대한 데이터를 할당
            //UserInfo userinfo = new UserInfo();
            //userinfo.UserId      = sUserid;      // 사용자ID
            //userinfo.Password    = sPassWord;    // 비밀번호
            //userinfo.UserName    = sUserName;    // 사용자명
            //userinfo.MailAddress = sMailAddress; // 메일 주소
            //userinfo.UseFlag     = true;         // 사용 
            //userinfo.MakeDate    = DateTime.Now; // 현재 일 시 

            //// 전역 변수 리스트 에 사용자 정보 를 ADD
            //userinfos.Add(userinfo); 

            // 위 로직은 아래와 같이 표현 할 수 있다. 
            userinfos_reg.Add(new UserInfo_T
            {   UserId      = sUserid,
                Password    = sPassWord,
                UserName    = sUserName,
                MailAddress = sMailAddress,
                UseFlag     = true,
                MakeDate    = DateTime.Now
            });
            
        }
    }
}
