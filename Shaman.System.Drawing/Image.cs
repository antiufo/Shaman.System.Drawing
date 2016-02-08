using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;

namespace System.Drawing
{
    public abstract class Image : IDisposable
    {
        private int? height;
        internal MemoryStream ms;
        private int? width;

        public int Height { get { return height.Value; } }
        public int Width { get { return width.Value; } }

        public float HorizontalResolution { get { throw new NotImplementedException(); } }
        public float VerticalResolution { get { throw new NotImplementedException(); } }

        public Image() { }
        public Image(int width, int height)
        {
            this.width = width;
            this.height = height;
        }


        public void Dispose()
        {
            ms = null;
        }

        public Image FromStream(Stream stream)
        {
            var ms = new MemoryStream();
            stream.CopyTo(ms);
            return new Bitmap()
            {
                ms = ms
            };
        }

        public void Save(Stream stream, ImageFormat imageFormat)
        {
            throw new NotImplementedException();
        }

        public static Image FromFile(string fullName)
        {
            throw new NotImplementedException();
        }
    }
}
