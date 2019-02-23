using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session10.Data;
using Session10.Data.Entities;

namespace Session10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {
        public CatContext _context;
        public CatController(CatContext context){
            _context=context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string[] cats=new string[3];
            int i=0;
            foreach(Cat c in _context.Cats){
                cats[i]=c.ToString();
                i++;
            }

            return cats;
        }
    }
}
