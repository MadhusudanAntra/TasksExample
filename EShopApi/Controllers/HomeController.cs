using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        
        [Route("{id:int:min(1)}")]
        public IActionResult GetData(int id)
        {
            return Ok("This is get data method "+id);

        }
      /*  [Route("{id}")]
        public IActionResult GetName(string id)
        {
            return Ok("Welcome " + id);
        }
      */

        [HttpPost]
        public IActionResult Post(Employee obj)
        {
            return Ok(obj);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        { 
            return Ok("deleted");
        }



    }


   public class Employee {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
}
