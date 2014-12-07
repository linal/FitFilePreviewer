using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FitFilePreviewer.Decode.Dto;

namespace FitFilePreviewer.Handler
{
    /// <summary>
    /// Interaction logic for FitFilePreview.xaml
    /// </summary>
    public partial class FitPreviewControl : UserControl
    {
        public FitPreviewControl()
        {
            InitializeComponent();
        }

        public void SetModel(ActivitySummary activitySummary)
        {
            if (activitySummary != null)
            {
                this.Sport.Content = activitySummary.Sport.ToString();
                this.TotalDistance.Content = GetTotalDistance(activitySummary);
                this.TotalElapsedTime.Content = GetElapsedTime(activitySummary);
                this.StartTime.Content = activitySummary.StartTime.ToString();
                
                if (activitySummary.Sport == FitFilePreviewer.Decode.Fit.Types.Sport.Running)
                {
                    DisplayImage.Source = GetImageSourceFromResource("Images/run.png");
                }

                if (activitySummary.Sport == FitFilePreviewer.Decode.Fit.Types.Sport.Cycling)
                {
                    DisplayImage.Source = GetImageSourceFromResource("Images/bike.png");
                }

                if (activitySummary.Sport == FitFilePreviewer.Decode.Fit.Types.Sport.Swimming)
                {
                    DisplayImage.Source = GetImageSourceFromResource("Images/swim.png");
                }
                 
            }
        }

        private string GetElapsedTime(ActivitySummary activitySummary)
        {
            return new TimeSpan(Convert.ToInt64(activitySummary.TotalElapsedTime.Value*10000000)).ToString(@"hh\:mm\:ss");
        }

        private string GetTotalDistance(ActivitySummary activitySummary)
        {
            if (activitySummary.Sport == Decode.Fit.Types.Sport.Swimming)
            {
                return String.Format("{0}M",activitySummary.TotalDistance);
            }

            var dist = Convert.ToDouble(activitySummary.TotalDistance)/1000;
            return String.Format("{0}KM", Math.Round(dist, 1));
        }

        static internal ImageSource GetImageSourceFromResource(string resourceName)
        {
            var oUri = new Uri("pack://application:,,,/FitFilePreviewer.Handler;component/" + resourceName, UriKind.RelativeOrAbsolute);
            Debug.WriteLine(oUri);
            return BitmapFrame.Create(oUri);
        }
    }
}
