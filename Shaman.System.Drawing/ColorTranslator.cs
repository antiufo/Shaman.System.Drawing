using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace System.Drawing
{
	/// <summary>Translates colors to and from GDI+ <see cref="T:System.Drawing.Color" /> structures. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	public sealed class ColorTranslator
	{
		private const int Win32RedShift = 0;

		private const int Win32GreenShift = 8;

		private const int Win32BlueShift = 16;

		private static Dictionary<string, Color> htmlSysColorTable;

		private ColorTranslator()
		{
		}

		/// <summary>Translates the specified <see cref="T:System.Drawing.Color" /> structure to a Windows color.</summary>
		/// <returns>The Windows color value.</returns>
		/// <param name="c">The <see cref="T:System.Drawing.Color" /> structure to translate. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static int ToWin32(Color c)
		{
			return (int)c.R | (int)c.G << 8 | (int)c.B << 16;
		}
#if !NETSTANDARD20
		/// <summary>Translates the specified <see cref="T:System.Drawing.Color" /> structure to an OLE color.</summary>
		/// <returns>The OLE color value.</returns>
		/// <param name="c">The <see cref="T:System.Drawing.Color" /> structure to translate. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static int ToOle(Color c)
		{
			if (c.IsKnownColor)
			{
				KnownColor knownColor = c.ToKnownColor();
				switch (knownColor)
				{
				case KnownColor.ActiveBorder:
					return -2147483638;
				case KnownColor.ActiveCaption:
					return -2147483646;
				case KnownColor.ActiveCaptionText:
					return -2147483639;
				case KnownColor.AppWorkspace:
					return -2147483636;
				case KnownColor.Control:
					return -2147483633;
				case KnownColor.ControlDark:
					return -2147483632;
				case KnownColor.ControlDarkDark:
					return -2147483627;
				case KnownColor.ControlLight:
					return -2147483626;
				case KnownColor.ControlLightLight:
					return -2147483628;
				case KnownColor.ControlText:
					return -2147483630;
				case KnownColor.Desktop:
					return -2147483647;
				case KnownColor.GrayText:
					return -2147483631;
				case KnownColor.Highlight:
					return -2147483635;
				case KnownColor.HighlightText:
					return -2147483634;
				case KnownColor.HotTrack:
					return -2147483622;
				case KnownColor.InactiveBorder:
					return -2147483637;
				case KnownColor.InactiveCaption:
					return -2147483645;
				case KnownColor.InactiveCaptionText:
					return -2147483629;
				case KnownColor.Info:
					return -2147483624;
				case KnownColor.InfoText:
					return -2147483625;
				case KnownColor.Menu:
					return -2147483644;
				case KnownColor.MenuText:
					return -2147483641;
				case KnownColor.ScrollBar:
					return -2147483648;
				case KnownColor.Window:
					return -2147483643;
				case KnownColor.WindowFrame:
					return -2147483642;
				case KnownColor.WindowText:
					return -2147483640;
				default:
					switch (knownColor)
					{
					case KnownColor.ButtonFace:
						return -2147483633;
					case KnownColor.ButtonHighlight:
						return -2147483628;
					case KnownColor.ButtonShadow:
						return -2147483632;
					case KnownColor.GradientActiveCaption:
						return -2147483621;
					case KnownColor.GradientInactiveCaption:
						return -2147483620;
					case KnownColor.MenuBar:
						return -2147483618;
					case KnownColor.MenuHighlight:
						return -2147483619;
					}
					break;
				}
			}
			return ColorTranslator.ToWin32(c);
		}
        
        /// <summary>Translates an OLE color value to a GDI+ <see cref="T:System.Drawing.Color" /> structure.</summary>
        /// <returns>The <see cref="T:System.Drawing.Color" /> structure that represents the translated OLE color.</returns>
        /// <param name="oleColor">The OLE color to translate. </param>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public static Color FromOle(int oleColor)
		{
			if ((int)((long)oleColor & (long)(-16777216)) == -2147483648 && (oleColor & 16777215) <= 30)
			{
				switch (oleColor)
				{
				case -2147483648:
					return Color.FromKnownColor(KnownColor.ScrollBar);
				case -2147483647:
					return Color.FromKnownColor(KnownColor.Desktop);
				case -2147483646:
					return Color.FromKnownColor(KnownColor.ActiveCaption);
				case -2147483645:
					return Color.FromKnownColor(KnownColor.InactiveCaption);
				case -2147483644:
					return Color.FromKnownColor(KnownColor.Menu);
				case -2147483643:
					return Color.FromKnownColor(KnownColor.Window);
				case -2147483642:
					return Color.FromKnownColor(KnownColor.WindowFrame);
				case -2147483641:
					return Color.FromKnownColor(KnownColor.MenuText);
				case -2147483640:
					return Color.FromKnownColor(KnownColor.WindowText);
				case -2147483639:
					return Color.FromKnownColor(KnownColor.ActiveCaptionText);
				case -2147483638:
					return Color.FromKnownColor(KnownColor.ActiveBorder);
				case -2147483637:
					return Color.FromKnownColor(KnownColor.InactiveBorder);
				case -2147483636:
					return Color.FromKnownColor(KnownColor.AppWorkspace);
				case -2147483635:
					return Color.FromKnownColor(KnownColor.Highlight);
				case -2147483634:
					return Color.FromKnownColor(KnownColor.HighlightText);
				case -2147483633:
					return Color.FromKnownColor(KnownColor.Control);
				case -2147483632:
					return Color.FromKnownColor(KnownColor.ControlDark);
				case -2147483631:
					return Color.FromKnownColor(KnownColor.GrayText);
				case -2147483630:
					return Color.FromKnownColor(KnownColor.ControlText);
				case -2147483629:
					return Color.FromKnownColor(KnownColor.InactiveCaptionText);
				case -2147483628:
					return Color.FromKnownColor(KnownColor.ControlLightLight);
				case -2147483627:
					return Color.FromKnownColor(KnownColor.ControlDarkDark);
				case -2147483626:
					return Color.FromKnownColor(KnownColor.ControlLight);
				case -2147483625:
					return Color.FromKnownColor(KnownColor.InfoText);
				case -2147483624:
					return Color.FromKnownColor(KnownColor.Info);
				case -2147483622:
					return Color.FromKnownColor(KnownColor.HotTrack);
				case -2147483621:
					return Color.FromKnownColor(KnownColor.GradientActiveCaption);
				case -2147483620:
					return Color.FromKnownColor(KnownColor.GradientInactiveCaption);
				case -2147483619:
					return Color.FromKnownColor(KnownColor.MenuHighlight);
				case -2147483618:
					return Color.FromKnownColor(KnownColor.MenuBar);
				}
			}
			return KnownColorTable.ArgbToKnownColor(Color.FromArgb((int)((byte)(oleColor & 255)), (int)((byte)(oleColor >> 8 & 255)), (int)((byte)(oleColor >> 16 & 255))).ToArgb());
		}

		/// <summary>Translates a Windows color value to a GDI+ <see cref="T:System.Drawing.Color" /> structure.</summary>
		/// <returns>The <see cref="T:System.Drawing.Color" /> structure that represents the translated Windows color.</returns>
		/// <param name="win32Color">The Windows color to translate. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static Color FromWin32(int win32Color)
		{
			return ColorTranslator.FromOle(win32Color);
		}
#endif
        /// <summary>Translates an HTML color representation to a GDI+ <see cref="T:System.Drawing.Color" /> structure.</summary>
        /// <returns>The <see cref="T:System.Drawing.Color" /> structure that represents the translated HTML color or <see cref="F:System.Drawing.Color.Empty" /> if <paramref name="htmlColor" /> is null.</returns>
        /// <param name="htmlColor">The string representation of the Html color to translate. </param>
        /// <exception cref="T:System.Exception">
        ///   <paramref name="htmlColor" /> is not a valid HTML color name.</exception>
        /// <filterpriority>1</filterpriority>
        public static Color FromHtml(string htmlColor)
		{
			Color result = Color.Empty;
			if (htmlColor == null || htmlColor.Length == 0)
			{
				return result;
			}
			if (htmlColor[0] == '#' && (htmlColor.Length == 7 || htmlColor.Length == 4))
			{
				if (htmlColor.Length == 7)
				{
					result = Color.FromArgb(Convert.ToInt32(htmlColor.Substring(1, 2), 16), Convert.ToInt32(htmlColor.Substring(3, 2), 16), Convert.ToInt32(htmlColor.Substring(5, 2), 16));
				}
				else
				{
					string arg_9A_0 = char.ToString(htmlColor[1]);
					string text = char.ToString(htmlColor[2]);
					string text2 = char.ToString(htmlColor[3]);
					int arg_C3_0 = Convert.ToInt32(arg_9A_0 + arg_9A_0, 16);
					string expr_A8 = text;
					int arg_C3_1 = Convert.ToInt32(expr_A8 + expr_A8, 16);
					string expr_B6 = text2;
					result = Color.FromArgb(arg_C3_0, arg_C3_1, Convert.ToInt32(expr_B6 + expr_B6, 16));
				}
			}
			if (result.IsEmpty && string.Equals(htmlColor, "LightGrey", StringComparison.OrdinalIgnoreCase))
			{
				result = Color.LightGray;
			}
			if (result.IsEmpty)
			{
				if (ColorTranslator.htmlSysColorTable == null)
				{
					ColorTranslator.InitializeHtmlSysColorTable();
				}
				object obj = ColorTranslator.htmlSysColorTable[htmlColor.ToLower()];
				if (obj != null)
				{
					result = (Color)obj;
				}
			}
			if (result.IsEmpty)
			{
				result = (Color)ColorConverter.Instance.ConvertFrom(CultureInfo.InvariantCulture, htmlColor);
			}
			return result;
		}


		/// <summary>Translates the specified <see cref="T:System.Drawing.Color" /> structure to an HTML string color representation.</summary>
		/// <returns>The string that represents the HTML color.</returns>
		/// <param name="c">The <see cref="T:System.Drawing.Color" /> structure to translate. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string ToHtml(Color c)
		{
			string result = string.Empty;
			if (c.IsEmpty)
			{
				return result;
			}
#if !NETSTANDARD20
			if (c.IsSystemColor)
			{
				KnownColor knownColor = c.ToKnownColor();
				switch (knownColor)
				{
				case KnownColor.ActiveBorder:
					result = "activeborder";
					return result;
				case KnownColor.ActiveCaption:
					break;
				case KnownColor.ActiveCaptionText:
					result = "captiontext";
					return result;
				case KnownColor.AppWorkspace:
					result = "appworkspace";
					return result;
				case KnownColor.Control:
					result = "buttonface";
					return result;
				case KnownColor.ControlDark:
					result = "buttonshadow";
					return result;
				case KnownColor.ControlDarkDark:
					result = "threeddarkshadow";
					return result;
				case KnownColor.ControlLight:
					result = "buttonface";
					return result;
				case KnownColor.ControlLightLight:
					result = "buttonhighlight";
					return result;
				case KnownColor.ControlText:
					result = "buttontext";
					return result;
				case KnownColor.Desktop:
					result = "background";
					return result;
				case KnownColor.GrayText:
					result = "graytext";
					return result;
				case KnownColor.Highlight:
				case KnownColor.HotTrack:
					result = "highlight";
					return result;
				case KnownColor.HighlightText:
					goto IL_12F;
				case KnownColor.InactiveBorder:
					result = "inactiveborder";
					return result;
				case KnownColor.InactiveCaption:
					goto IL_145;
				case KnownColor.InactiveCaptionText:
					result = "inactivecaptiontext";
					return result;
				case KnownColor.Info:
					result = "infobackground";
					return result;
				case KnownColor.InfoText:
					result = "infotext";
					return result;
				case KnownColor.Menu:
					goto IL_171;
				case KnownColor.MenuText:
					result = "menutext";
					return result;
				case KnownColor.ScrollBar:
					result = "scrollbar";
					return result;
				case KnownColor.Window:
					result = "window";
					return result;
				case KnownColor.WindowFrame:
					result = "windowframe";
					return result;
				case KnownColor.WindowText:
					result = "windowtext";
					return result;
				default:
					switch (knownColor)
					{
					case KnownColor.GradientActiveCaption:
						break;
					case KnownColor.GradientInactiveCaption:
						goto IL_145;
					case KnownColor.MenuBar:
						goto IL_171;
					case KnownColor.MenuHighlight:
						goto IL_12F;
					default:
						return result;
					}
					break;
				}
				result = "activecaption";
				return result;
				IL_12F:
				result = "highlighttext";
				return result;
				IL_145:
				result = "inactivecaption";
				return result;
				IL_171:
				result = "menu";
			}
			else 
#endif
            if (c.IsNamedColor)
			{
				if (c == Color.LightGray)
				{
					result = "LightGrey";
				}
				else
				{
					result = c.Name;
				}
			}
			else
			{
				result = "#" + c.R.ToString("X2", null) + c.G.ToString("X2", null) + c.B.ToString("X2", null);
			}
			return result;
		}

		private static void InitializeHtmlSysColorTable()
		{
			ColorTranslator.htmlSysColorTable = new Dictionary<string, Color>(26);
#if !NETSTANDARD20
			ColorTranslator.htmlSysColorTable["activeborder"] = Color.FromKnownColor(KnownColor.ActiveBorder);
			ColorTranslator.htmlSysColorTable["activecaption"] = Color.FromKnownColor(KnownColor.ActiveCaption);
			ColorTranslator.htmlSysColorTable["appworkspace"] = Color.FromKnownColor(KnownColor.AppWorkspace);
			ColorTranslator.htmlSysColorTable["background"] = Color.FromKnownColor(KnownColor.Desktop);
			ColorTranslator.htmlSysColorTable["buttonface"] = Color.FromKnownColor(KnownColor.Control);
			ColorTranslator.htmlSysColorTable["buttonhighlight"] = Color.FromKnownColor(KnownColor.ControlLightLight);
			ColorTranslator.htmlSysColorTable["buttonshadow"] = Color.FromKnownColor(KnownColor.ControlDark);
			ColorTranslator.htmlSysColorTable["buttontext"] = Color.FromKnownColor(KnownColor.ControlText);
			ColorTranslator.htmlSysColorTable["captiontext"] = Color.FromKnownColor(KnownColor.ActiveCaptionText);
			ColorTranslator.htmlSysColorTable["graytext"] = Color.FromKnownColor(KnownColor.GrayText);
			ColorTranslator.htmlSysColorTable["highlight"] = Color.FromKnownColor(KnownColor.Highlight);
			ColorTranslator.htmlSysColorTable["highlighttext"] = Color.FromKnownColor(KnownColor.HighlightText);
			ColorTranslator.htmlSysColorTable["inactiveborder"] = Color.FromKnownColor(KnownColor.InactiveBorder);
			ColorTranslator.htmlSysColorTable["inactivecaption"] = Color.FromKnownColor(KnownColor.InactiveCaption);
			ColorTranslator.htmlSysColorTable["inactivecaptiontext"] = Color.FromKnownColor(KnownColor.InactiveCaptionText);
			ColorTranslator.htmlSysColorTable["infobackground"] = Color.FromKnownColor(KnownColor.Info);
			ColorTranslator.htmlSysColorTable["infotext"] = Color.FromKnownColor(KnownColor.InfoText);
			ColorTranslator.htmlSysColorTable["menu"] = Color.FromKnownColor(KnownColor.Menu);
			ColorTranslator.htmlSysColorTable["menutext"] = Color.FromKnownColor(KnownColor.MenuText);
			ColorTranslator.htmlSysColorTable["scrollbar"] = Color.FromKnownColor(KnownColor.ScrollBar);
			ColorTranslator.htmlSysColorTable["threeddarkshadow"] = Color.FromKnownColor(KnownColor.ControlDarkDark);
			ColorTranslator.htmlSysColorTable["threedface"] = Color.FromKnownColor(KnownColor.Control);
			ColorTranslator.htmlSysColorTable["threedhighlight"] = Color.FromKnownColor(KnownColor.ControlLight);
			ColorTranslator.htmlSysColorTable["threedlightshadow"] = Color.FromKnownColor(KnownColor.ControlLightLight);
			ColorTranslator.htmlSysColorTable["window"] = Color.FromKnownColor(KnownColor.Window);
			ColorTranslator.htmlSysColorTable["windowframe"] = Color.FromKnownColor(KnownColor.WindowFrame);
			ColorTranslator.htmlSysColorTable["windowtext"] = Color.FromKnownColor(KnownColor.WindowText);
#endif
		}
	}
}
