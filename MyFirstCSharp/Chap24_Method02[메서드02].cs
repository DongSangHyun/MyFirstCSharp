using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap24_Method02 : Form
    {
        public Chap24_Method02()
        {
            InitializeComponent();
        }

        #region < Ref 참조 형식 (값 을 참조형식으로 전달 하는 방법) > 
        private void btnRef_Click(object sender, EventArgs e)
        {
            // ref 
            // [ref 인수] 값(값형식) 을 참조 형식으로 변형시켜 [ref 인자] 에 연결되어있는
            // 주소 를 공유 할 수 있도록 만들어 주는 키워드.

            // ref : 반드시 값이 할당 된 상태에서 사용 하여야 한다.
            //      . 메서드 내에서 던져주는 값을 이용하여 로직을 수행할때 
            //      . 메서드 내에서 처리되는 결과(N개) 를 반환받아서 호출하는 로직에서 사용하고 싶을때.

            int iValue1 = 10;
            int iValue2 = 20;

            MessageBox.Show($"iValue1 에 있는 현재 값은 : {iValue1} 입니다.");
            MessageBox.Show($"iValue2 에 있는 현재 값은 : {iValue2} 입니다.");

            //RefMethod(iValue1, iValue2); // 값 을 전달 하는 경우.
            RefMethod(ref iValue1, ref iValue2);

            MessageBox.Show($"iValue1 에 있는 현재 값은 : {iValue1} 입니다.");
            MessageBox.Show($"iValue2 에 있는 현재 값은 : {iValue2} 입니다.");
        }
        //void RefMethod(int _iValue1, int _iValue2) // 값을 전달 받는 메서드 .
        void RefMethod(ref int _iValue1, ref int _iValue2)
        {
            MessageBox.Show($"_iValue1 의 값은 : {_iValue1} 입니다.");
            _iValue1 = _iValue2; // _iVasue2 의 값을 할당.
            _iValue2 = 100;
            MessageBox.Show($"_iValue1 의 값은 : {_iValue1} 입니다.");
        }
        #endregion

        #region < Out 참조 전달 > 


        private void btnOut_Click(object sender, EventArgs e)
        {
            // out 
            // [out 인수] 값(값형식) 을 참조 형식으로 변형시켜 [out 인자] 에 연결되어있는
            // 주소 를 공유 할 수 있도록 만들어 주는 키워드.

            // Out : 인수로 전달시 값이 할당되어 있을 필요가 없다. ( 메서드 가 인자 로 전달 받을때 초기화 )
            //      . * 메서드 내에서 전달 받은 인자의 초기화 과정을 반드시 수행.
            //      . 메서드 내에서 처리되는 결과(N개) 를 반환받아서 호출하는 로직에서 사용하고 싶을때.

            // 초기화 되어있지 않은 값형 데이터를 전달 가능 
            int iValue1;     // 값이 초기화 되어 있지 않든.
            int iValue2 = 10;// 값이 초기화 되어 있든. 
            // out 는 메서드 내에서 초기화 하므로 인수의 값 초기화 여부는 무관하다.

            OutMethod(out iValue1, out iValue2);

            MessageBox.Show($"iValue1 에 있는 현재 값은 : {iValue1} 입니다."); // 20 
            MessageBox.Show($"iValue2 에 있는 현재 값은 : {iValue2} 입니다."); // 100
        }
        void OutMethod(out int _iValue1, out int _iValue2)
        {
            _iValue1 = 10;
            _iValue2 = 20;
            MessageBox.Show($"_iValue1 의 값은 : {_iValue1} 입니다.");
            _iValue1 = _iValue2; // _iVasue2 의 값을 할당.
            _iValue2 = 100;
            MessageBox.Show($"_iValue1 의 값은 : {_iValue1} 입니다.");
        }
        #endregion

        #region < In 읽기전용 속성 전달 >
        private void btnin_Click(object sender, EventArgs e)
        {
            // in
            // 읽기전용 속성으로 변경하여 전달. 
            // 메서드 내에서 수정, 변경 할 수 없다. 

            int iValue = 10;
            string sm1 = "문자열열열";
            InMethod(sm1, in iValue);
        }
        
        void InMethod(string sMessage, in int _iValue)
        {
            MessageBox.Show(sMessage);
            sMessage = "값이 바뀝니다.";
           
            //_iValue = 100; // 값이 바뀌지 않는다.
            // in 같은 경우는 메서드 에 전달 해 주는 인수 를 변형 하지 않기 위해 사용하는듯 하나. 
            // 메서드 내의 로직을 구현할때 . 변형 되면 안되는 로직으로 구현해야 하는게 맞으므로. 
            // 사용 빈도는 낮다. 
        }
        #endregion

        #region < TryParse 기능 구현해 보기 >
        private void btnTryParse_Click(object sender, EventArgs e)
        {
            // tryParse 의 원형 포멧. 
            
            bool bCheck = false; // 숫자로 변형 가능한 문자 였을 경우 결과 true : 변환 완료, false : 변환실패.
            int iResult; // 문자 가 숫자로 변형되어 담길 변수. out 형식을 사용하므로 초기화 하지 않는다.
            bCheck = int.TryParse("200", out iResult);

            // 결과 
            // bCheck = true 를 반환받는다. 
            // iResult = 200 정수가 할당되어 있을것.


            // _int.TryParse() 호출. 
            bCheck =  _int.TryParse("werf32", out iResult);
        }

        class _int
        {
            public static bool TryParse(string sTarget, out int iResult)
            { 
                try
                {
                    iResult = Convert.ToInt32(sTarget);
                    return true;
                }
                catch
                {
                    iResult = 0;
                    return false;
                }
            }
        }

        #endregion


        #region < Method Overloding > 
        private void btnOverLoding_Click(object sender, EventArgs e)
        {
            // OverLoding
            // 메서드 를 같은 이름으로 여러개 중복하여 만들수 있도록 하는 기능. 
            // 예를들어 합산을 하는 메서드 기능이 있다고 가정을 할때
            // 문자 를 인수로 던져 주는 경우,  숫자 를 인수 로 던져 주는 경우가 일을때
            // 각각의 메서드를 다른이름으로 만들게 아니라 같은이름으로 인자의 종류 만 바꾸어 
            // 구현 할 수 있다. 
            // 메서드의 이름이 너무 많아 질 경우 사용해야하는 메서드를 정확히 찾을수 없을수도 있으므로
            // 메서드의 이름을 통일 하여 구현 함으로서 개발의 편의성을 제공하는 기능.


            // 1. 메서드를 만들어 두고 여러 로직에서 기능을 사용하고 있었을때.
            DoSumInt(10, 20);
            DoSumInt(100, 300);

            // 2. 어떠한 경우에 의해서 숫자를 인수로 던져줄 경우가 아닌 문자를 인수로 던져 줄 경우가 발생.
            //    새로운 메서드를 만들어 야한다.
            DoSumString("10", "20");
            DoSumString("100", "200");

            // 3. 메서드가 다양해 질 경우 개발자가 원하는 메서드를 곧바로 찾기 힘든 경우도 발생하고. 
            //    통일성 없는 메서드 이름으로 인해 프로그램이 표준화 되기 힘들다.

            // 4. OverLoding 
            //    메서드 의 이름은 똑같이 가되 , 인수와 인자에 따라 메서드를 다르게 구현 할 수 있게 하는 
            //    편의 기능이 등장.
            DoSum(10, 20);
            DoSum("10", "20"); 

            // * 인자의 유형과개수가  똑같은 메서드는 OverLoding 할 수 없다.
        }

        int DoSumInt(int _iValue1 , int _iValue2)
        {
            // 정수 인자 2개를 합하여 결과를 반환하는 메서드
            return _iValue1 + _iValue2;
        }
        
        int DoSumString(string siValue1, string siValue2)
        {
            return Convert.ToInt32(siValue1) + Convert.ToInt32(siValue2);
        }

        /******************* 메서드 오버 로딩 ***********************/
        int DoSum(int iValue1, int ivalue2)
        {
            return iValue1 + ivalue2;
        }
        int DoSum(string siValue1, string siValue2)
        {
            return Convert.ToInt32(siValue1) + Convert.ToInt32(siValue2);
        }

        //인자의 유형과개수가  똑같은 메서드는 OverLoding 할 수 없다.
        //int DoSum(int iValue1, int ivalue2)
        //{
        //    return iValue1 + ivalue2;
        //}

        // 반환 값이 다르더라 해도 OverLoding 할수 없다.
        //string DoSum(int iValue1, int ivalue2)
        //{
        //    return iValue1 + ivalue2;
        //}
        #endregion

        #region < params > 
        private void btnparams_Click(object sender, EventArgs e)
        {
            // params 
            // 같은 데이터 유형을 가변적으로 (개수를 가변적으로) 인자로 전달 받을수 있게 하는 키워드.
            // 인자를 배열 형태로 받게 하여 인수를 가변적으로 던져줄수 있는 기능.
            // params 인자 배열은 인자 의 가장 마지막 위치에 설정 되어야 한다.

            GetParameter(100, "안", "녕","하","세","요");
            GetParameter(20,  "안", "녕");
            GetParameter(20, "안", "녕", "안", "녕", "안", "녕");
        }

        void GetParameter(int iValue, params  string[] sValues)
        {
            // params string[] sValues
            // 인수 의 개수에 관계 없이 sValues 라는 배열에 가변적으로 인수를 담는 인자.

            StringBuilder sValue = new StringBuilder();
            foreach(string s in sValues)
            {
                sValue.Append(s); // "안녕하세요"
            }
            MessageBox.Show(sValue.ToString());
        }
        #endregion


        #region <  일반화 메서드 Generic Method > 
        private void btnGenericMethod_Click(object sender, EventArgs e)
        {
            // 같은 기능을 하는 메서드가 인자의 데이터 타입만 바뀌는 경우. 
            // 인자의 데이터 타입이 같은 메서드를 데이터 타입에 따라 오버로딩 할 시에는 
            // 메서드 일반화를 통하여 여러 데이터 타입의 인자를 처리 하는 메서드 하나만 만들어서
            // 관리 할 수 있다.

            GenericMethod<int,string>(10, 20,"HI","Helow");
            GenericMethod<string,bool>("안녕", "반가워",true, false);
        }

        void GenericMethod<T,K>(T tValue1, T tValue2, K kValue1, K value2)
        {
            // GenericMethod 를 호출 하기 위해서는 데이터 타입을 설정 해야 하며. 
            // 설정한 데이터 타입은 T 라는 이름으로 사용 하겠다. 
            MessageBox.Show(Convert.ToString(tValue1) + Convert.ToString(tValue2));
        }
        #endregion
    }
}
