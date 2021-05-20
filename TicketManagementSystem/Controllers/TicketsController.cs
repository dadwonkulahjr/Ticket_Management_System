using Microsoft.AspNetCore.Mvc;
using System;
using TicketManagementSystem.Models;

namespace TicketManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return base.Ok("Returning All the Data!");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return base.Ok($"Returning the data for the specified Id {id}");
        }

        [HttpPost]
        public IActionResult Create([FromBody]Ticket ticket)
        {
            if (!ModelState.IsValid) return BadRequest("Please enter all the data correctly!");

            return Ok(ticket);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id)
        {
            return Ok($"Updating the data on the server! {id}");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return base.Ok($"Deleting the data for the specified Id {id}");
        }

    }
}
