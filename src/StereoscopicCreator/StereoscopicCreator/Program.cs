using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace StereoscopicCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.Directory.CreateDirectory("output");

            using (Image imageL = Image.Load("C:/Repos/stereoscopic-creator/testdata/stereo_1_L.png"))
            using (Image imageR = Image.Load("C:/Repos/stereoscopic-creator/testdata/stereo_1_R.png"))
            using (Image image = new Image<Rgba32>(5332,6000))
            {
                image.Mutate(o => o
                    .DrawImage(imageL, new Point(0, 0), 1f)
                    .DrawImage(imageR, new Point(0, 3000), 1f)
                );

                image.Save("C:/Repos/stereoscopic-creator/testdata/ouput.png");
            }
        }
    }
}
