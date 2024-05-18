using DPAbstractyFactory.Classes.Abstratas;

namespace DPAbstractyFactory.Classes
{
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.MakeProductA();
            _abstractProductB = factory.MakeProductB();
        }

        public void Run() 
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
