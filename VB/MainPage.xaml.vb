Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Charts

Namespace CheckBoxesInLegendExample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			For Each s As Series In xyDiagram2D.Series
				s.Visible = True
			Next s
		End Sub
	End Class
End Namespace
