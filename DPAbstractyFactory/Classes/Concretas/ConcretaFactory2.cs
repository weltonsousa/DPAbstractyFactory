using DPAbstractyFactory.Classes.Abstratas;

namespace DPAbstractyFactory.Classes.Concretas
{
    class ConcretaFactory2 : AbstractFactory
    {
        public override AbstractProductA MakeProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB MakeProductB()
        {
            return new ProductB2();
        }
    }
}
