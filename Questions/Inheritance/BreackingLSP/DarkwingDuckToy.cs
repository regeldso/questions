using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Inheritance.BreackingLSP
{
    public class DarkwingDuckToy : DarkwingDuck
    {
        private bool _isBatteryInserted = false;
        public void InsertBatteries() => _isBatteryInserted = true;
        // breaking inheritance chain
        public new string Quack()
        {
            if (!_isBatteryInserted)
                throw new Exception("You probably have the wrong abstraction");

            return base.Quack();
        }
    }
}
