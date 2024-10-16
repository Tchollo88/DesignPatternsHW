using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_DesignPatternHomework
{
    public class Topping : IngerdientDecorator
    {
        public Topping(decimal cost, string name, IngerdientDecorator obj) : base(cost, name, obj) 
        { }
    }
}
