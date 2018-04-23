using System.Windows;
using DevExpress.Xpf.Charts;

namespace CheckBoxesInLegendExample {
    public class LegendItemPresentation : DependencyObject {
        public static readonly DependencyProperty SeriesProperty = DependencyProperty.Register("Series", typeof(Series), typeof(LegendItemPresentation), null);

        public XYSeries Series {
            get { return (XYSeries)GetValue(SeriesProperty); }
            set { SetValue(SeriesProperty, value); }
        }
    }
}
