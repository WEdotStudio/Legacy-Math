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
    public sealed partial class LineEquaIn3Unk : Page
    {
        public LineEquaIn3Unk()
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

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Solve(object sender, RoutedEventArgs e)
        {
            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();
            if (a1.Text == "" || b1.Text == "" || c1.Text == "" || d1.Text == "" ||a2.Text == "" || b2.Text == "" || c2.Text == "" || d2.Text == "" ||a3.Text == "" || b3.Text == "" || c3.Text == "" || d3.Text == "" )
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
                z_minus.Visibility = Visibility.Collapsed;
                z_numer.Visibility = Visibility.Visible;
                z_line.Visibility = Visibility.Visible;
                z_doni.Visibility = Visibility.Visible;
            }
            double[] equ = new double[3];
            int[] x = new int[2];
            int[] y = new int[2];
            int[] z = new int[2];
            equ = AppCore.linear.threeunknown(Convert.ToInt32(a1.Text), Convert.ToInt32(b1.Text), Convert.ToInt32(c1.Text), Convert.ToInt32(d1.Text), Convert.ToInt32(a2.Text), Convert.ToInt32(b2.Text), Convert.ToInt32(c2.Text), Convert.ToInt32(d2.Text), Convert.ToInt32(a3.Text), Convert.ToInt32(b3.Text), Convert.ToInt32(c3.Text), Convert.ToInt32(d3.Text));
            x = AppCore.NDS.FracSimp(equ[0]);
            y = AppCore.NDS.FracSimp(equ[1]);
            z = AppCore.NDS.FracSimp(equ[2]);
            //Analysis and calculation for the x part
            if (x[0] < 0 && x[1] < 0)
            {
                x[0] = -x[0];
                x[1] = -x[1];
            }
            else
            {
                if (x[0] < 0)
                {
                    x_minus.Visibility = Visibility.Visible;
                    x[0] = -x[0];
                }
                if (x[1] < 0)
                {
                    x_minus.Visibility = Visibility.Visible;
                    x[1] = -x[1];
                }
            }
            int[] f1 = new int[2] { x[0], x[1] };
            f1 = AppCore.NDS.FracSimp(f1);
            if (f1[1] == 1)
            {
                x_line.Visibility = Visibility.Collapsed;
                x_doni.Visibility = Visibility.Collapsed;
            }
            x_numer.Text = f1[0].ToString();
            x_doni.Text = f1[1].ToString();
            //Analysis and calculation for the y part
            if (y[0] < 0 && y[1] < 0)
            {
                y[0] = -y[0];
                y[1] = -y[1];
            }
            else
            {
                if (y[0] < 0)
                {
                    y_minus.Visibility = Visibility.Visible;
                    y[0] = -y[0];
                }
                if (y[1] < 0)
                {
                    y_minus.Visibility = Visibility.Visible;
                    y[1] = -y[1];
                }
            }
            int[] f2 = new int[2] { y[0], y[1] };
            f2 = AppCore.NDS.FracSimp(f2);
            if (f2[1] == 1)
            {
                y_line.Visibility = Visibility.Collapsed;
                y_doni.Visibility = Visibility.Collapsed;
            }
            y_numer.Text = f2[0].ToString();
            y_doni.Text = f2[1].ToString();
            //Analysis and calculation for the z part
            if (z[0] < 0 && z[1] < 0)
            {
                z[0] = -z[0];
                z[1] = -z[1];
            }
            else
            {
                if (z[0] < 0)
                {
                    z_minus.Visibility = Visibility.Visible;
                    z[0] = -z[0];
                }
                if (z[1] < 0)
                {
                    z_minus.Visibility = Visibility.Visible;
                    z[1] = -z[1];
                }
            }
            int[] f3 = new int[2] { z[0], z[1] };
            f3 = AppCore.NDS.FracSimp(f3);
            if (f3[1] == 1)
            {
                z_line.Visibility = Visibility.Collapsed;
                z_doni.Visibility = Visibility.Collapsed;
            }
            z_numer.Text = f3[0].ToString();
            z_doni.Text = f3[1].ToString();
            //Show answer
            Answer.Visibility = Visibility.Visible; 
        }
    }
}
