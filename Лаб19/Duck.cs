using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal abstract class Duck
    {
        private IFly _fly;
        private ISwim _swim;
        private IQuack _quack;
        protected Duck(IFly fly, IQuack quack, ISwim swim)
        {
            _fly = fly;
            _quack = quack;
            _swim = swim;
        }
        public virtual void AbilityFly()
        {
            _fly.Fly();
        }
        public virtual void AbilitySwim()
        {
            _swim.Swim();
        }
        public virtual void AbilityQuack()
        {
            _quack.Quack();
        }
    }
}
