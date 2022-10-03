namespace TestWebApp.NoticBoard.Models
{
    /*
     ASP.NET Identity(Security)
    - 사용자 로그인(인증)
    - 사용자 Role (Admin, User, PowerUser)
    - SMS 인증, Email 인증     

    Session 이용한 로그인, 회원가입 구현


    로그인 2가지 방법론
    #1. Session
    - 웹 서버가 사용자 정보를 메모리 담아놓고
    -> 보안성이 높다. (웹 서버 안에서만 돌기 때문에)
    -> 웹 서버 메모리 부하가 높아진다.

    #2. Coolie
    - 웹 서버 로그인 -> 사용자 정보 -> 브라우저 전달

    -> 쿠키
    => 웹 서버의 부하가 낮아진다.
    => 보안성 낮아짐.

    #결론 : Cookie
    - Cookie -> 암호화 -> 복호화
    - SSL, SSL 인증서가 있고, 웹사이트에 통하는 모든 입출력에 관한 내용을 인증서 회사로 전달
    SSL => 유료, 무료
        => 100만워느 20만원 
     */


    /*
     Model -> 기본 엔티티 클래스

    User
    -> UserNo
    -> UserName
    ID, password

    ViewModel -> 뷰(View)를 위한 모델
    MVC(Model, View Controller)
    WPF(MVVM)
     
     
     */


    /*
     ASP.NET MVC -> IIS(웹서버) = 아파치
    - WebAPI 압축
    
    ASP.NET Core -> 리눅스, 윈도우, MacOS



     
     
     */
}
