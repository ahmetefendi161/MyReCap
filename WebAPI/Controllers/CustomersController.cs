using Business.Abstract;
using Business.UnitOfWork.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService services;

        public CustomersController(ICustomerService _services)
        {
            services = _services;

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = services.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = services.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = services.Add(customer);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Customer customer)
        {
            var result = services.Update(customer);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = services.Delete(customer);
            if (result.Success)
            {
                //var result2 =services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
