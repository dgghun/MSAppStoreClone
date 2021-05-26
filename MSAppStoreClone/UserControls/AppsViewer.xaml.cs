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
            for(int i = 0; i < 30; i++)
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
            int withOfOneApp = (int)PresentedApps.First().ActualWidth 
                + 2 * (int)PresentedApps.First().Margin.Left;
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset - 1 * withOfOneApp);
        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            int withOfOneApp = (int)PresentedApps.First().ActualWidth
                + 2 * (int)PresentedApps.First().Margin.Left;
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 1 * withOfOneApp);
        }

        private void AppsScrollView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            //Fix scrolling but when mouse is over Apps viewer. That is,...
            //the screen will not scroll up or down if mouse is hovering
            //over the apps so this will fix that. Send event AppsViewer to parent ScrollViewer
            e.Handled = true;
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            eventArg.Source = sender;
            var parent = ((Control)sender).Parent as UIElement;
            parent.RaiseEvent(eventArg);
        }
    }
}
