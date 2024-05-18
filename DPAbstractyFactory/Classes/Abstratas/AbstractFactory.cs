using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractyFactory.Classes.Abstratas
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA MakeProductA();
        public abstract AbstractProductB MakeProductB();
    }
}
