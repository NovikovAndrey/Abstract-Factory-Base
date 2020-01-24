namespace AbstractFactory
{
    internal class DinamitFactort : AbstractFactory1
    {
        public override AbstractBottle CreateBottle()
        {
            return new DinamitBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new DinamitCover();
        }

        public override AbstractWater CreateWater()
        {
            return new DinamitWater();
        }
    }
}