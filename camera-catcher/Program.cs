using System;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CameraHack

{
    class Program 
    {
        static void Main(string[] args)
        {
            FilterInfoCollection videoDevice = new FilterInfoCollection(FilterCategory.VideoInput);
            if(videoDevice.Count == 0)
            {
                System.Console.WriteLine("No video device captured");
                return;
            }
            VideCaptureDevice = videoCaptureDevice = new videoCaptureDevice(videoDevice[0].Moniker());
            videoCaptureDevice.Start();
            Console.ReadKey();
            videoCaptureDevice.Stop();
        }

        private static void Videodevice_newframe(object sender, NewFrameEventArgs eventarg)
        {
            Image frame = (Bitmap)eventarg.Frame.Clone();
            frame.Save("evil_photo.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            System.Console.WriteLine("Image captured and saved as evil_photo.bmp");
        }
    }
}