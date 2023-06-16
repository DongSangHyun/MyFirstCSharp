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
    public partial class Chap36_abstract_Polymorphism : Form
    {
        #region < 0. 추상화의 정의 와 Abstract >
        /*
            추상화 
            구현해야 하는 기능을 정의만 해 둔다.
            추상적으로 기능에 대한 정의, 로직, 은 존재하지 않는 상태
            추상클래스 를 상속받는 클래스는 추상클래스에 서 정의한 기능을 구현해야 한다.
            
            * 추상 클래스의 상속을 구현 하는 이유?
              프로그램을 설계 하는 사람. 많은 클래스(화면) 에서 반드시 구현해야 하는 기능이 있을때.  
              (조회, 추가, 저장, 삭제) 
              여러 개발자들이 개발을할때 설계자의 의도를 파악하지 못하고 
              1. 조회, 추가, 저장, 삭제 등에 대한 기능을 누락하여 구현 할 경우가 발생
              2. 개발자들 마다 조회(search(), Find()) , 추가,저장, 삭제 기능의 명칭을 통일성 없이 사용할 가능성

             설계자가 생각한 필수 기능(조회,저장 등) 과 기능에 대한 명칭(Search(), Inquire()) 상속받아서 
             각 클래스 별로 목적에 맞게 기능을 상세히 구현할수 있도록 하여 
             프로그램에 대한 일관성과 통일성 을 지키고 필수 기능 누락 상황을 예방 할 수 있다.



             abstract : 추상 클래스(부모클래스) 를 만들어 주는 키워드
             1. 상속 받는 클래스에서 반드시 구현 해야하는 기능
             2. 클래스 멤버 중 하나라도 abstract 형식이면 클래스 자체는 abstract 키워드를 부여해야 한다.
             3. 메서드의 기능명칭 만 정의 하되 구현은 상속 받은 클래스에서 한다.
                - 메서드의 본문을 정의 할 수 없다. (일반 메서드 를 작성 할 수 없다)
             4. Abstract 클래스 는 일반 함수 및 필드 멤버를 가질수 있다. 
             5. abstract 클래스 는 인스턴스 화(객체화) 할 수 없다. (기능 정의 와 상속 이 목적)

            **** 상속 받을 클래스에서 반드시 구현해야 하지만 누락 할 가능성이 있는 기능 을 
                 구현 할 수 있도록 강제 하는 기능. 
        */




        public Chap36_abstract_Polymorphism()
        {
            InitializeComponent(); 
        }
        #endregion

        #region < 2. 상속한 클래스의 기능 실행. 및 업 캐스팅 > 
        private void btnAbstract_Click(object sender, EventArgs e)
        {
            // 추상 클래스 는 인스턴스화 할 수 없다(기능 정의 와 상속이 목적)
            //ToolBar toolBar = new ToolBar();

            // ItemMaster 클래스의 인스턴스 화 및 기능 실행. 
            ItemMaster itemM = new ItemMaster();
            itemM.DoSearch(); // 추상클래스(Toolbar) 에서 상속 받아 구현을 강제 받은 메서드.
            itemM.DoSave();   // 추상클래스(Toolbar) 에서 상속 받아 구현을 강제 받은 메서드.
            itemM.DoPrint();  // 품목 마스터(ItemMaster) 클래스에서 별도로 구현한 메서드.

            // 추상 클래스의 업캐스팅
            // 부모 클래스의 기능 중 자식 클래스가 오버라이드(구현 선언)
            // 한 기능을 부모 클래스의 객체로 형변환후 실행 할 수 있다.
            ToolBar toolBar = new ItemMaster(); // 업캐스팅
            toolBar.DoSearch();
            toolBar.DoSave();
            //toolBar.DoPrint();
        }
        #endregion
    }

    #region < 1. 추상 클래스 의 생성 및 상속 > 
    // 모든 화면에서 구현해야 하는 기능 
    public abstract class ToolBar  // 멤버 중 하나라도 abstract 가 부여(추상화) 되어있을경우 클래스도 abstract(추상화) 를 설정해야한다.
    {
        public abstract void DoSearch(); // 반드시 구현해야 하는기능 1

        public abstract void DoSave(); // 반드시 구현해야 하는 기능 2

        public void DoSomthing()
        {
            // 로직이 구현되는 일반 메서드 를 작성 할 수 있다.
        }
        //public abstract void DoDelete()
        //{
        //    // abstract 멤버 에는 기능 구현 을 할 수 없다(일반 메서드 를 만들수 없다.)
        //    MessageBox.Show("");
        //}
    }

    class ItemMaster : ToolBar
    { 
        // 부모 추상 클래스 에서 구현을 강제 하는 기능을 구현 하겠다 선언 키워드
        // Override : 내가 부모 클래스(추상클래스) 에서 지시한 기능을 구현하겠다. 
        public override void DoSearch()
        {
            MessageBox.Show("조건에 맞는 품목을 검색합니다.");
        }
        public override void DoSave()
        {
            MessageBox.Show("품목의 내용을 저장합니다.");
        } 
        public void DoPrint()
        {
            MessageBox.Show("품목 화면을 출력합니다.");
        }
    }
    
    #endregion

}
