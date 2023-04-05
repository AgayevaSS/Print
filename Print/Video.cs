using System;

namespace Print
{
    internal partial class Program
    {
        class Video : IPrintable
        {
            public void Print()
            {
                Console.WriteLine("video");
            }
        }
    }
}
