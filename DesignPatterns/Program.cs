using System;
using DesignPattern.StrategyPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.SingletonPattern;

namespace DesignPatterns
{

  class Program
  {
    static void Main(string[] args)
    {
      var builder = new PreparedAlcoholicDrinkConcreteBuilder();
      var director = new Director(builder);

      director.PrepareVodka();
      var preparedDrink = builder.GetPreparedDrink();
      Console.WriteLine(preparedDrink.Result);
    }
  }
}