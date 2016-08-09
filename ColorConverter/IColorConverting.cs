using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorConverter
{
    interface IColorConverting
    {
       String ToHex(Color color);
       String ToRGB(Color c);
       String RgbToHex(int R, int G, int B);
    }
}
