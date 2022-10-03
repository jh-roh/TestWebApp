using System.ComponentModel.DataAnnotations;

namespace TestWebApp.NoticBoard.Models
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key] //Pk 설정
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        /// Not Null 설정
        [Required(ErrorMessage = "사용자 이름을 입력하세요.")] 
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
         //Not Null 설정
        [Required(ErrorMessage = "사용자 ID를 입력하세요.")]
        public string UserID { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        //Not Null 설정
        [Required(ErrorMessage = "사용자 비밀번호 입력하세요.")]
        public string UserPassword { get; set; }
    }
}
