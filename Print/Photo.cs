using System;

namespace Print
{
    internal partial class Program
    {
        class Photo : IPrintable
        {
            public void Print()
            {
                Console.WriteLine("photo");
            }
        }
    }
}
