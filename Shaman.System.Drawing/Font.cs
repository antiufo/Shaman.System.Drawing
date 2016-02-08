using System;
using System.Collections.Generic;

namespace System.Drawing
{
    public class Font
    {
        private FontStyle fs;

        public Font(string name, float size, FontStyle fs)
        {
            Name = name;
            Size = size;
            Style = fs;
        }

        public Font(string name, float size)
        {
            Name = name;
            Size = size;
        }

        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public string Name { get; set; }
        public float Size { get; set; }
        public bool Strikeout { get; set; }
        public bool Underline { get; set; }
        public FontStyle Style { get; set; }
    }
}
