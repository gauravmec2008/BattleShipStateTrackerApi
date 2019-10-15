using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication12.Models;

namespace WebApplication12.Validators
{
    public class StateTrackerModelValidator : AbstractValidator<StateTrackerModel>
    {
        public StateTrackerModelValidator()
        {
            RuleFor(x => x.RowNumber).NotEqual(0).WithMessage("The Row Number for shot cannot be 0.")
                                        .LessThanOrEqualTo(10).WithMessage("The Row Number for shot cannot be greater than 10.");

            RuleFor(x => x.ColumnNumber).NotEqual(0).WithMessage("The Column Number for shot cannot be 0.")
                                       .LessThanOrEqualTo(10).WithMessage("The Column Number for shot cannot be greater than 10.");
        }
    }
}