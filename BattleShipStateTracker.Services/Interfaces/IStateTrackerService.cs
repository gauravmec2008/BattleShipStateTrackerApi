using BattleShipStateTracker.Domain.Enums;

namespace BattleShipStateTracker.Services
{
    public interface IStateTrackerService
    {
        ShotResult CreateGameBoardAndProcessShots(int row, int column);
    }
}
