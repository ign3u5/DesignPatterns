using StrategyPattern.NauticalChart.DeliveryStrategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.NauticalChart.DeliveryStrategies
{
    public class PhysicalDeliveryStrategy : IChartDeliveryStrategy
    {
        public string Deliver(string chartName)
        {
            return $"{chartName} has been delivered physically.";
        }
    }
}
