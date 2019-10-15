using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BattleShipStateTracker.API.Validators;

namespace BattleShipStateTracker.API.Models
{
    [Validator(typeof(StateTrackerModelValidator))]
    public class StateTrackerModel
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
    }
}