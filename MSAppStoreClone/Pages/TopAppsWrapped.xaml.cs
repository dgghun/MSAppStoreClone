using MSAppStoreClone.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MSAppStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for TopAppsWrapped.xaml
    /// </summary>
    public partial class TopAppsWrapped : Page
    {
        public delegate void OnAppClicked(AnAppUC sender, RoutedEventArgs e);
        public event OnAppClicked AnAppClicked;

        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public TopAppsWrapped()
        {
            InitializeComponent();

            createSomeApps(20);
        }

        private void createSomeApps(int appCount)
        {
            for (int i = 0; i < appCount; i++)
            {
                AnAppUC currAnApp = new AnAppUC();
                currAnApp.AppClicked += CurrAnApp_AppClicked;
                TopAppsWrappedPageMainWrapPanel.Children.Add(currAnApp);
            }
        }

        private void CurrAnApp_AppClicked(AnAppUC sender, RoutedEventArgs e)
        {
            AnAppClicked(sender, e);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }

        private void TopAppsWrappedPageMainSV_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if(e.VerticalChange > 0)
            {
                int adjustment = 400;
                if(e.VerticalOffset + e.ViewportHeight + adjustment >= e.ExtentHeight)
                {
                    createSomeApps(6);
                }
            }
        }
    }
}
