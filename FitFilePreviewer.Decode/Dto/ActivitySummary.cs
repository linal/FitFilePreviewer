using FitFilePreviewer.Decode.Fit.Types;

namespace FitFilePreviewer.Decode.Dto
{
    public class ActivitySummary
    {
        public Sport? Sport { get; set; }
        public float? TotalDistance { get; set; }
        public float? TotalElapsedTime { get; set; }
        public ushort? TotalFatCalories { get; set; }
        public DateTime StartTime { get; set; }
    }
}