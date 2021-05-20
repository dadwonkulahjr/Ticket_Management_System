

using System.ComponentModel.DataAnnotations;

namespace TicketManagementSystem.Models.ModelValidations
{
    public class Ticket_EnsureDueDateForTicketOwner : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var retrievedObjectValue = validationContext.ObjectInstance as Ticket;
            if (retrievedObjectValue != null && !string.IsNullOrWhiteSpace(retrievedObjectValue.Owner))
            {
                if (!retrievedObjectValue.DueDate.HasValue)
                {
                    return new ValidationResult("Due date is required when the ticket has an owner!");
                }
            }

            return ValidationResult.Success;
        }
    }
}
