using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;

namespace ApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BronPcController : ControllerBase
    {
        [HttpGet]
        public List<BronPc> Get()
        {
            return DataAccess.GetBronPcs();
        }

        [HttpGet("{idBronPc}")]
        public List<BronPc> Get(int idBronPc)
        {
            var result = DataAccess.GetBronPc(idBronPc);

            return (result);
        }

        [HttpPost]
        public IActionResult Create(BronPc bronPc)
        {
            DataAccess.AddNewBronPc(bronPc);
            return NoContent();
        }
    }
}
