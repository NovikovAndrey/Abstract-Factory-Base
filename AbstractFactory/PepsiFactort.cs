namespace AbstractFactory
{
    internal class PepsiFactort : AbstractFactory1
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }
    }
}