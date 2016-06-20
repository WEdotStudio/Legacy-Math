
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Math
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestMainPage : Page
    {
        public TestMainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void Hub_SectionHeaderClick(object sender, HubSectionHeaderClickEventArgs e)
        {
            StatusBar bar = StatusBar.GetForCurrentView();


            switch (e.Section.Name)
            {
                case "Main":
                    bar.BackgroundColor = Windows.UI.Colors.Peru;
                    bar.BackgroundOpacity = 1;
                    break;
                case "calc":
                    bar.BackgroundColor = Windows.UI.Colors.DarkGreen;
                    break;
                case "Formu":
                    bar.BackgroundColor = Windows.UI.Colors.DarkOrchid;
                    break;
                case "about":
                    bar.BackgroundColor = Windows.UI.Colors.DarkBlue;
                    break;
                default:
                    break;
            }
            await bar.ShowAsync();
        }
    }
}
