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

namespace MSAppStoreClone.UserControls
{

    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        List<AnAppUC> PresentedApps;

        public AppsViewer()
        {
            InitializeComponent();
            PresentedApps = new List<AnAppUC>();
            AppsList.ItemsSource = PresentedApps;
            for(int i = 0; i < 9; i++)
            {
                AnAppUC curr = new AnAppUC();
                PresentedApps.Add(curr);
            }
        }

        //..................................................................
        // EVENTS
        //..................................................................
        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
