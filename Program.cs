using StrategyPattern.NauticalChart.DeliveryStrategies;
using StrategyPattern.NauticalChart;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var electronicChart = new NauticalChart.NauticalChart("Something somewhere", new ElectronicDeliveryStrategy());
            var physicalChart = new NauticalChart.NauticalChart("Something Elsewhere", new PhysicalDeliveryStrategy());

            Console.WriteLine($"Electronic: {electronicChart.Deliver()}");
            Console.WriteLine($"Physical: {physicalChart.Deliver()}");
        }
    }
}
