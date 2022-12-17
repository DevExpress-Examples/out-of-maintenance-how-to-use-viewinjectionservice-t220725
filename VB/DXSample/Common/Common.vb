Namespace DXSample.Common

    Public Enum ModuleType
        Customers
        Sales
        Products
    End Enum

    Public Module Regions

        Public ReadOnly Property Main As String
            Get
                Return "MainRegion"
            End Get
        End Property

        Public ReadOnly Property Navigation As String
            Get
                Return "NavigationRegion"
            End Get
        End Property
    End Module
End Namespace
