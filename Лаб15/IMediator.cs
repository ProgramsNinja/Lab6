using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб15
{
    internal interface IMediator
    {
        public void Execute(IRequest request);
    }
}
