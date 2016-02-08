using System;

namespace System.Drawing
{
	/// <summary>Each property of the <see cref="T:System.Drawing.SystemColors" /> class is a <see cref="T:System.Drawing.Color" /> structure that is the color of a Windows display element.</summary>
	/// <filterpriority>1</filterpriority>
	public sealed class SystemColors
	{
		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the active window's border.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the active window's border.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ActiveBorder
		{
			get
			{
				return new Color(KnownColor.ActiveBorder);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the background of the active window's title bar.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the active window's title bar.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ActiveCaption
		{
			get
			{
				return new Color(KnownColor.ActiveCaption);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the text in the active window's title bar.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the text in the active window's title bar.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ActiveCaptionText
		{
			get
			{
				return new Color(KnownColor.ActiveCaptionText);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the application workspace. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the application workspace.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color AppWorkspace
		{
			get
			{
				return new Color(KnownColor.AppWorkspace);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the face color of a 3-D element.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the face color of a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ButtonFace
		{
			get
			{
				return new Color(KnownColor.ButtonFace);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the highlight color of a 3-D element. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the highlight color of a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ButtonHighlight
		{
			get
			{
				return new Color(KnownColor.ButtonHighlight);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the shadow color of a 3-D element. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the shadow color of a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ButtonShadow
		{
			get
			{
				return new Color(KnownColor.ButtonShadow);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the face color of a 3-D element.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the face color of a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color Control
		{
			get
			{
				return new Color(KnownColor.Control);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the shadow color of a 3-D element. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the shadow color of a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ControlDark
		{
			get
			{
				return new Color(KnownColor.ControlDark);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the dark shadow color of a 3-D element. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the dark shadow color of a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ControlDarkDark
		{
			get
			{
				return new Color(KnownColor.ControlDarkDark);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the light color of a 3-D element. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the light color of a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ControlLight
		{
			get
			{
				return new Color(KnownColor.ControlLight);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the highlight color of a 3-D element. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the highlight color of a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ControlLightLight
		{
			get
			{
				return new Color(KnownColor.ControlLightLight);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of text in a 3-D element.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of text in a 3-D element.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ControlText
		{
			get
			{
				return new Color(KnownColor.ControlText);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the desktop.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the desktop.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color Desktop
		{
			get
			{
				return new Color(KnownColor.Desktop);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the lightest color in the color gradient of an active window's title bar.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the lightest color in the color gradient of an active window's title bar.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color GradientActiveCaption
		{
			get
			{
				return new Color(KnownColor.GradientActiveCaption);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the lightest color in the color gradient of an inactive window's title bar.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the lightest color in the color gradient of an inactive window's title bar.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color GradientInactiveCaption
		{
			get
			{
				return new Color(KnownColor.GradientInactiveCaption);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of dimmed text. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of dimmed text.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color GrayText
		{
			get
			{
				return new Color(KnownColor.GrayText);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the background of selected items.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the background of selected items.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color Highlight
		{
			get
			{
				return new Color(KnownColor.Highlight);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the text of selected items.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the text of selected items.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color HighlightText
		{
			get
			{
				return new Color(KnownColor.HighlightText);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color used to designate a hot-tracked item. </summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color used to designate a hot-tracked item.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color HotTrack
		{
			get
			{
				return new Color(KnownColor.HotTrack);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of an inactive window's border.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of an inactive window's border.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color InactiveBorder
		{
			get
			{
				return new Color(KnownColor.InactiveBorder);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the background of an inactive window's title bar.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the background of an inactive window's title bar.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color InactiveCaption
		{
			get
			{
				return new Color(KnownColor.InactiveCaption);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the text in an inactive window's title bar.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the text in an inactive window's title bar.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color InactiveCaptionText
		{
			get
			{
				return new Color(KnownColor.InactiveCaptionText);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the background of a ToolTip.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the background of a ToolTip.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color Info
		{
			get
			{
				return new Color(KnownColor.Info);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the text of a ToolTip.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the text of a ToolTip.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color InfoText
		{
			get
			{
				return new Color(KnownColor.InfoText);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of a menu's background.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of a menu's background.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color Menu
		{
			get
			{
				return new Color(KnownColor.Menu);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the background of a menu bar.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the background of a menu bar.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color MenuBar
		{
			get
			{
				return new Color(KnownColor.MenuBar);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color used to highlight menu items when the menu appears as a flat menu.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color used to highlight menu items when the menu appears as a flat menu.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color MenuHighlight
		{
			get
			{
				return new Color(KnownColor.MenuHighlight);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of a menu's text.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of a menu's text.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color MenuText
		{
			get
			{
				return new Color(KnownColor.MenuText);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the background of a scroll bar.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the background of a scroll bar.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color ScrollBar
		{
			get
			{
				return new Color(KnownColor.ScrollBar);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the background in the client area of a window.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the background in the client area of a window.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color Window
		{
			get
			{
				return new Color(KnownColor.Window);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of a window frame.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of a window frame.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color WindowFrame
		{
			get
			{
				return new Color(KnownColor.WindowFrame);
			}
		}

		/// <summary>Gets a <see cref="T:System.Drawing.Color" /> structure that is the color of the text in the client area of a window.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that is the color of the text in the client area of a window.</returns>
		/// <filterpriority>1</filterpriority>
		public static Color WindowText
		{
			get
			{
				return new Color(KnownColor.WindowText);
			}
		}

		private SystemColors()
		{
		}
	}
}
