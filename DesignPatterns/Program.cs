using System;
using DesignPatterns.StatePattern;

namespace DesignPatterns
{

  class Program
  {
    static void Main(string[] args)
    {
      var customerContext = new CustomerContext();
      Console.WriteLine(customerContext.GetState());
      customerContext.Request(100);
      Console.WriteLine(customerContext.GetState());
      customerContext.Request(50);
      Console.WriteLine(customerContext.GetState());
      customerContext.Request(50);
      Console.WriteLine(customerContext.GetState());
      customerContext.Request(50);
      Console.WriteLine(customerContext.GetState());

    }
  }
}