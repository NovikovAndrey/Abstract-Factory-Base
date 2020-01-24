namespace AbstractFactory
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;
        public Client(AbstractFactory1 factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
        }

        internal void Run()
        {
            bottle.Interact(water, cover);
        }
    }
}
