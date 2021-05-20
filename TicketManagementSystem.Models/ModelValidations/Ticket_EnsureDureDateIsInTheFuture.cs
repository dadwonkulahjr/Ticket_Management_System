using System;
using System.ComponentModel.DataAnnotations;

namespace TicketManagementSystem.Models.ModelValidations
{
    public class Ticket_EnsureDureDateIsInTheFuture : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticketInstance = validationContext.ObjectInstance as Ticket;


            if(ticketInstance != null && ticketInstance.TicketId == null)
            {
                if(ticketInstance.DueDate.HasValue && ticketInstance.DueDate < DateTime.Now)
                {
                    return new ValidationResult("The ticket date is not a valid date," +
                        "The date should be in the future!");
                }
            }


            return ValidationResult.Success;

        }
    }
}
