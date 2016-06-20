using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Math
{
    public sealed partial class edua : Page
    {
        
        public edua()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        #region Animation
        int basic = 0;
        int geom = 0;
        int cgy = 0;
        int trn = 0;
        int cun = 0;
        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
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
        private void Grid_Tapped_1(object sender, TappedRoutedEventArgs e)
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
        private void Grid_Tapped_2(object sender, TappedRoutedEventArgs e)
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
        private void Grid_Tapped_3(object sender, TappedRoutedEventArgs e)
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
        private void Grid_Tapped_4(object sender, TappedRoutedEventArgs e)
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
            this.Frame.Navigate(typeof(EduaViewer), "power");
        }
        private void Rad(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "rad");
        }
        private void log(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "log");
        }
        private void qe(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "qe");
        }
        private void poly(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "poly");
        }
        private void squ(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "squ");
        }
        private void cn(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "cn");
        }
        private void vtr(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "vtr");
        }
        private void prob(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "prob");
        }
        #endregion

        #region Geometry
        private void Aa(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "aa");
        }
        private void pmtr(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "pmtr");
        }
        private void Sa(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "sa");
        }
        private void vm(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "vm");
        }
        private void la(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "la");
        }
        #endregion

        #region Coordinate Geometry
        private void cgbc(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "cgbc");
        }
        private void cc(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "cc");
        }
        private void ese(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "ese");
        }
        private void prbl(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "prbl");
        }
        private void hpbl(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "hpbl");
        }
        #endregion

        #region Trigonometry
        private void tb(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "tb");
        }
        private void ghs(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "ghs");
        }
        private void dtf(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "dtf");
        }
        private void lot(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "lot");
        }
        private void it(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "it");
        }
        private void hbc(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "hbc");
        }
        #endregion

        #region Caculus
        private void lmt(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "lmt");
        }
        private void dvt(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "dvt");
        }
        private void itg(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "itg");
        }
        private void lpe(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "lpe");
        }
        private void id(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "id");
        }
        #endregion

        private void Mat(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EduaViewer), "mat");
        }
        #endregion

    }
}
