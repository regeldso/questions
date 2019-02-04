using System;
using Questions.Inheritance.BreackingLSP;
using Xunit;
using Xunit.Abstractions;

namespace Questions
{
    public class BreackingLSPTests
    {
        ITestOutputHelper _output;

        public BreackingLSPTests(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact]
        public void QuackTest()
        {
            var mallard = new Mallard();
            var darkwingDuck = new DarkwingDuck();
            var toy = new DarkwingDuckToy();

            Assert.Equal(mallard.Quack(), Quack(mallard));
            Assert.Equal(darkwingDuck.Quack(), Quack(darkwingDuck));
            Assert.Throws<Exception>(() => toy.Quack());
            toy.InsertBatteries();
            Assert.Equal(toy.Quack(), Quack(toy));
        }

        private string Quack(Duck duck)
        {
            _output.WriteLine(duck.Quack());
            return duck.Quack();
        }
    }
}
