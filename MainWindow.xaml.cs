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

namespace overlayV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OverlayWindow overlay = new OverlayWindow();
        public MainWindow()
        {
            overlay.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
            overlay.WindowStyle = WindowStyle.None;
            overlay.AllowsTransparency = true;
            InitializeComponent();
        }

        private bool toggle_status = false;
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (toggle_status == false)
            {
                toggle_status = true;
                ToggleButton.Background = new SolidColorBrush(Color.FromRgb(191, 191, 191));
                ToggleButton.Content = "Stop";
                edit_blocker.Visibility = Visibility.Visible;
                overlay.Show();
                overlay.Top = 549;
                overlay.Left = 21;
            } else if (toggle_status == true)
            {
                toggle_status = false;
                ToggleButton.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                ToggleButton.Content = "Start";
                edit_blocker.Visibility = Visibility.Hidden;
                overlay.Hide();
            }
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void update_color(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var r = (byte)red_slider.Value;
            var g = (byte)green_slider.Value;
            var b = (byte)blue_slider.Value;
            red_value.Content = r;
            green_value.Content = g;
            blue_value.Content = b;
            color_display.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy1.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy2.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy3.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy4.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy5.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy6.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy7.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy8.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
            overlay.bar_Copy9.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        
    }
}
