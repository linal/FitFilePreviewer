using System.Runtime.InteropServices;
using SharpShell.Attributes;
using SharpShell.SharpPreviewHandler;

namespace FitFilePreviewer.Handler
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.ClassOfExtension, ".fit")]
    [DisplayName("FIT Preview Handler")]
    [Guid("53CCD641-DC8A-4DE4-B426-76B1AB19FE19")]
    public class FitPreviewHandler : SharpPreviewHandler
    {
        protected override PreviewHandlerControl DoPreview()
        {
            var handler = new FitPreviewHandlerControl();

            return handler;
        }
    }
}