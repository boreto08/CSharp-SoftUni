

namespace StorageMaster.Core.IO
{
    using System;
    using Contracts;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
