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
    public class CarsController : ControllerBase
    {
        ICarService services;

        public CarsController(ICarService _services)
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
        public IActionResult Add(Car car)
        {
            var result = services.Add(car);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Car car)
        {
            var result = services.Update(car);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            var result = services.Delete(car);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpGet("GetCarDetails")]
        public IActionResult GetCarDetails()
        {
            var result = services.GetCarDetails();
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetCarDetailsByColorId")]
        public IActionResult GetCarDetailsByColorId(int colorId)
        {
            var result = services.GetCarDetailsByColorId(colorId);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetCarDetailsByBrandId")]
        public IActionResult GetCarDetailsByBrandId(int brandId)
        {
            var result = services.GetCarDetailsByBrandId(brandId);
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
