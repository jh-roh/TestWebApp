using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using TestWebApp_DevExtreme.Models;

namespace TestWebApp.DevExtreme.Controllers
{
    [Route("api/[controller]")]
    public class DataGridFilteringController : Controller
    {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleOrderWithDeliveryData.OrdersWithDelivery, loadOptions);
        }
    }
}
