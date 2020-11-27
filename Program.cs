using System;

namespace SingletonPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeExample();
            Console.ReadLine();
        }

        static void PrototypeExample()
        {
            var pbi = new BacklogItem(4);
            pbi.AddTask("thing1");
            pbi.AddTask("thing2");
            pbi.AddTask("thing3");
            Console.WriteLine(pbi.ToString());
            var pbi2 = pbi.Clone();
            pbi2.FirstTask().Content = "differentThing";
            Console.WriteLine(pbi.ToString());
            Console.WriteLine(pbi2.ToString());
        }

        static void SingletonExample()
        {
            DataSourcerSingleton dataSourcer;
            try
            {
                dataSourcer = DataSourcerSingleton.GetInstance("bean");
            }
            catch (Exception e)
            {
                dataSourcer = DataSourcerSingleton.GetInstance("notBean");
            }
            Console.WriteLine($"File contents: {dataSourcer.ReadImpossibleFile()}");
        }
    }
}
