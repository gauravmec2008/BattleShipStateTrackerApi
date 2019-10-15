using BattleShipStateTracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class StateTrackerController : ApiController
    {
        private readonly IStateTrackerService _stateTrackerService;
        public StateTrackerController(IStateTrackerService stateTrackerService)
        {
            _stateTrackerService = stateTrackerService;
        }

        [HttpPost]
        [Route("processshot")]
        public HttpResponseMessage CreateGameBoardAndProcessShots(StateTrackerModel stateTrackerModel)
        {
            var shotResult = _stateTrackerService.CreateGameBoardAndProcessShots(stateTrackerModel.RowNumber, stateTrackerModel.ColumnNumber);
            return Request.CreateResponse(HttpStatusCode.NotFound, shotResult);
        }

    }
}

