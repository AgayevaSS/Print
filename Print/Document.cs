using System;

namespace Print
{
    internal partial class Program
    {
        class Document : IPrintable
        {
            public void Print()
            {
                Console.WriteLine("document");
            }
        }
    }
}
