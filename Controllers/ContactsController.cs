using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact_Service.CommonModels;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactDataStore _dataStore;

        public ContactsController(IContactDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dataStore.GetContacts());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _dataStore.GetContact(id));
        }
    }
}
