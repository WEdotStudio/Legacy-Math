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
    public sealed partial class LineEquaIn2Unk : Page
    {
        public LineEquaIn2Unk()
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
            if (a1.Text == "" || b1.Text == "" || c1.Text == "" || a2.Text == "" || b2.Text == "" || c2.Text == "")
            {
                MessageDialog messageDialog = new MessageDialog(loader.GetString("NoneInErr"));
                await messageDialog.ShowAsync();
                return;
            }
            if (Answer.Visibility == Visibility.Visible)
            {
                Answer.Visibility = Visibility.Collapsed;
                x_minus.Visibility = Visibility.Collapsed;
                x_numer.Visibility = Visibility.Visible;
                x_line.Visibility = Visibility.Visible;
                x_doni.Visibility = Visibility.Visible;
                y_minus.Visibility = Visibility.Collapsed;
                y_numer.Visibility = Visibility.Visible;
                y_line.Visibility = Visibility.Visible;
                y_doni.Visibility = Visibility.Visible; 
            }
            int[] equ=new int[4];
            equ = AppCore.linear.twounknown(Convert.ToInt32(a1.Text), Convert.ToInt32(b1.Text), Convert.ToInt32(c1.Text), Convert.ToInt32(a2.Text), Convert.ToInt32(b2.Text), Convert.ToInt32(c2.Text));
            //Analysis and calculation for the x part
            if (equ[0] < 0 && equ[1] < 0)
            {
                equ[0] = -equ[0];
                equ[1] = -equ[1];
            }
            else
            {
                if (equ[0] < 0)
                {
                    x_minus.Visibility = Visibility.Visible;
                    equ[0] = -equ[0];
                }
                if (equ[1] < 0)
                {
                    x_minus.Visibility = Visibility.Visible;
                    equ[1] = -equ[1];
                }
            }
            int[] f1 = new int[2] { equ[0], equ[1] };
            f1 = AppCore.NDS.FracSimp(f1);
            if (f1[1] == 1)
            {
                x_line.Visibility = Visibility.Collapsed;
                x_doni.Visibility = Visibility.Collapsed;
            }
            x_numer.Text = f1[0].ToString();
            x_doni.Text = f1[1].ToString();
            //Analysis and calculation for the x part
            if (equ[2] < 0 && equ[3] < 0)
            {
                equ[2] = -equ[2];
                equ[3] = -equ[3];
            }
            else
            {
                if (equ[2] < 0)
                {
                    y_minus.Visibility = Visibility.Visible;
                    equ[2] = -equ[2];
                }
                if (equ[3] < 0)
                {
                    y_minus.Visibility = Visibility.Visible;
                    equ[3] = -equ[3];
                }
            }
            int[] f2 = new int[2] { equ[2], equ[3] };
            f2 = AppCore.NDS.FracSimp(f2);
            if (f2[1] == 1)
            {
                y_line.Visibility = Visibility.Collapsed;
                y_doni.Visibility = Visibility.Collapsed;
            }
            y_numer.Text = f2[0].ToString();
            y_doni.Text = f2[1].ToString();
            //Show Answer
            Answer.Visibility = Visibility.Visible; 
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage)); 
        }
    }
}
