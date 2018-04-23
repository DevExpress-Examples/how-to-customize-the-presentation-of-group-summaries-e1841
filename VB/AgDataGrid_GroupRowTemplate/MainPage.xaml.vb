Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports System.Collections.ObjectModel

Namespace AgDataGrid_GroupRowTemplate
	Partial Public Class MainPage
		Inherits UserControl
		Private ds As New ObservableCollection(Of Product)()

		Public Sub New()
			InitializeComponent()

			ds.Add(New Product() With {.CompanyName = "Island Trading", .Quantity = 10, .UnitPrice = 19})
			ds.Add(New Product() With {.CompanyName = "Island Trading", .Quantity = 18, .UnitPrice = 22.4})
			ds.Add(New Product() With {.CompanyName = "Island Trading", .Quantity = 7, .UnitPrice = 12})
			ds.Add(New Product() With {.CompanyName = "Rancho grande", .Quantity = 2, .UnitPrice = 263.5})
			ds.Add(New Product() With {.CompanyName = "Rancho grande", .Quantity = 12, .UnitPrice = 81})

			grid.DataSource = ds
		End Sub
	End Class
	Public Class Product
		Private privateCompanyName As String
		Public Property CompanyName() As String
			Get
				Return privateCompanyName
			End Get
			Set(ByVal value As String)
				privateCompanyName = value
			End Set
		End Property
		Private privateUnitPrice As Double
		Public Property UnitPrice() As Double
			Get
				Return privateUnitPrice
			End Get
			Set(ByVal value As Double)
				privateUnitPrice = value
			End Set
		End Property
		Private privateQuantity As Integer
		Public Property Quantity() As Integer
			Get
				Return privateQuantity
			End Get
			Set(ByVal value As Integer)
				privateQuantity = value
			End Set
		End Property
	End Class
End Namespace
