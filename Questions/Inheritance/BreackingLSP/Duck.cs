using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Inheritance.BreackingLSP
{
    public abstract class Duck
    {
        public virtual string Quack()
        {
            return "Quack";
        }
    }
}
