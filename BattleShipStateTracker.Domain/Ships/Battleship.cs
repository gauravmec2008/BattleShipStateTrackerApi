namespace BattleShipStateTracker.Domain.Ships
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            Width = 4;
            AttackerType = Enums.AttackerType.Battleship;
        }
    }
}
