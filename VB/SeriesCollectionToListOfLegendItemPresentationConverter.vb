Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Data
Imports DevExpress.Xpf.Charts
Imports System.Globalization
Imports System.Collections
Imports System.Collections.Generic

Namespace CheckBoxesInLegendExample
	Public Class SeriesCollectionToListOfLegendItemPresentationConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			Dim seriesCollection As SeriesCollection = TryCast(value, SeriesCollection)
			If seriesCollection Is Nothing OrElse targetType IsNot GetType(IEnumerable) Then
				Return Nothing
			Else
				Dim result As New List(Of LegendItemPresentation)()
				For Each series As XYSeries In seriesCollection
					result.Add(New LegendItemPresentation() With {.Series = series})
				Next series
				Return result
			End If
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
