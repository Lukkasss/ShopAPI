using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public string Teste()
        {
            return "hello world";
        }

    }
}