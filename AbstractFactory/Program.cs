using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new CocaColaFactort());
            client.Run();
            client = new Client(new PepsiFactort());
            client.Run();
            client = new Client(new DinamitFactort());
            client.Run();
            Console.ReadKey();
        }
    }
}
