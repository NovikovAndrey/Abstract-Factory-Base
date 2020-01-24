namespace AbstractFactory
{
    internal class CocaColaFactort : AbstractFactory1
    {
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }

    }
}