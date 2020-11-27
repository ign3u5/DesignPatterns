using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.NauticalChart.DeliveryStrategies.Interfaces
{
    public interface IChartDeliveryStrategy
    {
        public string Deliver(string chartName);
    }
}
