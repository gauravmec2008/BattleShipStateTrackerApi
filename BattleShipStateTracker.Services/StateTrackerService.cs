using BattleShipStateTracker.Domain;
using BattleShipStateTracker.Domain.Boards;
using BattleShipStateTracker.Domain.Enums;
using System.Linq;

using BattleShipStateTracker.Services.Interfaces;

namespace BattleShipStateTracker.Services
{
    public class StateTrackerService : IStateTrackerService
    {
        private readonly IGameBoardHelper _gameBoardHelper;
        public StateTrackerService(IGameBoardHelper gameBoardHelper)
        {
            _gameBoardHelper = gameBoardHelper;
        }

        public ShotResult CreateGameBoardAndProcessShots(int row, int column)
        {
            var game = _gameBoardHelper.PlaceShipsForGame();
            var coordinates = new BoardPosition(row, column);
            return game.Player1.ProcessShot(coordinates);
        }

    }
}
