using System;
using System.ComponentModel.DataAnnotations;
using TicketManagementSystem.Models.ModelValidations;


namespace TicketManagementSystem.Models
{
    public class Ticket
    {
        //[FromQuery(Name ="tid")]
        public int? TicketId { get; set; }
        //[FromRoute(Name ="pid")]
        [Required]
        public int? ProjectId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        [Ticket_EnsureDueDateForTicketOwner]
        [Ticket_EnsureDureDateIsInTheFuture]
        public DateTime? DueDate { get; set; }
    }
}
