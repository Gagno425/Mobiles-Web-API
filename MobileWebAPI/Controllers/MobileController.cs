using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile.Domain.Models;
using Mobile.Services.Abstractions;
using MobileWebAPI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileWebAPI.Controllers
{
    [Route("/")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly IMobileService _mobileService;
        private readonly IManufacturerService _manufacturerService;

        public MobileController(IMobileService mobileService, IManufacturerService manufacturerService)
        {
            _mobileService = mobileService;
            _manufacturerService = manufacturerService;
        }

        [HttpGet("GetMobiles")]
        public IEnumerable<Phone> GetMobiles()
        {
            return _mobileService.GetMobiles();
        }

        [HttpGet("GetMobile")]
        public Phone GetMobile(int requestId)
        {
            return _mobileService.GetMobileById(requestId);
        }


        [HttpPost("UpdateMobile")]
        public IActionResult UpdateMobile([Required] int requestId, MobileViewModel request)
        {

            if (ModelState.IsValid)
            {
                if (ModelState.IsValid && _mobileService.GetMobiles().Any(m => m.Id == requestId))
                {
                    Phone mobile = new Phone()
                    {
                        Id = requestId,
                        Name = request.Name,
                        Manufacturer = _manufacturerService.GetManufacturerById(request.ManufacturerId),
                        Price = request.Price
                    };


                    _mobileService.UpdateMobile(mobile);

                    return Ok();
                }
            }
            
            return BadRequest();
        }

        [HttpPost("AddMobile")]
        public IActionResult AddMobile(MobileViewModel request)
        {

            if (ModelState.IsValid)
            {
                Phone mobile = new Phone()
                {
                    Name = request.Name,
                    Manufacturer = _manufacturerService.GetManufacturerById(request.ManufacturerId),
                    Price = request.Price
                };


                _mobileService.AddMobile(mobile);

                return Ok();
            }

            return BadRequest();
        }



        [HttpPost("DeleteMobile")]
        public IActionResult DeleteMobile([Required] int requestId)
        {
            if (ModelState.IsValid && _mobileService.GetMobiles().Any(m => m.Id == requestId))
            {
                    _mobileService.RemoveMobileById(requestId);
                    return Ok();
            }

            return BadRequest();
        }
    }
}
