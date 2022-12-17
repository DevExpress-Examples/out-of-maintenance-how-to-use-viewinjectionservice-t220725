Imports DevExpress.Mvvm.POCO

Namespace DXSample.ViewModel

    Public Class MainViewModel

        Protected Sub New()
        End Sub

        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function
    End Class
End Namespace
