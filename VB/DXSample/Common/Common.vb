Namespace DXSample.Common
    Public Enum ModuleType
        Customers
        Sales
        Products
    End Enum

    Public NotInheritable Class Regions

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property Main() As String
            Get
                Return "MainRegion"
            End Get
        End Property
        Public Shared ReadOnly Property Navigation() As String
            Get
                Return "NavigationRegion"
            End Get
        End Property
    End Class
End Namespace
