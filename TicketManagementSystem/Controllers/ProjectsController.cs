using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TicketManagementSystem.Models;

namespace TicketManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return base.Ok("Returning All the Data From Project Api Controller!");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return base.Ok($"Returning the data for the specified Id {id} From Project Api Controller");
        }

        [HttpPost]
        public IActionResult Create([FromBody] Ticket ticket)
        {
            if (!ModelState.IsValid) return BadRequest("Please enter all the data correctly!");

            return Ok(ticket);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute]int id, [FromBody]Ticket ticket)
        {
            return Ok($"Updating the data on the server with  specified Id {id} From Project Api Controller! title = {ticket.Title} && description = {ticket.Description}");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return base.Ok($"Deleting the data for the specified Id {id} From Project Api Controller");
        }
        [Route("/api/projects/{pid}/tickets")]
        [HttpGet]
        public IActionResult GetProjectTicket([FromQuery]int tId, [FromRoute]int pId)
        {
            if(tId == 0)
            {
                return Ok($"Reading all the tickets belong to project #{tId}");
            }
            else
            {
                return Ok($"Reading from project #{pId}" +  $" ticket #{tId}");
            }

        }
        //public IActionResult GetProjectTicket([FromQuery]Ticket ticket)
        //{
        //    if (ticket == null) return BadRequest($"Parameters are not provided properly!");
        //    if (ticket.TicketId == 0)
        //    {
        //        return Ok($"Reading all the tickets belong to project #{ticket.TicketId}");
        //    }
        //    else
        //    {
        //        if(ticket.Description == null || ticket.Title == null)
        //        {
        //            if (ticket.Description == null)
        //            {
        //                ticket.Description = "Description has not been set";
        //            }
        //            if (ticket.Title == null)
        //            {
        //                ticket.Title = "Title has not been set!";
        //            }
        //            return Ok($"Reading from project #{ticket.ProjectId}" +
        //                $"ticket #{ticket.TicketId} description = {ticket.Description} " +
        //                $"title = {ticket.Title}");
        //        }
        //        else
        //        {
        //            return Ok($"Reading from project #{ticket.ProjectId}" +
        //                                  $" ticket #{ticket.TicketId} description = {ticket.Description}" +
        //                                  $" title = {ticket.Title}");
        //        }
        //    }
        //}
        
    }
}
