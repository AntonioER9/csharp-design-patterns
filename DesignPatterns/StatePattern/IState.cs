using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public interface IState
    {
        public void Action(CustomerContext customerContext, decimal amount);

    }
}