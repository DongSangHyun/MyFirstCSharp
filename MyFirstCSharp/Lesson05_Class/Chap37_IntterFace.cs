using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson05_Class
{
    // Interface
    // 1. abstract 클래수 와 함께 대표적인 추상화 기능.
    // 2. abstract 클래스와는 달리 다중 상속을 처리 
    //   . 클래스는 상속을 받을때 단 하나의 부모 클래스만 설정할 수 있다.
    //   . 특정한 메서드의 기능을 상속 받는 자식 클래스를 업캐스팅 하여 다형성을 세분화 할 수 있다. 
    // 4. 인터페이스의 이름은 반드시 I 로 시작하도록 명명한다.
    // 5. Abstract  : 공통 기능을 상속 받아야 하는 자식 클래스들이 비교적 많을 경우 사용 (추상 클래스) 
    //    Interface : 비교적 적은 수의 클래스가 상속 받을때, 기능을 세분화 하여 적용을 강제 하고 싶을때 사용
    //    * 클래스는 다른 클래스 하나만 상속 받을 수 있다. ( 어떤 클래스의 기능을 적용 해야 할지 모호해 지기 때문)
    //      따라서 비교적 넓은 범위에서 사용하는 기능은 클래스 로 상속 받아 사용하되
    //      세부 적인 기능은 인터페이스를 통해 다중 상속 받는다.




    #region < 클래스가 다중 상속을 할 수 없는이유 . >
    class MyClass1
    {
        public void doSomting()
        {
            MessageBox.Show("MyClass1 의 메세지");
        }
    }
    class MyClass2
    {
        public void doSomting()
        {
            MessageBox.Show("MyClass2 의 메세지");
        }
    }

    //// MyCalss 1 과 MyClss 2 의 기능을 모두 상속 받아서 사용하고 싶을떄. 
    //class MyNewClass : MyClass1, MyClass2

    //    // MyClass1 에서 실행을 해야 할지. MyClass2에서 실행을 해야할지 모호
    //    // 클래스는 하나의 클래스만 상속 받을수 있다.
    //    public MyNewClass()
    //    {
    //        base.doSomting();
    //    }
    //}
    #endregion 


    abstract class DataBaseManagement
    {
        // 범용 적으로 사용 하는 기능 
        public abstract void Select();
        public abstract void Save();
        public abstract void Delete();
        public abstract void Update();
    }
    interface IWordManage
    {
        // 출력, 엑셀 전환, PDF 전환
        void DoPrint();
        void DoExcel();
        void DoPdf();
    }
    
    interface Iextract
    {
        // 데이터를 추출 하는 기능 을 강제 
        void Extsentence(); // 문장 을 추출
        void ExtLine(); // 한줄 씩 추출 

        void ExtWord(); // 한자씩 추출
    }

    // 문서 관리를 해야하는 클래스가 있다고 할떄 
    // 데이터베이스 역할, 출력, 추출
    class Wordmanagement : DataBaseManagement, IWordManage, Iextract
    {
       

        public void DoExcel()
        {
            throw new NotImplementedException();
        }

        public void DoPdf()
        {
            throw new NotImplementedException();
        }

        public void DoPrint()
        {
            throw new NotImplementedException();
        }

        public void ExtLine()
        {
            throw new NotImplementedException();
        }

        public void Extsentence()
        {
            throw new NotImplementedException();
        }

        public void ExtWord()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        public override void Select()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
