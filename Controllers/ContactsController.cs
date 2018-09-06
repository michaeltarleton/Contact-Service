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
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> Get()
        {
            return Ok(DataStore.GetContacts());
        }

        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            return Ok(DataStore.GetContact(id));
        }
    }
}
