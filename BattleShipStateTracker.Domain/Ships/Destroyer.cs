namespace BattleShipStateTracker.Domain.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            Width = 2;
            AttackerType = Enums.AttackerType.Destroyer;
        }
    }
}

