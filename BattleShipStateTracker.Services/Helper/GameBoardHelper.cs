using BattleShipStateTracker.Domain;
using BattleShipStateTracker.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipStateTracker.Services.Helper
{
    public class GameBoardHelper : IGameBoardHelper
    {
        public Game PlaceShipsForGame()
        {
            var game = new Game();
            //1. Create player and  place ships for the player
            var player = new Player("Player 1");
            player.PlaceShips();
            game.Player1 = player;
            return game;
        }
    }
}
