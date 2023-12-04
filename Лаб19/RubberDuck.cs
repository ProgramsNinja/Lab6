using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal class RubberDuck : Duck
    {
        private IFly _flyType = new CantFly();
        private ISwim _swimType = new CanSwim();
        private IQuack _quackType = new CanQuack();
        public override void AbilityFly()
        {
            _flyType.Fly();
        }

        public override void AbilityQuack()
        {
            _quackType.Quack();
        }

        public override void AbilitySwim()
        {
            _swimType.Swim();
        }
    }
}
