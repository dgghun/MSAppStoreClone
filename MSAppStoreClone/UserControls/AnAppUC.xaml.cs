using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AnAppUC.xaml
    /// </summary>
    public partial class AnAppUC : UserControl
    {
        public string AppName;
        public ImageSource AppImageSource; 

        public AnAppUC()
        {
            InitializeComponent();

            List<string> filepaths = Directory.GetFiles(Environment.CurrentDirectory
                + @"\..\..\Images", "*.png").ToList<string>();  //Get list of icon image paths

            FileInfo myRandomFile = new FileInfo(filepaths[StaticRandom.Next(filepaths.Count)]);
            
            //Set "ProductImage" image and name random image
            ProductImage.Source = new BitmapImage(new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));
            AppNameText.Text = (new CultureInfo("en-us", false).TextInfo)
                .ToTitleCase(myRandomFile.FullName.Split('\\').Last()
                .Split('-').Last().Split('.').First());

            AppName = AppNameText.Text.ToString();
            AppImageSource = ProductImage.Source;

        }

        //......................................................................
        // EVENTS
        //......................................................................
        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
