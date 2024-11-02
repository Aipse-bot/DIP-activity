using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageProcessing
{
    static class ImageProcess
    {
        public static void Histogram(ref Bitmap a, ref Bitmap b) 
        {
            Color sample;
            Color gray;
            Byte graydata;
            //Grayscale Convertion;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }
            }
            
            //histogram 1d data;
            int[] histdata = new int[256]; // array from 0 to 255
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    histdata[sample.R]++; // can be any color property r,g or b
                }
            }

            // Bitmap Graph Generation
            // Setting empty Bitmap with background color
            b = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }
            // plotting points based from histdata
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, b.Height - 1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }
        }
        
    }
}
