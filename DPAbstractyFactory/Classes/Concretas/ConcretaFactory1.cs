using DPAbstractyFactory.Classes.Abstratas;

namespace DPAbstractyFactory.Classes.Concretas
{
    class ConcretaFactory1 : AbstractFactory
    {
        public override AbstractProductA MakeProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB MakeProductB()
        {
            return new ProductB1();
        }
    }
}
