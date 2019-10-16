using System;
using System.Collections.Generic;
using System.Text;
using BattleShipStateTracker.Domain.Enums;

namespace BattleShipStateTracker.Domain.Ships
{
    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            Width = 3;
            AttackerType = AttackerType.Submarine;
        }
    }
}
