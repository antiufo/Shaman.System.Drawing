using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Drawing
{
    public class ImageConverter
    {
        public object ConvertTo(Image _image, Type type)
        {
            if (type == typeof(byte[])) return _image.ms.ToArray();
            throw new NotSupportedException();
        }
    }
}
