// Stephen Toub

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace FitFilePreviewer.Handler.COMInterop
{
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("b824b49d-22ac-4161-ac8a-9916e8fa3f7f")]
    interface IInitializeWithStream
    {
        void Initialize(IStream pstream, uint grfMode);
    }

}
