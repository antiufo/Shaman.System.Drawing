using System;
using System.Collections.Generic;
using System.Drawing.Internal;

namespace System.Drawing
{
    public class Graphics : IDisposable
    {
        public GraphicsUnit PageUnit;
        private Image image;
        private Graphics(Image b)
        {
            this.image = b;
        }
        public static Graphics FromImage(Image b)
        {
            return new Graphics(b);
        }

        public void Dispose()
        {
        }

        // System.Drawing.Graphics
        /// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" /> and formatted with the specified <see cref="T:System.Drawing.StringFormat" />.</summary>
        /// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified in the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter and the <paramref name="stringFormat" /> parameter.</returns>
        /// <param name="text">String to measure. </param>
        /// <param name="font">
        ///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string. </param>
        /// <param name="width">Maximum width of the string. </param>
        /// <param name="format">
        ///   <see cref="T:System.Drawing.StringFormat" /> that represents formatting information, such as line spacing, for the string. </param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="font" /> is null.</exception>
        /// <filterpriority>1</filterpriority>
        public SizeF MeasureString(string text, Font font, int width, StringFormat format)
        {
            return this.MeasureString(text, font, new SizeF((float)width, 999999f), format);
        }

        // System.Drawing.Graphics
        /// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" /> and formatted with the specified <see cref="T:System.Drawing.StringFormat" />.</summary>
        /// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size of the string, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter and the <paramref name="stringFormat" /> parameter.</returns>
        /// <param name="text">String to measure. </param>
        /// <param name="font">
        ///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string. </param>
        /// <param name="layoutArea">
        ///   <see cref="T:System.Drawing.SizeF" /> structure that specifies the maximum layout area for the text. </param>
        /// <param name="stringFormat">
        ///   <see cref="T:System.Drawing.StringFormat" /> that represents formatting information, such as line spacing, for the string. </param>
        /// <param name="charactersFitted">Number of characters in the string. </param>
        /// <param name="linesFilled">Number of text lines in the string. </param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="font" /> is null.</exception>
        /// <filterpriority>1</filterpriority>
        public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat, out int charactersFitted, out int linesFilled)
        {
            if (text == null || text.Length == 0)
            {
                charactersFitted = 0;
                linesFilled = 0;
                return new SizeF(0f, 0f);
            }
            if (font == null)
            {
                throw new ArgumentNullException("font");
            }
            throw new NotImplementedException();
            //return new SizeF(text.Length, );
            //GPRECTF gPRECTF = new GPRECTF(0f, 0f, layoutArea.Width, layoutArea.Height);
            //GPRECTF gPRECTF2 = default(GPRECTF);
            //int num = SafeNativeMethods.Gdip.GdipMeasureString(new HandleRef(this, this.NativeGraphics), text, text.Length, new HandleRef(font, font.NativeFont), ref gPRECTF, new HandleRef(stringFormat, (stringFormat == null) ? IntPtr.Zero : stringFormat.nativeFormat), ref gPRECTF2, out charactersFitted, out linesFilled);
            //if (num != 0)
            //{
            //    throw SafeNativeMethods.Gdip.StatusException(num);
            //}
            //return gPRECTF2.SizeF;
        }

        // System.Drawing.Graphics
        /// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" /> and formatted with the specified <see cref="T:System.Drawing.StringFormat" />.</summary>
        /// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified by the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter and the <paramref name="stringFormat" /> parameter.</returns>
        /// <param name="text">String to measure. </param>
        /// <param name="font">
        ///   <see cref="T:System.Drawing.Font" /> defines the text format of the string. </param>
        /// <param name="origin">
        ///   <see cref="T:System.Drawing.PointF" /> structure that represents the upper-left corner of the string. </param>
        /// <param name="stringFormat">
        ///   <see cref="T:System.Drawing.StringFormat" /> that represents formatting information, such as line spacing, for the string. </param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="font" /> is null.</exception>
        /// <filterpriority>1</filterpriority>
        public SizeF MeasureString(string text, Font font, PointF origin, StringFormat stringFormat)
        {
            if (text == null || text.Length == 0)
            {
                return new SizeF(0f, 0f);
            }
            if (font == null)
            {
                throw new ArgumentNullException("font");
            }
            GPRECTF gPRECTF = default(GPRECTF);
            GPRECTF gPRECTF2 = default(GPRECTF);
            gPRECTF.X = origin.X;
            gPRECTF.Y = origin.Y;
            gPRECTF.Width = 0f;
            gPRECTF.Height = 0f;
            int num2;
            int num3;
            throw new NotImplementedException();
            //int num = SafeNativeMethods.Gdip.GdipMeasureString(new HandleRef(this, this.NativeGraphics), text, text.Length, new HandleRef(font, font.NativeFont), ref gPRECTF, new HandleRef(stringFormat, (stringFormat == null) ? IntPtr.Zero : stringFormat.nativeFormat), ref gPRECTF2, out num2, out num3);
            //if (num != 0)
            //{
            //    throw SafeNativeMethods.Gdip.StatusException(num);
            //}
            return gPRECTF2.SizeF;
        }

        // System.Drawing.Graphics
        /// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" /> within the specified layout area.</summary>
        /// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified by the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter.</returns>
        /// <param name="text">String to measure. </param>
        /// <param name="font">
        ///   <see cref="T:System.Drawing.Font" /> defines the text format of the string. </param>
        /// <param name="layoutArea">
        ///   <see cref="T:System.Drawing.SizeF" /> structure that specifies the maximum layout area for the text. </param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="font" /> is null.</exception>
        /// <filterpriority>1</filterpriority>
        public SizeF MeasureString(string text, Font font, SizeF layoutArea)
        {
            return this.MeasureString(text, font, layoutArea, null);
        }

        // System.Drawing.Graphics
        /// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" /> and formatted with the specified <see cref="T:System.Drawing.StringFormat" />.</summary>
        /// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified in the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter and the <paramref name="stringFormat" /> parameter.</returns>
        /// <param name="text">String to measure. </param>
        /// <param name="font">
        ///   <see cref="T:System.Drawing.Font" /> defines the text format of the string. </param>
        /// <param name="layoutArea">
        ///   <see cref="T:System.Drawing.SizeF" /> structure that specifies the maximum layout area for the text. </param>
        /// <param name="stringFormat">
        ///   <see cref="T:System.Drawing.StringFormat" /> that represents formatting information, such as line spacing, for the string. </param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="font" /> is null.</exception>
        /// <filterpriority>1</filterpriority>
        public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat)
        {
            if (text == null || text.Length == 0)
            {
                return new SizeF(0f, 0f);
            }
            if (font == null)
            {
                throw new ArgumentNullException("font");
            }
            GPRECTF gPRECTF = new GPRECTF(0f, 0f, layoutArea.Width, layoutArea.Height);
            GPRECTF gPRECTF2 = default(GPRECTF);
            int num2;
            int num3;
            //int num = SafeNativeMethods.Gdip.GdipMeasureString(new HandleRef(this, this.NativeGraphics), text, text.Length, new HandleRef(font, font.NativeFont), ref gPRECTF, new HandleRef(stringFormat, (stringFormat == null) ? IntPtr.Zero : stringFormat.nativeFormat), ref gPRECTF2, out num2, out num3);
            //if (num != 0)
            //{
            //    throw SafeNativeMethods.Gdip.StatusException(num);
            //}
            throw new NotImplementedException();
            return gPRECTF2.SizeF;
        }

        // System.Drawing.Graphics
        /// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" />.</summary>
        /// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified by the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter.</returns>
        /// <param name="text">String to measure. </param>
        /// <param name="font">
        ///   <see cref="T:System.Drawing.Font" /> that defines the text format of the string. </param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="font" /> is null.</exception>
        /// <filterpriority>1</filterpriority>
        public SizeF MeasureString(string text, Font font)
        {
            return this.MeasureString(text, font, new SizeF(0f, 0f));
        }

        // System.Drawing.Graphics
        /// <summary>Measures the specified string when drawn with the specified <see cref="T:System.Drawing.Font" />.</summary>
        /// <returns>This method returns a <see cref="T:System.Drawing.SizeF" /> structure that represents the size, in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property, of the string specified in the <paramref name="text" /> parameter as drawn with the <paramref name="font" /> parameter.</returns>
        /// <param name="text">String to measure. </param>
        /// <param name="font">
        ///   <see cref="T:System.Drawing.Font" /> that defines the format of the string. </param>
        /// <param name="width">Maximum width of the string in pixels. </param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="font" /> is null.</exception>
        /// <filterpriority>1</filterpriority>
        public SizeF MeasureString(string text, Font font, int width)
        {
            return this.MeasureString(text, font, new SizeF((float)width, 999999f));
        }

    }
}
