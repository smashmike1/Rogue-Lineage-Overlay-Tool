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
using System.Windows.Shapes;

namespace overlayV2
{
	public partial class MainWindow : Window
	{
		private OverlayWindow overlay = new OverlayWindow();
		private SpellsTree zones_window = new SpellsTree();

		private bool toggle_status = false;

		public MainWindow()
		{
			overlay.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
			overlay.WindowStyle = WindowStyle.None;
			overlay.AllowsTransparency = true;
			InitializeComponent();
		}
		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Environment.Exit(0);
		}

		private void TabItem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (toggle_status == false)
			{
				if (zones_window.IsVisible == false)
				{
					zones_window.Show();
				}
			}
		}

		private void ToggleButton_Click(object sender, RoutedEventArgs e)
		{
			if (zones_window.settings != null)
			{
				string[]? args = zones_window.settings.Split("||");
				var zone = args[0];
				bool is_normal = args[1] == "True";
				bool is_snap = args[2] == "True";
				byte red_normal = byte.Parse(args[3]);
				byte green_normal = byte.Parse(args[4]);
				byte blue_normal = byte.Parse(args[5]);
				byte red_snap = byte.Parse(args[6]);
				byte green_snap = byte.Parse(args[7]);
				byte blue_snap = byte.Parse(args[8]);
				byte alpha = byte.Parse(args[9]);

				overlay.viribus.Visibility = Visibility.Hidden;
				overlay.snap_viribus.Visibility = Visibility.Hidden;
				overlay.nocere.Visibility = Visibility.Hidden;
				overlay.snap_nocere.Visibility = Visibility.Hidden;
				overlay.ignis.Visibility = Visibility.Hidden;
				overlay.snap_ignis.Visibility = Visibility.Hidden;
				overlay.gate.Visibility = Visibility.Hidden;
				overlay.snap_gate.Visibility = Visibility.Hidden;
				overlay.gelidus.Visibility = Visibility.Hidden;
				overlay.snap_gelidus.Visibility = Visibility.Hidden;
				overlay.hoppa.Visibility = Visibility.Hidden;
				overlay.snap_hoppa.Visibility = Visibility.Hidden;
				overlay.saggita_sol.Visibility = Visibility.Hidden;
				overlay.snap_saggita_sol.Visibility = Visibility.Hidden;


				if (zone == "viribus")
				{
					overlay.viribus.Background = new SolidColorBrush(Color.FromArgb(alpha, red_normal, green_normal, blue_normal));
					overlay.snap_viribus.Background = new SolidColorBrush(Color.FromArgb(alpha, red_snap, green_snap, blue_snap));
					if (is_normal == true)
					{
						overlay.viribus.Visibility = Visibility.Visible;
					}
					if (is_snap == true)
					{
						overlay.snap_viribus.Visibility = Visibility.Visible;
					}

				}
				else if (zone == "nocere")
				{
					overlay.nocere.Background = new SolidColorBrush(Color.FromArgb(alpha, red_normal, green_normal, blue_normal));
					overlay.snap_nocere.Background = new SolidColorBrush(Color.FromArgb(alpha, red_snap, green_snap, blue_snap));
					if (is_normal == true)
					{
						overlay.nocere.Visibility = Visibility.Visible;
					}
					if (is_snap == true)
					{
						overlay.snap_nocere.Visibility = Visibility.Visible;
					}
				}
				else if (zone == "ignis")
				{
					overlay.ignis.Background = new SolidColorBrush(Color.FromArgb(alpha, red_normal, green_normal, blue_normal));
					overlay.snap_ignis.Background = new SolidColorBrush(Color.FromArgb(alpha, red_snap, green_snap, blue_snap));
					if (is_normal == true)
					{
						overlay.ignis.Visibility = Visibility.Visible;
					}
					if (is_snap == true)
					{
						overlay.snap_ignis.Visibility = Visibility.Visible;
					}
				}
				else if (zone == "gate")
				{
					overlay.gate.Background = new SolidColorBrush(Color.FromArgb(alpha, red_normal, green_normal, blue_normal));
					overlay.snap_gate.Background = new SolidColorBrush(Color.FromArgb(alpha, red_snap, green_snap, blue_snap));
					if (is_normal == true)
					{
						overlay.gate.Visibility = Visibility.Visible;
					}
					if (is_snap == true)
					{
						overlay.snap_gate.Visibility = Visibility.Visible;
					}
				}
				else if (zone == "snarvindur")
				{
					overlay.snarvindur.Background = new SolidColorBrush(Color.FromArgb(alpha, red_normal, green_normal, blue_normal));
					overlay.snap_snarvindur.Background = new SolidColorBrush(Color.FromArgb(alpha, red_snap, green_snap, blue_snap));
					if (is_normal == true)
					{
						overlay.snarvindur.Visibility = Visibility.Visible;
					}
					if (is_snap == true)
					{
						overlay.snap_snarvindur.Visibility = Visibility.Visible;
					}
				}
				else if (zone == "gelidus")
				{
					overlay.gelidus.Background = new SolidColorBrush(Color.FromArgb(alpha, red_normal, green_normal, blue_normal));
					overlay.snap_gelidus.Background = new SolidColorBrush(Color.FromArgb(alpha, red_snap, green_snap, blue_snap));
					if (is_normal == true)
					{
						overlay.gelidus.Visibility = Visibility.Visible;
					}
					if (is_snap == true)
					{
						overlay.snap_gelidus.Visibility = Visibility.Visible;
					}
				}
				else if (zone == "hoppa")
				{
					overlay.hoppa.Background = new SolidColorBrush(Color.FromArgb(alpha, red_normal, green_normal, blue_normal));
					overlay.snap_hoppa.Background = new SolidColorBrush(Color.FromArgb(alpha, red_snap, green_snap, blue_snap));
					if (is_normal == true)
					{
						overlay.hoppa.Visibility = Visibility.Visible;
					}
					if (is_snap == true)
					{
						overlay.snap_hoppa.Visibility = Visibility.Visible;
					}
				}
				else if (zone == "saggita")
				{
					overlay.saggita_sol.Background = new SolidColorBrush(Color.FromArgb(alpha, red_normal, green_normal, blue_normal));
					overlay.snap_saggita_sol.Background = new SolidColorBrush(Color.FromArgb(alpha, red_snap, green_snap, blue_snap));
					if (is_normal == true)
					{
						overlay.saggita_sol.Visibility = Visibility.Visible;
					}
					if (is_snap == true)
					{
						overlay.snap_saggita_sol.Visibility = Visibility.Visible;
					}
				}

				


			}
			if (toggle_status == false)
			{
				toggle_status = true;
				ToggleButton.Background = new SolidColorBrush(Color.FromRgb(191, 191, 191));
				ToggleButton.Content = "Stop";
				edit_blocker.Visibility = Visibility.Visible;
				overlay.Show();
				overlay.Top = 549;
				overlay.Left = 21;
			}
			else if (toggle_status == true)
			{
				toggle_status = false;
				ToggleButton.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
				ToggleButton.Content = "Start";
				edit_blocker.Visibility = Visibility.Hidden;
				overlay.Hide();
			}


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
