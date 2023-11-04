using System;

namespace Singleton
{
    public class ConsoleWrite : IResult
    {
        public void WriteLine(string aValue) 
        {
            Console.WriteLine(aValue);
        }

        public void ReadKey()
        {
            Console.ReadKey();
        }
    }
}
