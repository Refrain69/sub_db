using System;
using System.Drawing;
using System.Linq;

namespace sub_db
{
    internal class IMAGE
    {
        /*==============================================================
		 * Image <--> Icon
		 *==============================================================*/
        internal static Icon img2icon(Image img)
        {
            return Icon.FromHandle(((Bitmap)img).GetHicon());
        }
        internal static Image icon2img(Icon icon)
        {
            return Image.FromHbitmap(icon.ToBitmap().GetHbitmap());
        }
    };
}	// namespace sub_db
