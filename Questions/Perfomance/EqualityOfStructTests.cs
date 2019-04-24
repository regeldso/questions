using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Questions.Perfomance
{
    public class EqualityOfStructTests
    {
        private readonly IEnumerable<Guid> _guids = Enumerable.Range(0, 10000000).Select(x => Guid.NewGuid());
        private readonly ITestOutputHelper _output;

        public EqualityOfStructTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void EqualsOperator_TenTimes_ElapsedTime()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var j = 0;
            for (int i = 0; i < 100; i++)
            {
                foreach (var guid in _guids)
                {
                    if (guid == Guid.Empty)
                        j++;
                }
            }
            watch.Stop();
            _output.WriteLine(watch.Elapsed.ToString());
            _output.WriteLine(j.ToString());
            Assert.True(true);
        }


        [Fact]
        public void EqualsMethod_TenTimes_ElapsedTime()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var j = 0;
            for (int i = 0; i < 100; i++)
            {

                foreach (var guid in _guids)
                {
                    if (guid.Equals(Guid.Empty))
                        j++;
                }
            }
            watch.Stop();
            _output.WriteLine(watch.Elapsed.ToString());
            _output.WriteLine(j.ToString());
            Assert.True(true);
        }

    }
}
