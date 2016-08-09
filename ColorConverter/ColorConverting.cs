using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorConverter
{
    public class ColorConverting : IColorConverting
    {
        private ColorConverting _colorConverting;
        private static object _lock = new object();

        private ColorConverting colorConverting
        {
            get
            {
                lock (_lock)
                {
                    if (_colorConverting == null)
                    {
                        _colorConverting = new ColorConverting();
                    }
                }

                return _colorConverting;
            }
        }
        
        /// <summary>
        /// System.Drawing.Color to HEX
        /// </summary>
        /// <param name="color">System.Drawing.Color</param>
        /// <returns>HEX string</returns>
        public string ToHex(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        /// <summary>
        /// System.Drawing.Color to RGB
        /// </summary>
        /// <param name="c">System.Drawing.Color</param>
        /// <returns>RGB string</returns>
        public string ToRGB(Color c)
        {
            return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }

        /// <summary>
        /// RGB to HEX convertig 
        /// </summary>
        /// <param name="R">Red -> Range(0,255) </param>
        /// <param name="G">Green -> Range(0,255)</param>
        /// <param name="B">Blue -> Range(0,255)</param>
        /// <returns>Hex string</returns>
        public string RgbToHex(int R, int G, int B)
        {
            try
            {
                Color myColor = Color.FromArgb(R, G, B);
                string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                return "#" + hex;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
