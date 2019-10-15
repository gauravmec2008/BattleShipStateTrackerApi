using System;
using System.Collections.Generic;
using System.Text;
using BattleShipStateTracker.Domain.Enums;

namespace BattleShipStateTracker.Domain.Ships
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Width { get; set; }
       public AttackerType AttackerType { get; set; }
      
    }
}