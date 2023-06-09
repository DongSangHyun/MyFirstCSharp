using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap21_Collection_Test_T : Form
    {
        public Chap21_Collection_Test_T()
        {
            InitializeComponent();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            // 중복 되지 않은 문자열 찾기 Dictionary 와 Foreach

            string sTitle = lbltitle.Text;

            // 문자열 에서 한글자씩 가지고 와서 Key 로 생성 , Key 의 데이터 타입은 char 형식. 
             Dictionary<char,int> dic = new Dictionary<char, int>();


            // 타이틀에서 한글자씩 추출 하고 
            // DIctonary 에 Key 의 값으로 등록 하는데 . 
            // Key 의 값으로 이미 등록되어 있으면 1 증가
            // Key 의 값으로 등록 되어 있지 않은 상태라면. 1
            foreach(char cWord in sTitle)
            {
                if (dic.ContainsKey(cWord))
                {
                    // 딕셔너리에 추출한 글자 로 된 Key 가 있을 경우.
                    dic[cWord] = dic[cWord] + 1;
                }
                else
                {
                    dic[cWord] = 1;
                }
            }
            // DIctionary 의 key 를 추출하는 기능.
            // dic.Keys
            foreach (char iValue in dic.Keys)  
            {
                if (dic[iValue] == 1)
                {
                    MessageBox.Show($"중복되지않은 첫 글자 는 {iValue} 입니다.");
                    break;
                }
            }
        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            // 중복 되지 않는 문자 찾기 (For in For)

            // 타이틀 담기.
            string sTitle = lbltitle.Text;

            // 1. 기준 문자 담을 변수.
            // 캐릭터 변수에 기본값 설정.  /0  : NULL 의 코드.
            char cStandardWord = default(char);

            // 중복 문자가 아닌 첫 문자를 찾았을 경우 를 알리는 bool
            bool bFindFlag = false;
            // i : 문자열 (타이틀) 에서 기준이 되는 문자 를 가리키는 index
            for (int i = 0; i < sTitle.Length; i++)
            {
                cStandardWord = sTitle[i];
                // j : i 문자 가 있는지 없는지 찾을 문자열의 index
                for (int j = i+1;  j < sTitle.Length; j++)
                {
                    if (i == j) continue;
                    // 기준문자 i 가 자기자신을 비교할 경우 j 는 
                    if (sTitle[i] == sTitle[j])
                    {
                        // 중복 단어 를 찾은경우.
                        bFindFlag = true;
                        break;
                    }
                }
                if (!bFindFlag) break;
                else
                {
                    bFindFlag = false;
                    continue;
                }
            }
            MessageBox.Show($"중복되지 않은 가장 첫 문자 는 {cStandardWord} 입니다.");
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {

            //
            // LastIndexOf 방식().
            
            string sTitle = lbltitle.Text;

            // 기준 문자 담을 변수.
            char cStandardWord = default(char);

            bool bFindFlag = false; // 중복되지 않은 문자를 찾은경우 true
            // 반복 문 시작. 
            // i : 기준 문자 가 위치하는 index 정보.
            for(int i = 0; i < sTitle.Length;i++)
            {
                cStandardWord = sTitle[i]; // 기준 문자 할당.
                // 현재 기준 문자가 있는 i 의 위치와 
                // 기준 문자를 마지막 부터 찾은 LastIndexOf 의 주소 값이 
                // 같을 경우 = 자기자신. 중복되지 않은 문자를 찾은 경우.
                if (i == sTitle.LastIndexOf(sTitle[i]))
                {
                    // 중복 되지 않은 문자 를 찾았을 경우. 
                    bFindFlag = true;
                    break;
                }
            }
            if (bFindFlag)
            {
                MessageBox.Show($"중복 되지 않은 문자 는 {cStandardWord} 입니다.");
            }
            else
            {
                MessageBox.Show($"중복 되지 않은 문자 를 찾지 못했습니다.");
            }
        }
    }
}
