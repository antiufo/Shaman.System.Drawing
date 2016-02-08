using System;

namespace System.Drawing.Internal
{
	internal struct GPRECTF
	{
		internal float X;

		internal float Y;

		internal float Width;

		internal float Height;

		internal SizeF SizeF
		{
			get
			{
				return new SizeF(this.Width, this.Height);
			}
		}

		internal GPRECTF(float x, float y, float width, float height)
		{
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
		}

		internal GPRECTF(RectangleF rect)
		{
			this.X = rect.X;
			this.Y = rect.Y;
			this.Width = rect.Width;
			this.Height = rect.Height;
		}

		internal RectangleF ToRectangleF()
		{
			return new RectangleF(this.X, this.Y, this.Width, this.Height);
		}
	}
}
