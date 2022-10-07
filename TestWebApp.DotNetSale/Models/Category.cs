namespace TestWebApp.DotNetSale.Models
{
    public class Category
    {
        /// <summary>
        /// 카테고리 번호
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// 카테고리 이름
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 부모 카테고리 번호
        /// </summary>
        public int SuperCategory { get; set; }


        /// <summary>
        /// 카테고리 보여지는 순서
        /// </summary>
        public int Align { get; set; }
    }
}
