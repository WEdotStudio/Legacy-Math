using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ss : Page
    {
        public ss()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private async void Solve(object sender, RoutedEventArgs e)
        {
            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();
            if (nis.Text == "")
            {
                MessageDialog messageDialog = new MessageDialog(loader.GetString("NoneInErr"));
                await messageDialog.ShowAsync();
                return;
            } if (nis.Text == "0")
            {
                MessageDialog messageDialog = new MessageDialog(loader.GetString("ZeroErr"));
                await messageDialog.ShowAsync();
                return;
            }
            if (Answer.Visibility == Visibility.Visible)
            {
                Answer.Visibility = Visibility.Collapsed;
                coe.Visibility = Visibility.Visible;
                surd1.Visibility = Visibility.Visible;
                surd2.Visibility = Visibility.Visible; 
            }
            int x;
            int[] p = new int[2];
            x = Convert.ToInt32(nis.Text);
            p = AppCore.NDS.SimpSurd(x);
            if (p[1] == 1)
            {
                surd1.Visibility = Visibility.Collapsed;
                surd2.Visibility = Visibility.Collapsed; 
            }
            coe.Text = p[0].ToString();
            numinsurd.Text = p[1].ToString();
            Answer.Visibility = Visibility.Visible; 
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage)); 
        }
    }
}
