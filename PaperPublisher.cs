using System;

namespace FactoryPatternExample
{
    public class PaperPublisher : IPublisher
    {
        private readonly string _additionalInfo;
        public PaperPublisher(string additionalInfo)
        {
            _additionalInfo = additionalInfo;
        }
        public void publish(Publication publication)
        {
            Console.WriteLine($"The title of the paper-back book is {publication.Title} and the author is {publication.Author}. {_additionalInfo}");
        }
    }
}
