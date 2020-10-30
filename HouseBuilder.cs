namespace BuilderPattern
{
    public class HouseBuilder
    {
        

        public static HouseBuilder Create()
        {
            return new HouseBuilder();
        }
    }
}
