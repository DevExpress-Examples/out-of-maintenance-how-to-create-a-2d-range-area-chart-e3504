Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace RangeArea2DChart

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ChartViewModel

        Private dataPointsField As List(Of DataPoint)

        Public ReadOnly Property DataPoints As List(Of DataPoint)
            Get
                If dataPointsField Is Nothing Then
                    dataPointsField = New List(Of DataPoint) From {New DataPoint(New DateTime(2019, 1, 1), 7.2, 2.7), New DataPoint(New DateTime(2019, 2, 1), 8.3, 2.8), New DataPoint(New DateTime(2019, 3, 1), 12.2, 5.3), New DataPoint(New DateTime(2019, 4, 1), 15.6, 7.3), New DataPoint(New DateTime(2019, 5, 1), 19.6, 10.9), New DataPoint(New DateTime(2019, 6, 1), 22.7, 13.8), New DataPoint(New DateTime(2019, 7, 1), 25.2, 15.8), New DataPoint(New DateTime(2019, 8, 1), 25, 15.7), New DataPoint(New DateTime(2019, 9, 1), 21.1, 12.7), New DataPoint(New DateTime(2019, 10, 1), 16.3, 9.6), New DataPoint(New DateTime(2019, 11, 1), 10.8, 5.8), New DataPoint(New DateTime(2019, 12, 1), 7.5, 3.4)}
                End If

                Return dataPointsField
            End Get
        End Property
    End Class

    Public Class DataPoint

        Public Property Time As Date

        Public Property Value1 As Double

        Public Property Value2 As Double

        Public Sub New(ByVal time As Date, ByVal value1 As Double, ByVal value2 As Double)
            Me.Time = time
            Me.Value1 = value1
            Me.Value2 = value2
        End Sub
    End Class
End Namespace
