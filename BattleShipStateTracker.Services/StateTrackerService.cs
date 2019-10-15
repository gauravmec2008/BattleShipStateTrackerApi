using BattleShipStateTracker.Domain;
using BattleShipStateTracker.Domain.Boards;
using BattleShipStateTracker.Domain.Enums;

namespace BattleShipStateTracker.Services
{
    public class StateTrackerService : IStateTrackerService
    {

        public ShotResult CreateGameBoardAndProcessShots(int row, int column)
        {
            var game = CreateGameBoard();
            var coordinates = new BoardPosition(row, column);
            return game.Player1.ProcessShot(coordinates);
        }

        private Game CreateGameBoard()
        {
            Game game = new Game();

            //1. Create player and  game and firing boards
            Player p1 = new Player("Player 1");         

            game.Player1 = p1;         

            //2. Add ships to the board
            p1.PlaceShips();
           
            return game;
        }

    }
}
