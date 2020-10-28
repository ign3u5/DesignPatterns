namespace FacadeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityWeatherFacade = new CityWeatherWriterFacade();

            cityWeatherFacade.GetWeatherForSpecifiedCities("Cities.txt");
        }
    }
}
