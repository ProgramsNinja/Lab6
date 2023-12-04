using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб19
{
    internal class IronDuck:Duck
    {
        private IFly _flyType = new CantFly();
        private ISwim _swimType = new CantSwim();
        private IQuack _quackType=new CantQuack();
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
