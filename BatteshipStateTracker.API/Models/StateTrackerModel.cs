using FluentValidation.Attributes;
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