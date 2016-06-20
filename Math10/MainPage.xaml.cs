using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Math10
{
    public sealed partial class MainPage : Page
    {
        public static MainPage Current;

        public MainPage()
        {
            this.InitializeComponent();
            var applicationView = ApplicationView.GetForCurrentView();
            var titleBar = applicationView.TitleBar;
            titleBar.ButtonInactiveBackgroundColor = Colors.DarkGreen;
            titleBar.ButtonInactiveForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = Colors.DarkGreen;
            titleBar.ButtonForegroundColor = Colors.White;
            Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            Current = this;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }
       
        #region Animation
        int basic = 0;
        int geom = 0;
        int cgy = 0;
        int trn = 0;
        int cun = 0;
        private void Grid_Tapped_a(object sender, TappedRoutedEventArgs e)
        {
            if (basic == 1)
            {
                this.BasicClose.Begin();
                basic = 0;
            }
            else
            {
                this.BasicOpen.Begin();
                basic = 1;
            }
        }
        private void Grid_Tapped_b(object sender, TappedRoutedEventArgs e)
        {
            if (geom == 1)
            {
                this.GeoClose.Begin();
                geom = 0;
            }
            else
            {
                this.GeoOpen.Begin();
                geom = 1;
            }
        }
        private void Grid_Tapped_c(object sender, TappedRoutedEventArgs e)
        {
            if (cgy == 1)
            {
                this.CGClose.Begin();
                cgy = 0;
            }
            else
            {
                this.CGOpen.Begin();
                cgy = 1;
            }
        }
        private void Grid_Tapped_d(object sender, TappedRoutedEventArgs e)
        {
            if (trn == 1)
            {
                this.TriClose.Begin();
                trn = 0;
            }
            else
            {
                this.TriOpen.Begin();
                trn = 1;
            }
        }
        private void Grid_Tapped_e(object sender, TappedRoutedEventArgs e)
        {
            if (cun == 1)
            {
                this.CuClose.Begin();
                cun = 0;
            }
            else
            {
                this.CuOpen.Begin();
                cun = 1;
            }
        }
        #endregion
        #region Navgation
        #region Basic
        private void Pwr(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(equaViewer), "power");
        }
        private void Rad(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "rad");
        }
        private void log(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "log");
        }
        private void qe(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "qe");
        }
        private void poly(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "poly");
        }
        private void squ(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "squ");
        }
        private void cn(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "cn");
        }
        private void vtr(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "vtr");
        }
        private void prob(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "prob");
        }
        #endregion

        #region Geometry
        private void Aa(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "aa");
        }
        private void pmtr(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "pmtr");
        }
        private void Sa(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "sa");
        }
        private void vm(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "vm");
        }
        private void la(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "la");
        }
        #endregion

        #region Coordinate Geometry
        private void cgbc(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "cgbc");
        }
        private void cc(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "cc");
        }
        private void ese(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "ese");
        }
        private void prbl(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "prbl");
        }
        private void hpbl(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "hpbl");
        }
        #endregion

        #region Trigonometry
        private void tb(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "tb");
        }
        private void ghs(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "ghs");
        }
        private void dtf(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "dtf");
        }
        private void lot(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "lot");
        }
        private void it(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "it");
        }
        private void hbc(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "hbc");
        }
        #endregion

        #region Caculus
        private void lmt(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "lmt");
        }
        private void dvt(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "dvt");
        }
        private void itg(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "itg");
        }
        private void lpe(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "lpe");
        }
        private void id(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "id");
        }
        #endregion

        private void Mat(object sender, TappedRoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(equaViewer), "mat");
        }
        #endregion

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qeou));
        }

        private void ListViewItem_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(fs));
        }
    }
}

