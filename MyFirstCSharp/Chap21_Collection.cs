﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;

namespace MyFirstCSharp
{
    // Collection
    // 특정 데이터 를 여러개 담아서 관리 할 수 있는 자료형 구조. 
    // 몽땅 포함하여 Collection 이라고 한다. 
    // Collection 이라고 불리는 자료형 구조들 (List, ArrayList, Dic, Stack,... )
    // 은 모두 Collection 을 상속 받아 구현된 개체(클래스) 
    public partial class Chap21_Collection : Form
    {
        public Chap21_Collection()
        {
            InitializeComponent();
        }

        #region < LIST >
        private void btnList_Click(object sender, EventArgs e)
        {

            //List  < Collection 
            // 배열과 유사항 열거형 데이터 자료 
            // 크기가 가변적인 데이터를 담을수 있다.

            // 요소 : index 와 데이터 값 을 통틀어 부르는 말.

            // 1. 리스트 의 생성
            // int[]
            List<int> list_iValues = new List<int>(); // 정수형 List 의 생성.
                                                      // 정수형 List 클래스 를 list_iValues 라는 이름으로 new 키워드를 이용하여 
                                                      // 객체화(사용가능한 실체) 하여 현제 블럭에서 사용하겠다.
            //string[]
            List<string> list_sValues = new List<string>(); // 문자열 형 List 의 생성.


            // 2. 리스트에 데이터 할당. 
            list_iValues.Add(100);
            list_iValues.Add(44);
            list_sValues.Add("안녕하세요");
            list_sValues.Add("반갑");

            // 3. 리스트 생성과 동시에 값 할당. 
            List<int> list_iValues2 = new List<int>() { 11, 34, 53, 119, 330 };

            // 4. 리스트의 개수를 확인. (Count)
            // 배열 개수 : Length
            MessageBox.Show($"list_iValues2 의 데이터 개수 는 {list_iValues2.Count} 입니다.");

            // 5. 리스트 요소의 데이터 확인하기.
            StringBuilder sb = new StringBuilder();

            // 5-1 열거형 이므로 Foreach 를 사용하여 데이터 추출 가능.
            foreach ( int iValue in list_iValues2 ) 
            {
                sb.Append(iValue + "\r\n");
            }
            MessageBox.Show(sb.ToString());

            sb.Clear(); // 스트링 빌더의 값 초기화.

            // 5-2 For 를 이용하여 index 의 데이터를 추출 .
            // 배열과 마찬가지로 데이터(Data) 의 주소(index) 를 이용하여 요소를 관리.
            for(int i = 0; i < list_iValues2.Count; i++ )
            {
                sb.Append(list_iValues2[i] + "\r\n");
            }
            MessageBox.Show(sb.ToString());

            // List 는 클래스 , 배열과 마찬가지로 참조형. 
            // 기본적으로 클래스는 참조형. Heap 메모리 영역에 등록.

            // 6. List 의 복사
            // 6-1 참조 전달. (얕은 복사)
            List<int> list_Copy = list_iValues2;
            list_Copy[0] = 55555;
            MessageBox.Show($"얕은복사 방식으로 list_Copy[0] 에 할당한 55555 값이 " +
                            $"list_iValues2[0] 값({list_iValues2[0]})과 동일합니다.");

            // 6-2 Heap 에 할당된 값 자체를 복사. (깊은복사) 
            // .ToList() : 리스트 를 깊은복사 하는 방법.
            List<int> list_Copy2 = list_iValues2.ToList();
            list_Copy2[0] = 11;
            MessageBox.Show($"깊은복사 방식으로 list_iValues2 의 값을 복사한 list_Copy2 " +
                            $"리스트의 0번 주소 값이 11 로 바뀌었지만. list_iValues2[0]" +
                            $"의 값은 {list_iValues2[0]} 인것을 확인 할수 있습니다.");
        }

        private void btnListII_Click(object sender, EventArgs e)
        {
            // 리스트 2. 
            List<int> list_i = new List<int>() { 11,34,53,119, 119,66, 150,20,300};

            // 7. 리스트에 요소를 추가. (index + 데이터) Insert()
            list_i.Insert(2, 300);

            // 8. 리스트의 특정 요소를 제거. 
            // Remove
            // - 데이터가 존재할 경우 데이터의 index 를 함께 삭제 . 
            //   데이터가 없을경우 아무일도 일어나지 않는다. 
            //   * 해당 index 가 삭제 되고난 후 순차적으로 채워넣기 식으로 재정렬
            //   가까운 index 로 부터 하나의 데이터가 삭제
            list_i.Remove(119);

            // Removeat
            // - index 위치의 요소(index, 값) 를 삭제
            //    해당 index 를 삭제 후 index 가 순차적으로 채워넣기 식으로 정렬
            list_i.RemoveAt(5);
            //list_i.RemoveAt(100); // 존재 하지 않는 index 의 경우 오류가 발생. 

            // 9. 특정 조건을 만족 할 경우 List 요소를 제거. 
            //foreach (int iValue in list_i )
            //{
            //    if (iValue > 100)
            //    {
            //        list_i.Remove(iValue);
            //    }
            //}
            /* Foreach 사용시 열거형 요소는 수정, 추가 할 수 없다. 
               Foreach 는 열거형 데이터를 읽기 전용으로 가져오기 때문에 
               최초 Foreach 문으로 읽어온 list_i 가 실행될 당시의 구조와 갱신되었을경우
               마지막 요소까지 순차적으로 실행 할 수 없기 때문에 오류를 발생. 
             */

            // 그러면 ? 특정 조건을 만족 시킬때 (ex iValue > 100 ) 리스트의 요소를 삭제 하는 방법 ? 
            // i : 리스트의 index 를 가리키는 정수.

            // 해결 1 : index 의 요소를 삭제 후 현재 index 를 다시 비교 할 수 있도록 i 를 1 차감.
            //for (int i = 0; i < list_i.Count; i++)
            //{
            //    if (list_i[i] > 100)
            //    {
            //        list_i.RemoveAt(i);
            //        --i;
            //    }
            //}

            // 해결 2 
            // 역 For  문을 이용하여 마지막 index 로 부터 순차적으로 처리 하도록 하는 방법.
            for (int i = list_i.Count - 1; i >= 0; i--)
            {
                if (list_i[i] > 100)
                {
                    list_i.RemoveAt(i);
                }
            }
            // 마지막 index 로 부터 검색 해서 올라올 경우 (역 For)
            // 현재 index 의 요소 가 삭제 되더라도 . 
            // 현재 index 이후의 데이터 들만 재정렬 되므로
            // 다음 처리해야 할 index ( 현재 index - 1) 의 데이터 는 
            // 위치 변경이 없으므로 원활히 삭제 가 가능하다. 
        }

        #endregion
       
        #region < Array List >
        private void btnArrayList_Click(object sender, EventArgs e)
        {
            // ArrayList 
            // - 데이터 형식에 상관없이 다중 데이터를 관리 할 수 있는 데이터 타입. 
            // - 데이터 형식에 구애 없이 데이터가 할당 되므로
            //   데이터를 확인할 때는 반드시 데이터 형 변환이 이루어져야한다.

            // 1. ArryList 의 생성. 
            // using System.Collections; 
            //   . ArrayList클래스가 있는 DLL 파일 (프로젝트, 어셈블리, 네임스페이스)
            ArrayList arraylist = new ArrayList();

            // 2. 데이터를 등록 하는 방법. 
            for (int i = 0; i < 11; i++)
            {
                // arraylist 에 정수형 데이터를 0 ~ 10 까지 할당
                arraylist.Add(i);
            }
            arraylist.Add("안녕하세요");
            // ArrayList 에 데이터를 등록 할 때 Object 형식으로 할당 된다. (Boxing)

            // 오름차순 정렬 
            // arraylist.Sort(); 
            // 정수형 데이터 와 문자 데이터 가 혼합 등록 되어있으므로 오류가 발생. 

            // 요소(index, 데이터) 삭제.
            
            arraylist.Remove(3); // 3 이라는 값을 가진. 데이터의 요소를 삭제

            arraylist.Remove("안녕하세요");

            arraylist.RemoveAt(3); // 3번 index 의 요소를 삭제

            // 요소의 등록.
            arraylist.Insert(2, 40);


            // ArrayList 에 기존 컬렉션의 데이터를 추가 하는 방법. 
            // arraylist < -int[]
            int[] iValues = { 1, 2, 3, 4 };
            
            // ArrayList 라는 클래스를 사용할껀데
            // 정수 배열 iValues 를 던져 줄테이 이값을 가지고 복사해서 
            // 초기 값을 할당후(초기화) 사용하게 해주세요.
            ArrayList arraylist2 = new ArrayList(iValues);
            MessageBox.Show(arraylist2[0].ToString());
            arraylist2[0] = "안녕하세요";

            ArrayList arrarylist3 = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //위 방법은 아래의 내용과 동일한 결과 를 나타낸다
            //int[] iValues2 = new int[] { 1, 2, 3, 4, 5 };
            //ArrayList arrarylist3 = new ArrayList(iValues2); 
        }


        #endregion

        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Queue 
            // 선입 선출 방식의 자료 구조. 
            // 데이터나 작업을 차례대로 입력된 순서에 따라 하나씩 처리.
            // 웹 등에서 동영상 이나 문서 등의 파일을 다운 받을때  순차적으로 처리 하기 위해 데이터 를 담을때 주로 사용.

            // 1. Queue 의 선언. 
            Queue<int> queue  = new Queue<int>();

            // 2. Queue 에 데이터 등록. 
            // 할당하는 식으로 등록 하는것이 아닌 데이터 등록 메서드가 별도로 존재.
            queue.Enqueue(10); // 선입 선출 할수 있는 데이터 정렬을 하는 기능. 
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            // 3. Queue 데이터를 확인 
            // 어떤 데이터가 있는지 확인.
            foreach(int iValue in queue)
            {
                MessageBox.Show("Foreach : " + iValue.ToString());
            }

            // Queue 의 데이터를 확인.
            for (int i = 0; i < queue.Count;i++)
            {
                MessageBox.Show("Peek : " + queue.Peek());
                // 우선 순위가 높은 (선입) 데이터 를 표현.
                // 현재 추출될 데이터가 무엇인지 확인 하고 로직을 처리하는데 사용.
            }

            // Queue 의 데이터를 사용하기 위하여 추출 하고 요소를 삭제.
            while(queue.Count > 0)
            {
                MessageBox.Show(queue.Dequeue().ToString());
            }


            // 다른 컬렉션의 데이터를 Queue 에 담기.
            Queue queue2 = new Queue(new int[] { 1, 2, 3, 4, 5 });


            Queue queue3 = new Queue(new List<int>(){1,2,3,4,5});

            //// 위 의 List 대입 문법은 아래와 같이 표현할 수 있다. 
            //List<int> iValues = new List<int>();
            //iValues.Add(1);
            //iValues.Add(2);
            //iValues.Add(3);
            //iValues.Add(4);
            //iValues.Add(5); 

            //List<int> iValues2 = new List<int>() { 1,2,3,4,5,};
            //Queue queue4 = new Queue(iValues2);


            // Queue 
            // 데이터 를 순차적으로 담아서 처리 ( 선입 선출 ) 후 메모리에서 데이터를 삭제 하므로 
            // 메모리 관리에 용이한  자료 형 구조 이나. 
            // 데이터가 휘발성 (확인후 삭제) 되므로 필요한 곳에 따라서 잘 사용할수 있도록 하자. 
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            // Stack 
            // 선입 후출 방식의 데이터 자료 구조. 
            // 메모리 영역의 Stack 과 이름은 같으나 자료형 구조의  Stack 인 경우 Stack 메모리 영역에 데이터가 
            // 관리되는 방법을 나타낸다. 

            // Stack 과 Queue 는 
            // 데이터가 등록 되고 호출 시 메모리에서 삭제 되므로 
            // 메모리 관리에 용이하다 (데이터 사용 후 즉각 처리). 


            // Stack 의 생성. 
            Stack<int> stack = new Stack<int>();

            // stack 에 데이터를 등록하는 방법
            stack.Push(10); // 후입 선출 하기 위해 데이터를 재정렬 하는 기능.
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            // 데이터 확인.
            foreach(int iValue in stack)
            {
                MessageBox.Show("Foreach : " + iValue.ToString());
                // 나중에 들어온 데이터를 우선순위로 하여 보여준다. 
            }

            // 데이터를 제거 하지 않고 표현.
            for (int i =0; i < stack.Count; i++)
            {
                MessageBox.Show("Peek : " + stack.Peek());
                // 40 , 40 , 40 , 40
            }

            // 데이터를 추출 후 우선순위 재 정렬 . 
            // Pop : 데이터 추출 및 재 정렬 하는 기능.
            while (stack.Count > 0)
            {
                MessageBox.Show(stack.Pop().ToString());
            } 
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            // Dictionary 
            // 데이터가 담기는 주소를 Key 로 설정하여 데이터를 등록하는 자료형 구조.

            // 1. Dictionary 의 생성
            Dictionary<string, int> MyDic = new Dictionary<string, int>();

            // 2. DIc 에 데이터 등록. 
            MyDic.Add("하나", 10);
            MyDic.Add("둘", 20);
            //MyDic.Add(1, "하나"); // Key 와 값의 데이터 자료형이 일치하지않는 오류
            MyDic["셋"] = 40; // 셋 이라는 키를 가진 요소를 새로 생성 하면서 40 값을 할당.\
            // iValues[0] = 40; 

            // 3. Dic 의 데이터 확인.
            MessageBox.Show(MyDic["셋"].ToString());

            // 4. DIc 의 복사. 
            // 참조 전달 복사 ( 주소 전달 ) 
            Dictionary<string, int> MyDic_Copy = MyDic;
            MyDic_Copy["하나"] = 100;
            MessageBox.Show(MyDic["하나"].ToString());

            // 값 형태로 복사 . (깊은 복사) 
            // MyDic_Copy2 이라는 이름으로 Dictionary 클래스의 기능을 사용할껀데. 
            // MyDic 에 있는값으로 새로운 메모리 데이터를 만들어서 할당하여 사용하게 해주세요.
            Dictionary<string, int> MyDic_Copy2 = new Dictionary<string, int>(MyDic);
            MyDic["하나"] = 4000;
            MessageBox.Show(MyDic_Copy2["하나"].ToString());

            // 5. Key 를 사용하고 있는지 확인하는 기능. 
            if (MyDic.ContainsKey("열"))
            {
                MessageBox.Show("열 라는 키를 사용하고있습니다.");
            }
            else
            {
                MessageBox.Show("열 라는 키를 사용하고있지 않습니다.");
            }

            // 6. Value  의 사용유무 확인.
            if (MyDic.ContainsValue(100))
            {
                MessageBox.Show("100 값이 포함되어 있습니다.");
            }
            else
            {
                MessageBox.Show("100 값이 포함되어있지 않습니다.");
            }

            // 데이터의 삭제 . 
            MyDic.Remove("둘"); // "둘" 이라는 key 의 요소를 삭제.
            // MyDic 의 Remove 는 해당 Key 가 존재 하지 않을 경우 오류 가 반환 되지 않는다.
            MyDic.Remove("백");

        }

        private void btnhashTable_Click(object sender, EventArgs e)
        {
            // HashTable 
            // Dictionary 와 유사한 기능을 가지지만. 
            // Key 와 Value 의 데이텅 유형을 따로 정해주지 않는다. (object 방식)
            // Value 의 내용이 데이터 타입이 지정되지 않았으므로
            // 호출 시에는 반드시 형 변환 과정이 필요하다. 


            // 생성 및 데이터 등록.
            Hashtable HT = new Hashtable();
            HT.Add("하나", 1);
            HT[10] = "십";
            HT["소수"] = 1.2;
            HT.Add(true, "트루");

            //  2. HashTable 의 데이터 표현. 
            // (int) : 명시적 형변환 캐스팅 (강제 형변환)
            //         * 반드시 변형 되어야 하는 데이터 형이 정해져 있어(일치해)야 한다. 
            //int iValue = (int)HT[10]; // unboxing 을 통한 데이터 타입 일치. (오류) "십" -> 정수 
            string sValue = (string)HT[10];

            // a
        }
    }
}
;