using System;
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
            //for (int i = 0; i < list_i.Count; i++ )
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
    }
}
