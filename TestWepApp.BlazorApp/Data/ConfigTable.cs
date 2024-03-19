namespace TestWepApp.BlazorApp.Data
{
    public class ConfigTable
    {
        public int Id { get; set; } = 1;

        public string Name { get; set; } = string.Empty;

        public string Product { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public DateTime WhenBuy { get; set; } 


    }

    public class TableCell
    {
        List<ConfigTable> CT = new List<ConfigTable>();

        public List<ConfigTable> Configure()
        {
            CT.Add(new ConfigTable() { Id = 1, Name = "가래떡", Product = "음식물", Category = "떡", Price = "1000", WhenBuy = DateTime.Now });
            CT.Add(new ConfigTable() { Id = 2, Name = "라면", Product = "음식물", Category = "면", Price = "1200", WhenBuy = DateTime.Now });
            CT.Add(new ConfigTable() { Id = 3, Name = "냉동만두", Product = "음식물", Category = "냉동식품", Price = "4000", WhenBuy = DateTime.Now });
            CT.Add(new ConfigTable() { Id = 4, Name = "헤어핀", Product = "문구류", Category = "헤어용품", Price = "500", WhenBuy = DateTime.Now });
            CT.Add(new ConfigTable() { Id = 5, Name = "칫솔", Product = "위생용품", Category = "화장실용품", Price = "800", WhenBuy = DateTime.Now });
            
            return CT;
        }
    }
}
