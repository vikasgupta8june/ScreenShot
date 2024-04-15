using System.Drawing;
using System.Drawing.Imaging;

public class ScreenshotExample
{
    public static void Main()
    {
        try
        {
            // Step 1: Create a new Bitmap object with dimensions of image as 1920x1080
            var bitmap = new Bitmap(1920, 1080);

            //A Bitmap object in .NET represents an image stored in memory.
            //It's part of the System.Drawing namespace in .NET Framework and .NET Core,

            // Step 2: Create a Graphics object from the Bitmap
            using (var g = Graphics.FromImage(bitmap))
            {
                //Graphics object represents a drawing surface & provides methods for rendering graphical content.
                //used for drawing shapes, text, and images onto various drawing surfaces, such as Bitmaps, Forms, or Controls.
                //FromImage method used to create a Graphics object from an existing Image object, such as a Bitmap

                // Step 3: Copy the contents of the screen to the Bitmap
                // Parameters: (sourceX, sourceY, destinationX, destinationY, size, copyPixelOperation)
                // Here, we're copying from the top-left corner of the screen (0,0) to the top-left corner of the Bitmap (0,0)
                g.CopyFromScreen(0, 0, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);

                //used to capture a portion of the screen and copy it onto a specified drawing surface, typically a Bitmap
            }

            // Step 4: Save the Bitmap as a JPEG image to the specified file path
            bitmap.Save(@"C:\Image\filename.jpg", ImageFormat.Jpeg);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
