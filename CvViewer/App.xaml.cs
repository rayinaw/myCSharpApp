using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using appCV.Views;

namespace appCV
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var validationForm = new ValidationForm();
            validationForm.Show();
            validationForm.IsVisibleChanged += (s, ev) =>
            {
                if (validationForm.IsVisible == false && validationForm.IsLoaded)
                {
                    var cvView = new CvView();
                    cvView.Show();
                    validationForm.Close();
                }
            };
        }
    }
}
