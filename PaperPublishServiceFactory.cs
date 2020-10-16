using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class PaperPublishServiceFactory : AbstractPublishServiceFactory
    {
        protected override IPublisher CreatePublisher()
        {
            return new PaperPublisher("Some more info on this paper");
        }
    }
}
