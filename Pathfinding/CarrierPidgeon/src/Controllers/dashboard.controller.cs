using Microsoft.AspNetCore.Mvc;
using CarrierPidgeon.Services;
using CarrierPidgeon.Models;

namespace CarrierPidgeon.Controllers
{
    [ApiController]
    [Route("/dashboard")] // Define the base route for this controller
    public class Dashboard_Controller : ControllerBase
    {
        private readonly Grid_Services gridServices;

        public Dashboard_Controller(Grid_Services gridServices)
        {
            this.gridServices = gridServices;
        }

        [HttpGet]
        public IActionResult GetGridInfo()
        {
            Grid_Model gridModel = gridServices.gridModel;

            return Ok("It fucking worked");
        }

        //Example sub route ../dashboard/{userName}
        [HttpGet("{userName}")]
        public IActionResult GetGridInfoUser(string userName)
        {
            Grid_Model gridModel = gridServices.gridModel;

            return Ok($"It fucking worked {userName}");
        }

        [HttpPost("/setGrid")]
        public IActionResult SetGridSize([FromBody] Grid_Model gridModel)
        {
            return Ok("Set grid size");
        }

        // Define additional actions and routes here, e.g., [HttpGet("otherAction")]
    }
}
