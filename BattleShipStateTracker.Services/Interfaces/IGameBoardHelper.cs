using BattleShipStateTracker.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipStateTracker.Services.Interfaces
{
    public interface IGameBoardHelper
    {
        Game PlaceShipsForGame();
    }
}
