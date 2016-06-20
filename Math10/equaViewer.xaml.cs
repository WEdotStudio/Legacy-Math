using System;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Math10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class equaViewer : Page
    {
        string x;
        public equaViewer()
        {
            this.InitializeComponent();
            var applicationView = ApplicationView.GetForCurrentView();
            applicationView.Title = "公式";
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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();
            string region = Windows.System.UserProfile.GlobalizationPreferences.HomeGeographicRegion;
            x = "ms-appx-web:///FormulaCorePages/Chi/";
            //switch (region)
           // {
             //   case "US":
               //     x += "Eng/";
                 //   break;
            //    case "CN":
              //      x += "Chi/";
                //    break;
              //  case "TW":
                //    x += "TraChi/";
                 //   break;
                //case "HK":
                  //  x += "TraChi/";
               //     break;
               // default:
                 //   x += "Eng/";
                   // break;
            //}
            string c = e.Parameter.ToString();
            switch (c)
            {
                //Basic
                case "power":
                    x += "Basic/power.html";
                    Title.Text = "乘幂";
                        //loader.GetString("Pwrt");
                    break;
                case "rad":
                    x += "Basic/rad.html";
                    Title.Text = "根数";//loader.GetString("Radt");
                    break;
                case "log":
                    x += "Basic/log.html";
                    Title.Text = "对数";
                        //loader.GetString("Logt");
                    break;
                case "qe":
                    x += "Basic/qe.html";
                    Title.Text = "二次方程式";//loader.GetString("Qet");
                    break;
                case "poly":
                    x += "Basic/poly.html";
                    Title.Text = "多项式";//loader.GetString("Polst");
                    break;
                case "squ":
                    x += "Basic/squ.html";
                    Title.Text = "数列";//loader.GetString("Squt");
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
                    Title.Text = "等等等等一下。。。。你是怎么到这儿的？";
                    break;
            }
            webV.Navigate(new Uri(x));
        }
    }
}
