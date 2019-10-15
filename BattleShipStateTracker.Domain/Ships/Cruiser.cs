namespace BattleShipStateTracker.Domain.Ships
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            Width = 3;
            AttackerType = Enums.AttackerType.Cruiser;
        }
    }
}
