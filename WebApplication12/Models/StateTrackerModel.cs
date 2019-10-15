using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication12.Validators;

namespace WebApplication12.Models
{
    [Validator(typeof(StateTrackerModelValidator))]
    public class StateTrackerModel
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
    }
}