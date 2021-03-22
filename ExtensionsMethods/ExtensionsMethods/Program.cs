using System;

namespace ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 03, 22, 8, 36, 40);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
