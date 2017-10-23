namespace BullsAndCows.Web.Api.Models.Games
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class CreateGameRequestModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(4)]
        public string Number { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var digits = this
                .Number
                .Where(char.IsDigit)
                .Distinct()
                .ToList();

            if(digits.Count() != 4)
            {
                yield return new ValidationResult("Number's digits must be distinct!");
            }
        }
    }
}