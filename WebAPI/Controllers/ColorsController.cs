using Business.UnitOfWork.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService services;

        public ColorsController(IColorService _services)
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
        public IActionResult Add(Color color)
        {
            var result = services.Add(color);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Color color)
        {
            var result = services.Update(color);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(Color color)
        {
            var result = services.Delete(color);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
