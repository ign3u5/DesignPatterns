using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public abstract class AbstractPublishServiceFactory
    {
        protected abstract IPublisher CreatePublisher(); 

        public void Publish(Publication publication)
        {
            var publisher = CreatePublisher();
            publisher.publish(publication);
        }
    }
}
