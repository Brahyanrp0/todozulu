using System;
using System.Collections.Generic;
using System.Text;

namespace todozulu.tests.Helpers
{
    class NullScope : IDisposable
    {

        public static NullScope Instance { get; set; } = new NullScope();
        public void Dispose(){}
        private NullScope(){ }







    }
}
