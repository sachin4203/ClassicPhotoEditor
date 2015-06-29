using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
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
    class MynewFilter3 : AbstractFilter
    {

        private const double DefaultBrightness = 0.5;
        protected Nokia.Graphics.Imaging.SolarizeFilter _colorSwapFilter;



        public MynewFilter3()
            : base()
        {
            Name = "Futurist";
            ShortDescription = "";

            _colorSwapFilter = new Nokia.Graphics.Imaging.SolarizeFilter(0.5);
            _colorSwapFilter.Threshold = DefaultBrightness;
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
            brightnessText.Text = "Threshold";
            Grid.SetRow(brightnessText, rowIndex++);

            Slider brightnessSlider = new Slider();
            brightnessSlider.Minimum = 0.0;
            brightnessSlider.Maximum = 1.0;
            brightnessSlider.Value = _colorSwapFilter.Threshold;
            brightnessSlider.ValueChanged += brightnessSlider_ValueChanged;
            Grid.SetRow(brightnessSlider, rowIndex++);


            for (int i = 0; i < rowIndex; ++i)
            {
                RowDefinition rd = new RowDefinition();
                grid.RowDefinitions.Add(rd);
            }

            grid.Children.Add(brightnessText);
            grid.Children.Add(brightnessSlider);

            control.ControlsContainer.Children.Add(grid);

            return true;
        }

        protected void brightnessSlider_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            Debug.WriteLine("Changing brightness to " + (1.0 - e.NewValue));
            Changes.Add(() => { _colorSwapFilter.Threshold = 1.0 - e.NewValue; });
            Apply();
            Control.NotifyManipulated();
        }
    }
}
