using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб6
{
    public class ToDuckAdapter:Duck
    {
        private Goose _goose;

        public ToDuckAdapter(Goose goose)
        {
            _goose = goose;
        }

        public override void Quack()
        {
            _goose.Cackling();
        }

        public override void Fly()
        {
            _goose.Fly();
        }
    }
}
