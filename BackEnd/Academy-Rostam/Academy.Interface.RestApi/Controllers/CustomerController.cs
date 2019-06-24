using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Interface.RestApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Interface.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private static List<Customer> _Customers = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,Firstname = "milad",Lastname = "safari"
            },new Customer()
            {
                Id = 2,Firstname = "ali",Lastname = "safari"
            }
        };
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return _Customers;
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return _Customers.FirstOrDefault(x => x.Id == id);
        }
         
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            if (_Customers.FirstOrDefault()==null)
            {
                customer.Id = 1;
            }
            else
            {
                customer.Id = _Customers.Max(x => x.Id) + 1;
            }

            _Customers?.Add(new Customer()
            {
                Lastname = customer.Lastname,
                Firstname = customer.Firstname,
                Id = customer.Id
            });
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer customer)
        {
             var targetCustomer = _Customers.FirstOrDefault(x => x.Id == id);
             if (targetCustomer != null)
             {
                 targetCustomer.Firstname = customer.Firstname;
                 targetCustomer.Lastname = customer.Lastname;
                 targetCustomer.Id = id;
             }
             else
             {
                 return NotFound();
             }
             return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer= _Customers.FirstOrDefault(x => x.Id == id);
            if (customer ==null)
            {
                return NoContent();
            }
            _Customers.Remove(customer);
            return Ok();
        }
    }
}
