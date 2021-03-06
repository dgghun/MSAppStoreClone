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
    /// Interaction logic for AppDetailsAndBackground.xaml
    /// </summary>
    public partial class AppDetailsAndBackground : UserControl
    {
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public AppDetailsAndBackground()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }
    }
}
