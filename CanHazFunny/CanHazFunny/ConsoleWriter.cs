using System;

namespace CanHazFunny
{
    public class ConsoleWriter : IOutputWriter
    {
        public void Write(string format)
        {
            Console.WriteLine(format);
        }
    }
}