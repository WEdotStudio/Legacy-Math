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
    public sealed partial class fs : Page
    {
        public fs()
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
            if (up.Text == "" || down.Text == "" )
            {   MessageDialog messageDialog = new MessageDialog(loader.GetString("NoneInErr"));
                await messageDialog.ShowAsync();
                return;
            }
            if (down.Text == "0")
            {
                MessageDialog messageDialog = new MessageDialog(loader.GetString("DenoErr"));
                await messageDialog.ShowAsync();
                return;
            }
            if (Answer.Visibility == Visibility.Visible)
            {
                Answer.Visibility = Visibility.Collapsed;
                minus.Visibility = Visibility.Collapsed; 
                doni.Visibility = Visibility.Visible;
                line.Visibility = Visibility.Visible;
            }
            int[] a=new int[2];
            a[0] = Convert.ToInt32(up.Text);
            a[1] = Convert.ToInt32(down.Text);
            if (a[0] < 0 && a[1] < 0)
            {
                
                a[0] = -a[0];
                a[1] = -a[1];
            }
            else
            {
                if (a[0] < 0)
                { 
                    minus.Visibility = Visibility.Visible;
                    a[0] = -a[0];
                }
                if (a[1] < 0)
                {
                    minus.Visibility = Visibility.Visible;
                    a[1] = -a[1];
                }
            }
            a = AppCore.NDS.FracSimp(a);
            if(a[1]==1)
            {
                line.Visibility = Visibility.Collapsed;
                doni.Visibility = Visibility.Collapsed; 
            }
            numer.Text = a[0].ToString();
            doni.Text = a[1].ToString();
            Answer.Visibility = Visibility.Visible; 
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage)); 
        }
    }
}
