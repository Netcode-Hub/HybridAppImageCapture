using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridAppImageCapture.Service
{
    public class CameraService
    {
        public async Task<FileResult?> CapturePhotoAsync()
        {
            if(MediaPicker.Default.IsCaptureSupported)
            {
                return await MediaPicker.Default.PickPhotoAsync();
            }
            throw new NotSupportedException("Camera capture is not supported");
        }
    }
}
