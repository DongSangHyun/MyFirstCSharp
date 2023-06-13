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
    public partial class Chap25_RecursiveFunction_T : Form
    {
        int iLoopCount = 0; // 반복 문이 실행 되는 횟수,
        public Chap25_RecursiveFunction_T()
        {
            InitializeComponent();
        } 

        private void btnList_Click(object sender, EventArgs e)
        {
            // 리스트 를 통한 피보나치 수열 의 값 구하기
            int iLoopCount = 0; // 반복 횟수 초기화

            // 리스트의 초기 값 0 과 1 등록. ( 피보나치 수열에서 전전 값과, 전 값이 등록되어 보관될 용도 )
            List<int> iList = new List<int>()
            { 
                     0,    1
                // [0],  [1]
            };

            bool bCheck = int.TryParse(txtInput.Text, out int iTurn) ; // out int iResutl iResult 를 생성 하면서 out  값을 할당 받기.
            if (!bCheck) return;
            
            // 입력한 순차 iTurn 
            if (iTurn > 2)  // 입력한 차수 가 3 이상일때.
            {
                // i : list 에 등록될 값의 index
                for (int i = 2; i < iTurn; i++)
                {
                    iList.Add(iList[i - 2] + iList[i - 1]);
                    ++iLoopCount;
                }
                ++iLoopCount;
            }
            MessageBox.Show($"피보나치 수열 {iTurn} 번째의 값은 {iList[iTurn - 1]} 입니다. 총 반복횟수  : {iLoopCount} ");
        }

        private void btnOutValue_Click(object sender, EventArgs e)
        {
            // 외부 변수를 사용하여 피보나치 수열 의 값 구하기. 

            iLoopCount = 0; // 반복횟수 초기화.

            // 입력한 순차. iTurn
            bool bCheck = int.TryParse(txtInput.Text, out int iTurn); // out int iResutl iResult 를 생성 하면서 out  값을 할당 받기.
            if (!bCheck) return;

            int iNow = 1;    // 현재 값
            int iBefore = 0; // 이전 값.
            int iTemp = 0;   // 현재값을 이전값으로 할당하기 위한 임시 변수.

            int iResult = 0; 
            // 1번째 수열 을 구할 경우.
            if (iTurn == 1)
            {
                iResult = iBefore; // 1 번째 수열은 0 기초값. 
            }
            else if (iTurn == 2)
            {
                iResult = iNow;
            } 
            else if (iTurn > 2)
            {
                // i : 차수 구하려고 하는 수열의 위치. 순번.
                for (int i = 3; i <= iTurn; i++)
                {
                    iTemp = iNow; // 현재 값을 이전 값으로 등록 하기 위해 임시 데이터에 옮겨 놓기. 
                    iNow = iNow + iBefore; // 구하려는 차수의 값을 현재값 + 이전값 
                    iBefore = iTemp; // 현재 값을 이전 값으로 할당.
                    ++iLoopCount; // 반복 횟수 + 1
                }
                ++iLoopCount; // for 반복문에서 false 로 만들기 위해 i 가 1이 증가 되기위해 처리되는 수행도 1 반복
                iResult = iNow;
            } 
            MessageBox.Show($"피보나치 수열 {iTurn} 번쨰의 값은 {iResult} 입니다. 총 반복 횟수 : {iLoopCount}");
        }

        private void btnRecursive_Click(object sender, EventArgs e)
        {
            /* 재귀 함수 (Recursive Function)
               메서드 내부에서 자기 자신을 반복적으로 호출 하는것을 말한다. 
                *자신을 호출하는 부분(베서드를 호출하는 로직) 을 만나지 않을때 까지 반복한다. 
              
              - 장점. 
               . 직관적인 코드 를 구현 할 수 있으며 복잡한 문제를 쉽게 표현 할 수 있다. 
             
              - 단점. 
               . 호출이 완료 되기 전까지 Stack 메모리에 절차 과정이 누적되므로 StackOverFlower 오류 가 발생 할 수 있다. 
               . 종료 시점을 명확히 하지 않으면 무한 루프 에 빠질 수 있다. 
               . 반복할 노드(횟수) 가 많아 질 수록 효율성이 떨어진다. 
                   - 메모이제이션 기법으로 보완이 가능. (메모화)
             */

            iLoopCount = 0; // 반복 횟수 0 할당.

            // 입력한 순차. iTurn
            bool bCheck = int.TryParse(txtInput.Text, out int iTurn); // out int iResutl iResult 를 생성 하면서 out  값을 할당 받기.
            if (!bCheck) return;

            // 반복 수행 할 메서드 재귀 메서드 를 호출.
            int iResult = GetFibonacciNum(iTurn); // 피보나치 순번의 값을 확인하기 위한 재귀 메서드 호출.
        }

        // 재귀 메서드 
        int GetFibonacciNum(int _iTurn)
        {
            return 0;
        }

    }
}
