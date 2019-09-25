﻿using StardewValley;

namespace FamilyPlanning
{
    class FamilyData
    {
        public int TotalChildren { get; set; }

        public FamilyData()
        {
            if(Game1.player.getChildrenCount() > 0)
                TotalChildren = Game1.player.getChildrenCount();
            else
                TotalChildren = 2;
        }
    }
}