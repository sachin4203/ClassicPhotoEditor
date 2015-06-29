using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Nokia.Graphics;
using Nokia.Graphics.Imaging;

using FilterEffects.Filters.FilterControls;
using FilterEffects.Resources;
namespace FilterEffects.Filters
{
    public class MynewFilter4 : AbstractFilter
    {
        private const double DefaultBrightness = 0.5;
        private const double DefaultSaturation = 0.5;
        private const LomoVignetting DefaultLomoVignetting = LomoVignetting.High;
        private const LomoStyle DefaultLomoStyle = LomoStyle.Neutral;
        protected String _lomoVignettingGroup = "CarShowLomoVignetting";

        protected Nokia.Graphics.Imaging.HueSaturationFilter _colorSwapFilter;



        public MynewFilter4()
            : base()
        {
            Name = "Colour Splash";
            ShortDescription = "";

            _colorSwapFilter = new Nokia.Graphics.Imaging.HueSaturationFilter(-0.6,-0.8); ;
            
            _colorSwapFilter.Saturation = DefaultSaturation;
            _colorSwapFilter.Hue = DefaultBrightness;
          
        }


        protected override void SetFilters(FilterEffect effect) 
        {
            effect.Filters = new List<IFilter>() { _colorSwapFilter };
        }

        public override bool AttachControl(FilterPropertiesControl control)
        {
            Control = control;

            Grid grid = new Grid();
            int rowIndex = 0;

            TextBlock brightnessText = new TextBlock();
            brightnessText.Text = "Hue";
            Grid.SetRow(brightnessText, rowIndex++);

            Slider brightnessSlider = new Slider();
            brightnessSlider.Minimum = 0.0;
            brightnessSlider.Maximum = 1.0;
            brightnessSlider.Value = _colorSwapFilter.Hue;
            brightnessSlider.ValueChanged += brightnessSlider_ValueChanged;
            Grid.SetRow(brightnessSlider, rowIndex++);

             TextBlock saturationText = new TextBlock();
            saturationText.Text = "Saturation";
            Grid.SetRow(saturationText, rowIndex++);

            Slider saturationSlider = new Slider();
            saturationSlider.Minimum = 0.0;
            saturationSlider.Maximum = 1.0;
            saturationSlider.Value = _colorSwapFilter.Saturation;
            saturationSlider.ValueChanged +=saturationSlider_ValueChanged;
            Grid.SetRow(saturationSlider, rowIndex++);

            for (int i = 0; i < rowIndex; ++i)
            {
                RowDefinition rd = new RowDefinition();
                grid.RowDefinitions.Add(rd);
            }

            grid.Children.Add(brightnessText);
            grid.Children.Add(brightnessSlider);
            grid.Children.Add(saturationText);
            grid.Children.Add(saturationSlider);


            control.ControlsContainer.Children.Add(grid);

            return true;
        }


        protected void saturationSlider_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine("Changing saturation changed to " + e.NewValue);
            Changes.Add(() => { _colorSwapFilter.Saturation = e.NewValue; });
            Apply();
            Control.NotifyManipulated();
        }


        protected void brightnessSlider_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine("Changing brightness to " + (1.0 - e.NewValue));
            Changes.Add(() => { _colorSwapFilter.Hue = 1.0 - e.NewValue; });
            Apply();
            Control.NotifyManipulated();
        }
    }
}
