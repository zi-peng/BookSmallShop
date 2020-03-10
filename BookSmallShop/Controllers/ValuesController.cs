using System.Threading.Tasks;
using BookSmallShopServer.Common;
using BookSmallShopServer.DatabaseTable;
using BookSmallShopServer.Server;
using Microsoft.AspNetCore.Mvc;


namespace BookSmallShop.Controllers
{
    /// <summary>
    /// 默认控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Get请求  异步
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ResultData>> Get()
        {
         
            int id = 1;
            ResultData result = new ResultData();
            T_PersonalCenter_User model = await UserService.GetById(id);
            result.Data = model;
            return result;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
