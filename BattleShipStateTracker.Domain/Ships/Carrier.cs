using System;
using System.Collections.Generic;
using System.Text;
using BattleShipStateTracker.Domain.Enums;

namespace BattleShipStateTracker.Domain.Ships
{
  public  class Carrier: Ship
    {
        public Carrier()
        {
            Name = "Aircraft Carrier";
            Width = 5;
            AttackerType = AttackerType.Carrier;
        }
    }
}
