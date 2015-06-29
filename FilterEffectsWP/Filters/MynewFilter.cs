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
    public class MynewFilter : AbstractFilter
    {

        protected Nokia.Graphics.Imaging.MirrorFilter _colorSwapFilter;



        public MynewFilter()
            : base()
        {
            Name = "Mirror";
            ShortDescription = "";

            _colorSwapFilter = new Nokia.Graphics.Imaging.MirrorFilter();
        }


        protected override void SetFilters(FilterEffect effect)
        {
            effect.Filters = new List<IFilter>() { _colorSwapFilter };
        }
    }

}
