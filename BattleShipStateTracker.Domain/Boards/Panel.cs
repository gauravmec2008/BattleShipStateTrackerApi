using BattleShipStateTracker.Domain.Enums;

namespace BattleShipStateTracker.Domain.Boards
{
    public class Panel
    {
        public AttackerType AttackerType { get; set; }
        public BoardPosition Coordinates { get; set; }

        public Panel(int row, int column)
        {
            Coordinates = new BoardPosition(row, column);
            AttackerType = AttackerType.Empty;
        }

        public Panel(int row, int column, AttackerType attackerType)
        {
            Coordinates = new BoardPosition(row, column);
            AttackerType = attackerType;
        }

        public bool IsOccupied
        {
            get
            {
                return AttackerType == AttackerType.Battleship
                    || AttackerType == AttackerType.Destroyer
                    || AttackerType == AttackerType.Cruiser;

            }
        }
    }
}
