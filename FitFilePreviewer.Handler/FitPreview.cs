using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace FitFilePreviewer.Handler
{
    [PreviewHandler("FIT file Preview Handler", ".fit", "{38AF3F46-D3EA-42FE-B304-A4B63C4D73FC}")]
    [ProgId("FitFilePreviewer.Handler")]
    [Guid("063B3AFC-2972-452F-B534-E57C647E1C97")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public sealed class FitPreview : StreamBasedPreviewHandler
    {
        public FitPreview()
        {
            Debug.WriteLine("FitPreview()");
        }

        private sealed class FitPreviewHandlerControl : StreamBasedPreviewHandlerControl
        {
            public override void Load(Stream stream)
            {
                if (stream == null)
                {
                    return;
                }

                try
                {
                    Trace.WriteLine("Loading");
                    var elementHost = new ElementHost();
                    var fitPreviewControl = new FitPreviewControl();
                    var decoder = new Decode.Decoder();
                    var activitySummary = decoder.Decode(stream);
                    if (activitySummary == null)
                    {
                        return;
                    }

                    Trace.WriteLine(string.Format("Activity: {0}", activitySummary.Sport));
                    fitPreviewControl.SetModel(activitySummary);
                    elementHost.Child = fitPreviewControl;
                    elementHost.Dock = DockStyle.Fill;
                    Controls.Add(elementHost);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    foreach (var str in ex.StackTrace.Split(new []{Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
                    {
                        Debug.WriteLine(str);
                    }

                    throw;
                }
            }
        }
            
        protected override PreviewHandlerControl CreatePreviewHandlerControl()
        {
            return new FitPreviewHandlerControl();
        }
    }
}
