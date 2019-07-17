Class MainWindow

    Sub New()


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Dim brush As New LinearGradientBrush
        'brush.GradientStops.Add(New GradientStop With {.Offset = 0, .Color = Colors.Blue})
        'brush.GradientStops.Add(New GradientStop With {.Offset = 0.6, .Color = Colors.White})
        'grid1.Background = brush


    End Sub

    Private Sub BtnClickP1(sender As Object, e As RoutedEventArgs)
        myFrame.NavigationService.Navigate(New Page1())
    End Sub
End Class
