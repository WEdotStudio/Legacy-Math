using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Math
{

    public sealed partial class Debug : Page
    {
        public Debug()
        {
            this.InitializeComponent();
            this.Loaded += Loader;
        }

        void Loader(object sender, RoutedEventArgs e)
        {
            string region = Windows.System.UserProfile.GlobalizationPreferences.HomeGeographicRegion;
            string currentLanguage;
            ResourceManager.Current.DefaultContext.QualifierValues.TryGetValue("Language", out currentLanguage);
            CL.Text = currentLanguage;
            CHL.Text = region;

        }


        private void link_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (ww.Visibility == Visibility.Visible)
            {
                ww.Visibility = Visibility.Collapsed;  
            }
            if (e.Key==Windows.System.VirtualKey.Enter)
            {
                string rooter = "ms-appx-web:///FormulaCorePages/" + link.Text;
                ww.Navigate(new Uri(rooter,UriKind.Absolute));
                ww.Visibility = Visibility.Visible; 
            }
        }

        
    }
}
