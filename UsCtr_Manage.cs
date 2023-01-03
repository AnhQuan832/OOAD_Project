using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class UsCtr_Manage : UserControl
    {
        public UsCtr_Manage()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
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
