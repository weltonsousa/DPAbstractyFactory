using System;
using DPAbstractyFactory.Classes;
using DPAbstractyFactory.Classes.Abstratas;
using DPAbstractyFactory.Classes.Concretas;

namespace DPAbstractyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fábrica Abstrata 1
            AbstractFactory factory1 = new ConcretaFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            //Fabrica Abstrata 2
            AbstractFactory factory2 = new ConcretaFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();

        }
    }
}
