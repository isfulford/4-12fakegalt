using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.models;
using api.data_access;
using api.interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController: ControllerBase
    {
        // GET: api/Stores -async
        [HttpGet]
        public List<Store> Get()
        {
            List<Store> myStores = new List<Store>();
            IStoreDataHandler dh = new StoreDataHandlerTest();
            myStores = dh.GetAllStores();
            return myStores;
        }

        // GET: api/Stores -async/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stores -async
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stores -async/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Stores -async/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
