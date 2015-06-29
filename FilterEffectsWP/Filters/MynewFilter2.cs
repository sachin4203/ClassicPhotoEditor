using System;
using System.Collections.Generic;
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
    class MynewFilter2 : AbstractFilter
    {
        protected Nokia.Graphics.Imaging.SepiaFilter _colorSwapFilter;



        public MynewFilter2()
            : base()
        {
            Name = "Musk";
            ShortDescription = "";

            _colorSwapFilter = new Nokia.Graphics.Imaging.SepiaFilter();
        }


        protected override void SetFilters(FilterEffect effect)
        {
            effect.Filters = new List<IFilter>() { _colorSwapFilter };
        }
    }
}
