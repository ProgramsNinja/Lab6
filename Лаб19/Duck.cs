using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal abstract  class Duck
    {
        protected IFly _fly;
        protected ISwim _swim;
         protected IQuack _quack;
        protected Duck(IFly fly, IQuack quack, ISwim swim)
        {
            _fly = fly;
            _quack = quack;
            _swim = swim;
        }
        public abstract void AbilityFly();
        public abstract void AbilitySwim();
        public abstract void AbilityQuack();
    }
}
