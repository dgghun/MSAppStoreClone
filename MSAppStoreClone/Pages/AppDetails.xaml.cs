﻿using System;
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
using MSAppStoreClone.UserControls;

namespace MSAppStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for AppDetails.xaml
    /// </summary>
    public partial class AppDetails : Page
    {
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public AppDetails(AnAppUC anApp)
        {
            InitializeComponent();

            AppDetailsAndBackgroundUC.AppNameLabel.Content = anApp.AppName;
            AppDetailsAndBackgroundUC.AppImage.Source= anApp.AppImageSource;
            AppDetailsAndBackgroundUC.BackButtonClicked += AppDetailsAndBackgroundUC_BackButtonClicked;
        }


        private void AppDetailsAndBackgroundUC_BackButtonClicked(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }
    }
}
