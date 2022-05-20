using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRMSDCocker.Models;
using HRMSDocker.Data;

namespace HRMSDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        List<House> house = new List<House>()
        {
            new House(){HouseId = 1, HouseNo =533, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 2, HouseNo =534, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 3, HouseNo =535, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 4, HouseNo =501, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 5, HouseNo =502, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 6, HouseNo =503, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
        };
        // GET: api/Houses
        [HttpGet]
        public IActionResult Gets()
        {
            if (house.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(house);
        }

        [HttpGet("GetStudent")]
        public IActionResult Get(int id)
        {
            var houses = house.SingleOrDefault(x => x.HouseId == id);
            if (houses == null)
            {
                return NotFound("No Student Found");
            }
            return Ok(houses);
        }

    }
}
