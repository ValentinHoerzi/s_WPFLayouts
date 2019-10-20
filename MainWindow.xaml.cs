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

namespace WPFLayouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeToolBar();
            InitializeToolBox();

        }

        private void InitializeToolBox()
        {
            //Do same with toolbar
        }
        

        private void InitializeToolBar()
        {
            var images = new List<BitmapImage>
            {
                new BitmapImage(new Uri("Images/backward.png", UriKind.Relative)),
                new BitmapImage(new Uri("Images/forward.png", UriKind.Relative)),
                new BitmapImage(new Uri("Images/openFolder.png", UriKind.Relative)),
                new BitmapImage(new Uri("Images/save all.png", UriKind.Relative)),
                new BitmapImage(new Uri("Images/save.png", UriKind.Relative)),
            };

            foreach (BitmapImage i in images)
            {
                var b = new Button
                {
                    Content = new Image
                    {
                        Source = i,
                        Width = 25
                    }
                };
                toolBar.Items.Add(b);
            }
        }
    }
}
