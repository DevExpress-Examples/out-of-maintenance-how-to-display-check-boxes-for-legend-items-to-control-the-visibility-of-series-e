Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace CheckBoxesInLegendExample
	Public Class LegendItemPresentation
		Inherits DependencyObject
		Public Shared ReadOnly SeriesProperty As DependencyProperty = DependencyProperty.Register("Series", GetType(Series), GetType(LegendItemPresentation), Nothing)

		Public Property Series() As XYSeries
			Get
				Return CType(GetValue(SeriesProperty), XYSeries)
			End Get
			Set(ByVal value As XYSeries)
				SetValue(SeriesProperty, value)
			End Set
		End Property
	End Class
End Namespace
