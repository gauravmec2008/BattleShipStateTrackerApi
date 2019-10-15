using BattleShipStateTracker.Domain.Boards;
using BattleShipStateTracker.Domain.Enums;
using BattleShipStateTracker.Domain.Ships;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleShipStateTracker.Domain
{
    public class Player
    {
        public string Name { get; set; }
        public GameBoard GameBoard { get; set; }
        public List<Ship> Ships { get; set; }

        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>()
            {
                new Destroyer(),
                new Cruiser(),
                new Battleship()
            };
            GameBoard = new GameBoard();

        }

        public void PlaceShips()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            foreach (var ship in Ships)
            {
                //Select a random row/column combination, then select a random orientation.
                //If none of the proposed panels are occupied, place the ship
                //Do this for all ships

                bool isOpen = true;
                while (isOpen)
                {
                    var startcolumn = rand.Next(1, 11);
                    var startrow = rand.Next(1, 11);
                    int endrow = startrow, endcolumn = startcolumn;
                    var orientation = rand.Next(1, 101) % 2; //0 for Horizontal

                    List<int> panelNumbers = new List<int>();
                    if (orientation == 0)
                    {
                        for (int i = 1; i < ship.Width; i++)
                        {
                            endrow++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < ship.Width; i++)
                        {
                            endcolumn++;
                        }
                    }

                    //We cannot place ships beyond the boundaries of the board
                    if (endrow > 10 || endcolumn > 10)
                    {
                        isOpen = true;
                        continue;
                    }

                    //Check if specified panels are occupied
                    var affectedPanels = GameBoard.Panels.Range(startrow, startcolumn, endrow, endcolumn);
                    if (affectedPanels.Any(x => x.IsOccupied))
                    {
                        isOpen = true;
                        continue;
                    }

                    foreach (var panel in affectedPanels)
                    {
                        panel.AttackerType = ship.AttackerType;
                    }
                    isOpen = false;
                }
            }
        }


        public ShotResult ProcessShot(BoardPosition coords)
        {
            var panel = GameBoard.Panels.At(coords.Row, coords.Column);
            if (!panel.IsOccupied)
            {
                return ShotResult.Miss;
            }
            return ShotResult.Hit;
        }

    }

}
