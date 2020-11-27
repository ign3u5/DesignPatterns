using StrategyPattern.NauticalChart.DeliveryStrategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.NauticalChart
{
    public class NauticalChart
    {
        private readonly IChartDeliveryStrategy deliveryStrategy;

        public string Id { get; protected set; }
        public string Name { get; protected set; }

        public NauticalChart(string Name, IChartDeliveryStrategy deliveryStrategy)
        {
            this.Name = Name;
            this.deliveryStrategy = deliveryStrategy;
        }
        
        public string Deliver()
        {
            return deliveryStrategy.Deliver(Name);
        }
    }
}
