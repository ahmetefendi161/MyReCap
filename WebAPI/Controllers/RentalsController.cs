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
    public class RentalsController : ControllerBase
    {
        IRentalService services;

        public RentalsController(IRentalService _services)
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
        public IActionResult Add(Rental rental)
        {
            var result = services.Add(rental);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Rental rental)
        {
            var result = services.Update(rental);
            if (result.Success)
            {
                //services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = services.Delete(rental);
            if (result.Success)
            {
                //var result2 = services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetRentalDetailsByCarIdDto")]
        public IActionResult GetRentalDetailsByCarIdDto(int carId)
        {
            var result = services.GetRentalDetailsByCarIdDto(carId);
            if (result.Success)
            {
                //var result2 = services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetRentalDetailsDto")]
        public IActionResult GetRentalDetailsDto()
        {
            var result = services.GetRentalDetailsDto();
            if (result.Success)
            {
                //var result2 = services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("Receive")]
        public IActionResult Receive(int carId)
        {
            var result = services.Receive(carId);
            if (result.Success)
            {
                //var result2 = services.SaveChanges();
                //services.Dispose();
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
