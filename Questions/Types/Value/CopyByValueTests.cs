using System;
using Xunit;
using Xunit.Abstractions;

namespace Questions.Types.Value
{
    public class CopyByValueTests
    {
        readonly ITestOutputHelper _output;
        public CopyByValueTests(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact]
        public void Value()
        {
            var s = new S(_output);
            using (s)
            {
                _output.WriteLine(s.GetDispose().ToString());
            }
            _output.WriteLine(s.GetDispose().ToString());
            Assert.Equal(s.GetDispose(), false);
        }


        public struct S : IDisposable
        {
            private bool _dispose;
            readonly ITestOutputHelper _output;
            public S(ITestOutputHelper output)
            {
                _dispose = false;
                _output = output;
            }
            public void Dispose()
            {
                _dispose = true;
                _output.WriteLine("Disposed, value: " + _dispose.ToString());
            }

            public bool GetDispose()
            {
                return _dispose;
            }
        }
    }
}
