#region Using declarations
using System;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;

namespace NinjaTrader.NinjaScript.Strategies
{
    public class ConvertedStrategy : Strategy
    {
        protected override void OnStateChange()
        {
            if (State == State.SetDefaults)
            {
                Description = "Converted from MQL";
                Name = "ConvertedStrategy";
            }
        }

        protected override void OnBarUpdate()
        {
            // Converted MQL logic here
        }
    }
}