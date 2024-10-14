using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_DesignPatternHomework
{
    public class Scoop : IngerdientDecorator
    {
        public string OrderName { get; set; }
        public Scoop(double cost, string name, IngerdientDecorator obj, string order) : base(cost, name, null)
        {
            OrderName = order;
        }
    }
}
