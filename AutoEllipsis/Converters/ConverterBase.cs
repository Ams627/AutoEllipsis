using System;
using System.Windows.Markup;
using System.Collections.Generic;
using System.Linq;

namespace AutoEllipsis
{
    public class ConverterBase : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
