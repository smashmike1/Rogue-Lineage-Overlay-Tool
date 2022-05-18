using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace overlayV2
{
    public partial class SpellsTree : Window
    {
        private const int GWL_STYLE = -16;
        private const int WS_SYSMENU = 0x80000;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public string? zone;
        public string? settings;

        public bool is_n;
        public bool is_s;

        public byte r;
        public byte g;
        public byte b;
        public byte rs;
        public byte gs;
        public byte bs;
        public byte a;

        public SpellsTree()
        {
            InitializeComponent();
        }

        private void apply_Click(object sender, RoutedEventArgs e)
        {
            settings = zone + "||" + is_n.ToString() + "||" + is_s + "||" + r + "||" + g + "||" + b + "||" + rs + "||" + gs + "||" + bs + "||" + a;
            this.Hide();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void snap_toggle_Checked(object sender, RoutedEventArgs e)
        {
            is_s = true;
        }

        private void snap_toggle_Unchecked(object sender, RoutedEventArgs e)
        {
            is_s = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var hwnd = new WindowInteropHelper(this).Handle;
            SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void update_color(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender == red_slider)
            {
                r = (byte)red_slider.Value;
                red_value.Content = r.ToString();
                color_display.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            }
            else if (sender == green_slider)
            {
                g = (byte)green_slider.Value;
                green_value.Content = g.ToString();
                color_display.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            }
            else if (sender == blue_slider)
            {
                b = (byte)blue_slider.Value;
                blue_value.Content = b.ToString();
                color_display.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            }
            else if (sender == red_slider_snap)
            {
                rs = (byte)red_slider_snap.Value;
                red_value_snap.Content = rs.ToString();
                color_display_snap.Background = new SolidColorBrush(Color.FromRgb(rs, gs, bs));
            }
            else if (sender == green_slider_snap)
            {
                gs = (byte)green_slider_snap.Value;
                green_value_snap.Content = gs.ToString();
                color_display_snap.Background = new SolidColorBrush(Color.FromRgb(rs, gs, bs));
            }
            else if (sender == blue_slider_snap)
            {
                bs = (byte)blue_slider_snap.Value;
                blue_value_snap.Content = bs.ToString();
                color_display_snap.Background = new SolidColorBrush(Color.FromRgb(rs, gs, bs));
            }
            else if (sender == opacity_slider)
            {
                a = (byte)opacity_slider.Value;
                opacity_value.Content = a.ToString();
            }
        }

        private void normal_toggle_Checked(object sender, RoutedEventArgs e)
        {
            is_n = true;

        }

        private void normal_toggle_Unchecked(object sender, RoutedEventArgs e)
        {
            is_n = false;
        }


        private void preset_click(object sender, RoutedEventArgs e)
        {
            zone_block.Visibility = Visibility.Hidden;
            zone = ((MenuItem)sender).Name;

            if (zone == "viribus")
            {
                r = 125;
                red_slider.Value = 125;
                rs = 125;
                red_slider_snap.Value = 125;
                a = 50;
                opacity_slider.Value = 50;
            }
            else if (zone == "nocere")
            {
                r = 125;
                red_slider.Value = 125;
                rs = 125;
                red_slider_snap.Value = 125;
                a = 50;
                opacity_slider.Value = 50;
            }
            else if (zone == "ignis")
            {
                r = 125;
                red_slider.Value = 125;
                rs = 125;
                red_slider_snap.Value = 125;
                a = 50;
                opacity_slider.Value = 50;
            }
            else if (zone == "gate")
            {
                r = 125;
                red_slider.Value = 125;
                rs = 125;
                red_slider_snap.Value = 125;
                a = 50;
                opacity_slider.Value = 50;
            }
            else if (zone == "snarvindur")
            {
                r = 125;
                red_slider.Value = 125;
                rs = 125;
                red_slider_snap.Value = 125;
                a = 50;
                opacity_slider.Value = 50;
            }
            else if (zone == "gelidus")
            {
                r = 125;
                red_slider.Value = 125;
                rs = 125;
                red_slider_snap.Value = 125;
                a = 50;
                opacity_slider.Value = 50;
            }
            else if (zone == "hoppa")
            {
                r = 125;
                red_slider.Value = 125;
                rs = 125;
                red_slider_snap.Value = 125;
                a = 50;
                opacity_slider.Value = 50;
            }
            else if (zone == "saggita")
            {
                r = 125;
                red_slider.Value = 125;
                rs = 125;
                red_slider_snap.Value = 125;
                a = 50;
                opacity_slider.Value = 50;
            }
        }
    }
}
