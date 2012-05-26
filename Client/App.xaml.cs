using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            for (int i = 0; i < e.Args.Length; i++)
            {
                if (i == e.Args.Length - 1)
                    StartupFile = e.Args[i];
                else
                    UseSwitch(e.Args[i]);
            }
        }

        private void UseSwitch(string p)
        {
            throw new NotImplementedException();
        }

        internal string StartupFile { get; private set; }
    }
}
