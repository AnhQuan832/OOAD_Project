using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Statistic : UserControl
    {
        public UsCtr_Statistic()
        {
            InitializeComponent();


            //Bar Chart
            //cartesianChart1.Series = new SeriesCollection
            //{
            //    new ColumnSeries
            //    {
            //        //Title = "2015",
            //         Values = new ChartValues<double> {4, 6, 5, 2, 7, 7, 8, 10, 11,13,10,  6}
            //    }
            //};

            ////adding series will update and animate the chart automatically
            ////cartesianChart1.Series.Add(new ColumnSeries
            ////{
            ////    Title = "2016",
            ////    Values = new ChartValues<double> { 11, 56, 42 }
            ////});

            ////also adding values updates and animates the chart automatically
            ////cartesianChart1.Series[1].Values.Add(48d);

            //cartesianChart1.AxisX.Add(new Axis
            //{
            //    Title = "Month",
            //    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "August", "September", "October", "November", "December" }
            //});

            //cartesianChart1.AxisY.Add(new Axis
            //{
            //    Title = "Revenue",
            //    LabelFormatter = value => value.ToString("N")
            //});


            //Line Chart
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Revenue",
                    Values = new ChartValues<double> {40, 60, 50, 20, 70, 70, 80, 100, 110,130,100,  60}
                },
                //new LineSeries
                //{
                //    Title = "Series 2",
                //    Values = new ChartValues<double> {6, 7, 3, 4, 6},
                //    PointGeometry = null
                //},

            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.None;

        }
    }
}

