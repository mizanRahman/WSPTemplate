using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using ClassLibrary1;


namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        private Class1 appLibMain;
        public Service1()
        {
            InitializeComponent();
            appLibMain = new Class1();
        }

        protected override void OnStart(string[] args)
        {
            appLibMain.Start(args);
        }

        protected override void OnStop()
        {
            appLibMain.Stop();
        }
    }
}
