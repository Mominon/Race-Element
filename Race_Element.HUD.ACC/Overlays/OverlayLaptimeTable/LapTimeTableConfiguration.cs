﻿using RaceElement.HUD.Overlay.Configuration;

namespace RaceElement.HUD.ACC.Overlays.OverlayLaptimeTable
{
    internal sealed class LapTimeTableConfiguration : OverlayConfiguration
    {
        [ConfigGrouping("Table", "Change the behavior of the table")]
        public TableGrouping Table { get; set; } = new TableGrouping();
        public class TableGrouping
        {
            [ToolTip("Display Columns with sector times for each lap in the table.")]
            public bool ShowSectors { get; set; } = false;

            [ToolTip("Change the amount of visible rows in the table.")]
            [IntRange(1, 10, 1)]
            public int Rows { get; set; } = 3;
        }

        public LapTimeTableConfiguration() => AllowRescale = true;
    }
}
