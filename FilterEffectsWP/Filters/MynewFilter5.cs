using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Nokia.Graphics;
using Nokia.Graphics.Imaging;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using FilterEffects.Filters.FilterControls;
using FilterEffects.Resources;

namespace FilterEffects.Filters
{
    class MynewFilter5 : AbstractFilter
    {
         protected Nokia.Graphics.Imaging.WatercolorFilter _colorSwapFilter;



        public MynewFilter5()
            : base()
        {
            Name = "Watercolour";
            ShortDescription = "";

            _colorSwapFilter = new Nokia.Graphics.Imaging.WatercolorFilter(0.4f, 0.3f);
            
        }
        


        protected override void SetFilters(FilterEffect effect)
        {
            effect.Filters = new List<IFilter>() { _colorSwapFilter };
            
        }

    }
}
