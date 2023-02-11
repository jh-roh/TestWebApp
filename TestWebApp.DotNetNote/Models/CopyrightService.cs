using System;

namespace TestWebApp.DotNetNote.Models
{
    public class CopyrightService : ICopyrightService
    {
        //@inject 키워드로 뷰에 직접 주입해서 사용하기
        public string CopyrightString { get; set; } = $"Copyright {DateTime.Now.Year} all right reserved";

        public string GetCopyrightString()
        {
            return $"Copyright {DateTime.Now.Year} all right reserved" 
                 + $" from CopyrightService {GetHashCode()}";
        }
    }
}
