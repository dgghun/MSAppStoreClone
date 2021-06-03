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

namespace MSAppStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : UserControl
    {
        public delegate void OnAppDetailsAppClicked(AnAppUC sender, RoutedEventArgs e);
        public event OnAppDetailsAppClicked AppClicked;

        public Overview()
        {
            InitializeComponent();
            AppsViewerinsideOverviewTab.AppClicked += AppsViewerInsideOverviewTab_AnAppClicked;
        }

        private void AppsViewerInsideOverviewTab_AnAppClicked(AnAppUC sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
    }
}
