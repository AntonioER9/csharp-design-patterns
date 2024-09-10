using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public interface IBuilder
    {
        public void Reset();
        public void SetAlcohol(decimal alcohol);
        public void SetMilk(int milk);
        public void SetWater(int water);
        public void AddIngredient(string ingredient);
        public void Mix();
        public void Rest(int time);
    }
}