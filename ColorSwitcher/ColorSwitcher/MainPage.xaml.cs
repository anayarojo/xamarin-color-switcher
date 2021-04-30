using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorSwitcher
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MixColors(object sender, ValueChangedEventArgs e)
        {
            var red = redSlider.Value;
            var green = greenSlider.Value;
            var blue = blueSlider.Value;

            var backgroundColor = new Color((red / 255), (green /255), (blue / 255));
            boxColor.BackgroundColor = backgroundColor;
            lblHexValue.Text = ColorToHex(backgroundColor);

            lblRedValue.Text = red.ToString();
            lblGreenValue.Text = green.ToString();
            lblBlueValue.Text = blue.ToString();
        }

        private string ColorToHex(Color color)
        {
            var red = (int)(color.R * 255);
            var green = (int)(color.G * 255);
            var blue = (int)(color.B * 255);
            var alpha = (int)(color.A * 255);

            return $"{red:X2}{green:X2}{blue:X2}{alpha:X2}";
        }
    }
}
