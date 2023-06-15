// 사용자 정보 관리를 위한 사용자 정보 데이터 구조체 생성
using System;

public struct UserInfo_T
{
    // 사용자 ID
    public string UserId { get; set; }

    // 사용자 PW
    public string Password { get; set; }

    // 사용자 명
    public string UserName { get; set; }

    // 메일 주소
    public string MailAddress { get; set; }

    // 사용여부
    public bool UseFlag { get; set; }

    // 등록일시
    public DateTime MakeDate { get; set; }
}