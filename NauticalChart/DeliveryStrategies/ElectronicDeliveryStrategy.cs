using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.NauticalChart.DeliveryStrategies.Interfaces;


namespace StrategyPattern.NauticalChart.DeliveryStrategies
{
    public class ElectronicDeliveryStrategy : IChartDeliveryStrategy
    {
        public string Deliver(string chartName)
        {
            return $"{chartName} has been delivered electronically.";
        }
    }
}
