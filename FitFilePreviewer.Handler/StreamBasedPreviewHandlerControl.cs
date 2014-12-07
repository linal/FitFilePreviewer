using System.IO;

namespace FitFilePreviewer.Handler
{
    public abstract class StreamBasedPreviewHandlerControl : PreviewHandlerControl
    {
        public sealed override void Load(FileInfo file)
        {
            using (var fileStream = new FileStream(file.FullName,
                FileMode.Open, FileAccess.Read, FileShare.Delete | FileShare.ReadWrite))
            {
                Load(fileStream);
            }
        }
    }
}