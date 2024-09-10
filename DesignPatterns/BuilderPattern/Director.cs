using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }
        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepareVodka()
        {
            _builder.Reset();
            _builder.AddIngredient("Vodka");
            _builder.SetAlcohol(40);
            _builder.Mix();
            _builder.Rest(1000);
        }

    }
}