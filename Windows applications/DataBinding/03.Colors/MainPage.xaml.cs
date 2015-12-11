using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using UI = Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Color
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void RadioBtnBackgroundChecked(object sender, RoutedEventArgs e)
        {
            var radioBtn = sender as RadioButton;
            var color = ColorAsStringToBrush(radioBtn.Tag.ToString());
            this.borderForTextBlock.Background = new SolidColorBrush(color);
        }

        private void RadioBtnForegroundChecked(object sender, RoutedEventArgs e)
        {
            {
                var radioBtn = sender as RadioButton;
                var color = ColorAsStringToBrush(radioBtn.Tag.ToString());
                this.textBlock.Foreground = new SolidColorBrush(color);
            }
        }

        private static UI.Color ColorAsStringToBrush(string color) // color = "#E7E44D"
        {
            color = color.Replace("#", "");
            if (color.Length == 6)
            {
                return  (UI.ColorHelper.FromArgb(255,
                    byte.Parse(color.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                    byte.Parse(color.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                    byte.Parse(color.Substring(4, 2), System.Globalization.NumberStyles.HexNumber)));
            }
            else
            {
                return UI.Colors.White;
            }
        }
    }
}