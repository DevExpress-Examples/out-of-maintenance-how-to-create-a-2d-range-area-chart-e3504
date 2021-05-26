<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/RangeArea2DChart/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/RangeArea2DChart/MainWindow.xaml))
<!-- default file list end -->
# How to create a 2D  Range Area chart

The following example demonstrates how to create a [2D Range Area](https://docs.devexpress.com/WPF/10634/controls-and-libraries/charts-suite/chart-control/fundamentals/series-fundamentals/2d-series-types/area-series/range-area?p=netframework) chart.

### Description

To do this, it is necessary to assign the [ChartControl.Diagram](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.Diagram?p=netframework) property to [XYDiagram2D](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.XYDiagram2D?p=netframework), and then add a [RangeAreaSeries2D](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.RangeAreaSeries2D?p=netframework) object to the diagram's [Series](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Diagram.Series?p=netframework) collection.
