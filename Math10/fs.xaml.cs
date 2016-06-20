using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Math10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class fs : Page
    {
        public fs()
        {
            this.InitializeComponent();
            var applicationView = ApplicationView.GetForCurrentView();
            var titleBar = applicationView.TitleBar;
            titleBar.ButtonInactiveBackgroundColor = Colors.DarkGreen;
            titleBar.ButtonInactiveForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = Colors.DarkGreen;
            titleBar.ButtonForegroundColor = Colors.White;
            titleBar.BackgroundColor = Colors.DarkGreen;
            titleBar.ForegroundColor = Colors.White;
            titleBar.InactiveBackgroundColor = Colors.DarkGreen;
            titleBar.InactiveForegroundColor = Colors.White;
            Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = false;

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

            //Hook up back buttons - Do this just once - ie on app launched
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) =>
            {
                if (Frame.CanGoBack)
                    Frame.GoBack();
            };
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                //Also use hardware back button
                Windows.Phone.UI.Input.HardwareButtons.BackPressed += (s, e) =>
                {
                    if (Frame.CanGoBack)
                    {
                        e.Handled = true;
                        Frame.GoBack();
                    }
                };
            }
        }
        private async void Solve(object sender, RoutedEventArgs e)
        {
            if (up.Text == "" || down.Text == "")
            {
                MessageDialog messageDialog = new MessageDialog("您未有输入任何值！");
                await messageDialog.ShowAsync();
                return;
            }
            if (down.Text == "0")
            {
                MessageDialog messageDialog = new MessageDialog("分母不得为零！");
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
            int[] a = new int[2];
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
            a = CoreCalc.NDS.FracSimp(a);
            if (a[1] == 1)
            {
                line.Visibility = Visibility.Collapsed;
                doni.Visibility = Visibility.Collapsed;
            }
            numer.Text = a[0].ToString();
            doni.Text = a[1].ToString();
            Answer.Visibility = Visibility.Visible;
        }
    }
}
