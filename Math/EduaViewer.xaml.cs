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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EduaViewer : Page
    {
        string x;
        public EduaViewer()
        {
            this.InitializeComponent();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();
            string region = Windows.System.UserProfile.GlobalizationPreferences.HomeGeographicRegion;
            x = "ms-appx-web:///FormulaCorePages/";
            switch (region)
            {
                case "US":
                    x += "Eng/";
                    break;
                case "CN":
                    x += "Chi/";
                    break;
                case "TW":
                    x += "TraChi/";
                    break;
                case "HK":
                    x += "TraChi/";
                    break;
                default:
                    x += "Eng/";
                    break;
            }
            string c = e.Parameter.ToString();
            switch(c)
            {
                //Basic
                case "power":
                    x += "Basic/power.html";
                    Title.Text = loader.GetString("Pwrt");
                    break;
                case "rad":
                    x += "Basic/rad.html";
                    Title.Text = loader.GetString("Radt");
                    break;
                case "log":
                    x += "Basic/log.html";
                    Title.Text = loader.GetString("Logt");
                    break;
                case "qe":
                    x += "Basic/qe.html";
                    Title.Text = loader.GetString("Qet");
                   break;
                case "poly":
                   x += "Basic/poly.html";
                   Title.Text = loader.GetString("Polst");
                    break;
                case "squ":
                    x += "Basic/squ.html";
                    Title.Text = loader.GetString("Squt");
                   break;
                case "cn":
                   x += "Basic/cn.html";
                   Title.Text = loader.GetString("Cnt");
                    break;
                case "vtr":
                    x += "Basic/vtr.html";
                    Title.Text = loader.GetString("Vtt");
                    break;
                case "prob":
                    x += "Basic/prob.html";
                    Title.Text = loader.GetString("Ppt");
                    break;
                //Geometry
                case "aa":
                    x += "Geo/aa.html";
                    Title.Text = loader.GetString("Aat");
                    break;
                case "la":
                    x += "Geo/la.html";
                    Title.Text = loader.GetString("Lat");
                    break;
                case "pmtr":
                    x += "Geo/pmtr.html";
                    Title.Text = loader.GetString("Pmtrt");
                    break;
                case "sa":
                    x += "Geo/sa.html";
                    Title.Text = loader.GetString("Sat");
                    break;
                case "vm":
                    x += "Geo/vm.html";
                    Title.Text = loader.GetString("Vmt");
                    break;
                //Coordinate Geometry
                case "cc":
                    x += "CG/cc.html";
                    Title.Text = loader.GetString("Cct");
                    break;
                case "cgbc":
                    x += "CG/cgbc.html";
                    Title.Text = loader.GetString("CGbct");
                    break;
                case "ese":
                    x += "CG/ese.html";
                    Title.Text = loader.GetString("Eset");
                    break;
                case "hpbl":
                    x += "CG/hpbl.html";
                    Title.Text = loader.GetString("Hpblt");
                    break;
                case "prbl":
                    x += "CG/prbl.html";
                    Title.Text = loader.GetString("Prblt");
                    break;
                //Trigonometry
                case "dtf":
                    x += "Tri/dtf.html";
                    Title.Text = loader.GetString("Dtft");
                    break;
                case "ghs":
                    x += "Tri/ghs.html";
                    Title.Text = loader.GetString("Ghst");
                    break;
                case "hbc":
                    x += "Tri/hbc.html";
                    Title.Text = loader.GetString("Hbct");
                    break;
                case "it":
                    x += "Tri/it.html";
                    Title.Text = loader.GetString("Itt");
                    break;
                case "lot":
                    x += "Tri/lot.html";
                    Title.Text = loader.GetString("Lott");
                    break;
                case "tb":
                    x += "Tri/tb.html";
                    Title.Text = loader.GetString("Tbt");
                    break;
                //Caculus
                case "dvt":
                    x += "Cacu/dvt.html";
                    Title.Text = loader.GetString("Dvtt");
                    break;
                case "id":
                    x += "Cacu/id.html";
                    Title.Text = loader.GetString("Idt");
                    break;
                case "itg":
                    x += "Cacu/itg.html";
                    Title.Text = loader.GetString("Itgt");
                    break;
                case "lmt":
                    x += "Cacu/lmt.html";
                    Title.Text = loader.GetString("Lmtt");
                    break;
                case "lpe":
                    x += "Cacu/lpe.html";
                    Title.Text = loader.GetString("Lpet");
                    break;
                //(The lonely) matrix
                case "mat":
                    x += "mat.html";
                    Title.Text = loader.GetString("Matt");
                    break;
                //Error
                default:
                    x += "Err.html";
                    Title.Text = "Wait...How do you get here?";
                    break;
            }
            webV.Navigate(new Uri(x)); 
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(edua)); 
        }

    }
}
