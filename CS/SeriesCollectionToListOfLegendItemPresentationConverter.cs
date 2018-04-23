using System;
using System.Windows.Data;
using DevExpress.Xpf.Charts;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;

namespace CheckBoxesInLegendExample {
    public class SeriesCollectionToListOfLegendItemPresentationConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            SeriesCollection seriesCollection = value as SeriesCollection;
            if (seriesCollection == null || targetType != typeof(IEnumerable))
                return null;
            else {
                List<LegendItemPresentation> result = new List<LegendItemPresentation>();
                foreach (XYSeries series in seriesCollection)
                    result.Add(new LegendItemPresentation(){ Series = series });
                return result;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
