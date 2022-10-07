using System.Collections.Generic;

namespace TestWebApp.DotNetSale.Models
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// 카테고리 전체 정보 읽어오기
        /// </summary>
        /// <returns></returns>
        List<Category> GetCategories();
    }
}
