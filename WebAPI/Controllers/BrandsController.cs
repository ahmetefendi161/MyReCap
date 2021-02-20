using Business.Abstract;
using Business.Concrete;
using Business.UnitOfWork.Abstract;
using DataAccess.Concrete.EntityFrameWork.Context;
using DataAccess.Concrete.EntityFrameWork.Repository;
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
    public class BrandsController : ControllerBase
    {
        //IUnitOfWork services;
        IBrandService services;

        public BrandsController(IBrandService _services)
        {
            services = _services;

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = services.GetAll();
            if (result.Success)
            {
                //services.Dispose();
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
               //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result = services.Add(brand);
            if (result.Success)
            {
                //services.SaveChanges();
               //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Brand brand)
        {
            var result = services.Update(brand);
            if (result.Success)
            {
               // services.SaveChanges();
               //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {

            var result = services.Delete(brand);
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
