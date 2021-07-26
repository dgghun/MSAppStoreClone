using MahApps.Metro.Controls;
using MSAppStoreClone.Pages;
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

namespace MSAppStoreClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private Main MainWindowContentPage;
        private TopAppsWrapped MyTopAppsWrappedPage;
        private DownloadsAndUpdates DownloadsAndUpdatesPage;

        public MainWindow()
        {
            InitializeComponent();
            MainWindowContentPage = new Main();
            MainWindowContentPage.AppClicked += MainWindowContentPage_AppClicked;

            MainWindowContentPage.TopAppButtonClicked += MainWindowContentPage_TopAppButtonClicked;
            MainWindowContentPage.DownloadsAndUpdatesClicked += MainWindowContentPage_DownloadsAndUpdatesClicked;

            MyTopAppsWrappedPage = new TopAppsWrapped();
            MyTopAppsWrappedPage.AnAppClicked += MainWindowContentPage_AppClicked;
            MyTopAppsWrappedPage.BackButtonClicked += MyAppDetails_BackButtonClicked;
            DownloadsAndUpdatesPage = new DownloadsAndUpdates();
            DownloadsAndUpdatesPage.BackButtonClicked += MyAppDetails_BackButtonClicked;
        }

        private void MainWindowContentPage_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MyTopAppsWrappedPage;
        }

        private void MainWindowContentPage_DownloadsAndUpdatesClicked()
        {
            MainWindowFrame.Content = DownloadsAndUpdatesPage;
        }

        private void MainWindowContentPage_AppClicked(AnAppUC sender, RoutedEventArgs e)
        {
            AppDetails myAppDetails = new AppDetails(sender);
            myAppDetails.BackButtonClicked += MyAppDetails_BackButtonClicked;
            myAppDetails.AppClicked += MainWindowContentPage_AppClicked;
            MainWindowFrame.Content = myAppDetails;

        }


        private void MyAppDetails_BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
            //AppDetails myAppDetails = new AppDetails();
            MainWindowFrame.Content = MainWindowContentPage;
        }
    }
}
