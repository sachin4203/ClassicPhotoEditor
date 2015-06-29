using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using Nokia.Graphics;
using Nokia.Graphics.Imaging;


using FilterEffects.Filters.FilterControls;
using FilterEffects.Resources;

namespace FilterEffects.Filters
{
    class MynewFilter1 : AbstractFilter
    {

        private const double DefaultBrightness = 0.5;
        private const double DefaultSaturation = 0.5;


        protected Nokia.Graphics.Imaging.TemperatureAndTintFilter _colorSwapFilter;



        public MynewFilter1()
            : base()
        {
            Name = "Chaos";
            ShortDescription = "";

            _colorSwapFilter = new Nokia.Graphics.Imaging.TemperatureAndTintFilter();


            _colorSwapFilter.Temperature = DefaultBrightness;
            _colorSwapFilter.Tint = DefaultSaturation;

            
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
            brightnessText.Text = "Temperature";
            Grid.SetRow(brightnessText, rowIndex++);

            Slider brightnessSlider = new Slider();
            brightnessSlider.Minimum = 0.0;
            brightnessSlider.Maximum = 1.0;
            brightnessSlider.Value = _colorSwapFilter.Temperature;
            brightnessSlider.ValueChanged += brightnessSlider_ValueChanged;
            Grid.SetRow(brightnessSlider, rowIndex++);

            TextBlock saturationText = new TextBlock();
            saturationText.Text = "Tint";
            Grid.SetRow(saturationText, rowIndex++);

            Slider saturationSlider = new Slider();
            saturationSlider.Minimum = 0.0;
            saturationSlider.Maximum = 1.0;
            saturationSlider.Value = _colorSwapFilter.Tint;
            saturationSlider.ValueChanged += saturationSlider_ValueChanged;
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

        protected void brightnessSlider_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine("Changing brightness to " + (1.0 - e.NewValue));
            Changes.Add(() => { _colorSwapFilter.Temperature = 1.0 - e.NewValue; });
            Apply();
            Control.NotifyManipulated();
        }

        protected void saturationSlider_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine("Changing saturation changed to " + e.NewValue);
            Changes.Add(() => { _colorSwapFilter.Tint = e.NewValue; });
            Apply();
            Control.NotifyManipulated();
        }
    }
}
