using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_DesignPatternHomework
{
    public class IngerdientDecorator
    {
        private IngerdientDecorator _reference { get; set; }
        public double Cost {  get; set; }
        public string Name {  get; set; }

        public IngerdientDecorator(double cost, string name, IngerdientDecorator obj)
        {
            _reference = obj;
            Cost = cost;
            Name = name;
        }

        public double CalculateCost()
        {
            if (_reference == null)
            {
                return Cost;
            }
            return Cost + _reference.CalculateCost;
        }
    }
}
