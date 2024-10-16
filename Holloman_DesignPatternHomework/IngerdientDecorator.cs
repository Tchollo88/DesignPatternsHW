using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_DesignPatternHomework
{
    public class IngerdientDecorator : IIngerdient
    {
        private IngerdientDecorator _reference { get; set; }
        public decimal Cost {  get; set; }
        public string Name {  get; set; }

        public IngerdientDecorator(decimal cost, string name, IngerdientDecorator obj)
        {
            _reference = obj;
            Cost = cost;
            Name = name;
        }

        public decimal CalaculateCost()
        {
            if (_reference == null)
            {
                return Cost;
            }
            return Cost + _reference.CalaculateCost();
            //return Cost + ((IIngerdient)_reference).CalaculateCost();
        }
    }
}
