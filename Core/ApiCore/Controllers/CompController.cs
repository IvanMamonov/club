using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Core;

namespace ApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return DataAccess.GetUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<Users> Get(int idComp)
        {
            var result = DataAccess.GetUsers(idComp);
            if (result == null)
                return NotFound();

            return result;
        }
    }
}
