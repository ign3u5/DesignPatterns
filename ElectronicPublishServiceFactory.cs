using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class ElectronicPublishServiceFactory : AbstractPublishServiceFactory
    {
        protected override IPublisher CreatePublisher()
        {
            return new ElectronicPublisher(5);
        }
    }
}
