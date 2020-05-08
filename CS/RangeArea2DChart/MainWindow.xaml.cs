using System;
using System.Collections.Generic;
using System.Windows;

namespace RangeArea2DChart {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class ChartViewModel {
        List<DataPoint> dataPoints;
        public List<DataPoint> DataPoints {
            get {
                if (dataPoints == null) {
                    dataPoints = new List<DataPoint> {
                            new DataPoint (new DateTime(2019, 1, 1), 7.2, 2.7),
                            new DataPoint (new DateTime(2019, 2, 1), 8.3, 2.8),
                            new DataPoint (new DateTime(2019, 3, 1), 12.2, 5.3),
                            new DataPoint (new DateTime(2019, 4, 1), 15.6, 7.3),
                            new DataPoint (new DateTime(2019, 5, 1), 19.6, 10.9),
                            new DataPoint (new DateTime(2019, 6, 1), 22.7, 13.8),
                            new DataPoint (new DateTime(2019, 7, 1), 25.2, 15.8),
                            new DataPoint (new DateTime(2019, 8, 1), 25, 15.7),
                            new DataPoint (new DateTime(2019, 9, 1), 21.1, 12.7),
                            new DataPoint (new DateTime(2019, 10, 1), 16.3, 9.6),
                            new DataPoint (new DateTime(2019, 11, 1), 10.8, 5.8),
                            new DataPoint (new DateTime(2019, 12, 1), 7.5, 3.4)
                };
                }
                return dataPoints;
            }
        }
    }
    public class DataPoint {
        public DateTime Time { get; set; }
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public DataPoint(DateTime time, double value1, double value2) {
            this.Time = time;
            this.Value1 = value1;
            this.Value2 = value2;
        }
    }
}
