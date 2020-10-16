using System;

namespace FactoryPatternExample
{
    public class ElectronicPublisher : IPublisher
    {
        private readonly int _byteSize;

        public ElectronicPublisher(int byteSize)
        {
            _byteSize = byteSize;
        }
        public void publish(Publication publication)
        {
            Console.WriteLine($"The title of the electronic book is {publication.Title} and the author is {publication.Author}. {_byteSize}");
        }
    }
}