using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SimpleDonutChart
{
    /// <summary>
    /// Interaktionslogik für DonutChart.xaml
    /// </summary>
    public partial class DonutChart : UserControl
    {
        public DonutChart()
        {
            this.InitializeComponent();
            //DataContext = this;
        }
       public static readonly DependencyProperty PercentProperty = DependencyProperty.Register(
            "Percent", typeof(double), typeof(DonutChart), new PropertyMetadata());

        public double Percent
        {
            get { return (double)GetValue(PercentProperty); }
            set { SetValue(PercentProperty, value); }
        }

        public static readonly DependencyProperty ContentColorProperty = DependencyProperty.Register(
            "ContentColor", typeof(Brush), typeof(DonutChart), new PropertyMetadata(Brushes.Red));

        public Brush ContentColor
        {
            get { return (Brush)GetValue(ContentColorProperty); }
            set { SetValue(ContentColorProperty, value); }
        }

        public static readonly DependencyProperty FillColorProperty = DependencyProperty.Register(
            "FillColor", typeof(Brush), typeof(DonutChart), new PropertyMetadata(Brushes.LightGray));

        public Brush FillColor
        {
            get { return (Brush)GetValue(FillColorProperty); }
            set { SetValue(FillColorProperty, value); }
        }

        public static readonly DependencyProperty FontColorProperty = DependencyProperty.Register(
            "FontColor", typeof(Brush), typeof(DonutChart), new PropertyMetadata(Brushes.Gray));

        public Brush FontColor
        {
            get { return (Brush)GetValue(FontColorProperty); }
            set { SetValue(FontColorProperty, value); }
        }

        public static readonly DependencyProperty ArcThicknessProperty = DependencyProperty.Register(
           "ArcThickness", typeof(double), typeof(DonutChart), new PropertyMetadata(5.0));

        public double ArcThickness
        {
            get { return (double)GetValue(ArcThicknessProperty); }
            set { SetValue(FontColorProperty, value); }
        }
    }
}