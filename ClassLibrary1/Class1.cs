using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Start(string[] args)
        {
            Console.WriteLine("Started");
            EventLog.WriteEntry("Demo", "Test Start");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
            EventLog.WriteEntry("Demo", "Test Stop");

        }
    }
}
