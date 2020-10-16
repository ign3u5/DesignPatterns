using System;

namespace FactoryPatternExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AbstractPublishServiceFactory publishServiceFactory = new ElectronicPublishServiceFactory();
            var publication = new Publication();
            publication.Title = "Tidal Tables";
            publication.Author = "UKHO";
            publishServiceFactory.Publish(publication);
            Console.ReadLine();
        }
    }
}
