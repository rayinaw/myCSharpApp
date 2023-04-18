using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ToolKit.Views;

namespace ToolKit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            dashboard.IsVisibleChanged += (s, ev) =>
            {
                if (dashboard.IsVisible == false && dashboard.IsLoaded)
                {
                    dashboard.Close();
                }
                if (dashboard.IsVisible == true && dashboard.IsLoaded)
                {
                    dashboard.Close();
                }
            };
        }
    }
}
