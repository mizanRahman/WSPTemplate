using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 applib = new Class1();
            applib.Start(new String[] { "" });
            applib.Stop();
        }
    }
}
