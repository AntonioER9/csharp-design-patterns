using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class NotDebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                Console.WriteLine($"Se le descuenta {amount} de su saldo");
                customerContext.Discount(amount);
                if (customerContext.Residue <= 0)
                {
                    customerContext.SetState(new DebtorState());
                }
            }
            else
            {
                Console.WriteLine("No se puede descontar más de lo que tiene");
            }
        }
    }
}