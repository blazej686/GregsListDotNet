using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GregsListDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _carsService;

        public CarsController(CarsService carsService)
        {
            _carsService = carsService;
        }

        [HttpGet]
        public ActionResult<List<Car>> GetCars()
        {
            try
            {
                List<Car> cars = _carsService.GetCars();
                return Ok(cars);

            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }

    }

}