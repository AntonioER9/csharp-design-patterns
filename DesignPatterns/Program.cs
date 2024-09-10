using System;
using DesignPattern.StrategyPattern;
using DesignPatterns.SingletonPattern;

namespace DesignPatterns
{

  class Program
  {
    static void Main(string[] args)
    {
      var context = new Context(new CarStrategy());
      context.Run();
      context.Strategy = new BicycleStrategy();
      context.Run();
    }
  }
}