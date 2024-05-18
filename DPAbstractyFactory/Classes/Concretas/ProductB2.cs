using DPAbstractyFactory.Classes.Abstratas;
using System;

namespace DPAbstractyFactory.Classes.Concretas
{
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine("Produto B2" + " interage com Produto A2");
        }
    }
}
