using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class DebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            Console.WriteLine("No se puede descontar más de lo que tiene");
        }
    }
}