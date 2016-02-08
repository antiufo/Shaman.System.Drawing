using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Linq;

namespace System.Drawing
{
	/// <summary>Converts colors from one data type to another. Access this class through the <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	/// <filterpriority>1</filterpriority>
	internal class ColorConverter
	{
		private class ColorComparer : IComparer
		{
			public int Compare(object left, object right)
			{
				Color color = (Color)left;
				Color color2 = (Color)right;
				return string.Compare(color.Name, color2.Name);
			}
		}

		private static string ColorConstantsLock = "colorConstants";

		private static Dictionary<string, Color> colorConstants;

		private static string SystemColorConstantsLock = "systemColorConstants";

		private static Dictionary<string, Color> systemColorConstants;

        internal static ColorConverter Instance = new ColorConverter();

        private static Dictionary<string, Color> Colors
		{
			get
			{
				if (ColorConverter.colorConstants == null)
                {
                    string colorConstantsLock = ColorConverter.ColorConstantsLock;
                    bool flag = false;
					try
					{
						Monitor.Enter(colorConstantsLock, ref flag);
						if (ColorConverter.colorConstants == null)
						{
							var expr_28 = new Dictionary<string, Color>(StringComparer.OrdinalIgnoreCase);
							ColorConverter.FillConstants(expr_28, typeof(Color));
							ColorConverter.colorConstants = expr_28;
						}
					}
					finally
					{
						if (flag)
						{
							Monitor.Exit(colorConstantsLock);
						}
					}
				}
				return ColorConverter.colorConstants;
			}
		}

		private static Dictionary<string, Color> SystemColors
		{
			get
			{
                string systemColorConstantsLock = ColorConverter.SystemColorConstantsLock;

                if (ColorConverter.systemColorConstants == null)
				{
					bool flag = false;
					try
					{
						Monitor.Enter(systemColorConstantsLock, ref flag);
						if (ColorConverter.systemColorConstants == null)
						{
							var expr_28 = new Dictionary<string, Color>(StringComparer.OrdinalIgnoreCase);
							ColorConverter.FillConstants(expr_28, typeof(SystemColors));
							ColorConverter.systemColorConstants = expr_28;
						}
					}
					finally
					{
						if (flag)
						{
							Monitor.Exit(systemColorConstantsLock);
						}
					}
				}
				return ColorConverter.systemColorConstants;
			}
		}




		internal static object GetNamedColor(string name)
		{
			object obj = ColorConverter.Colors[name];
			if (obj != null)
			{
				return obj;
			}
			return ColorConverter.SystemColors[name];
		}

		/// <summary>Converts the given object to the converter's native type.</summary>
		/// <returns>An <see cref="T:System.Object" /> representing the converted value.</returns>
		/// <param name="context">A <see cref="T:System.ComponentModel.TypeDescriptor" /> that provides a format context. You can use this object to get additional information about the environment from which this converter is being invoked. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to represent the color. </param>
		/// <param name="value">The object to convert. </param>
		/// <exception cref="T:System.ArgumentException">The conversion cannot be performed.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public object ConvertFrom(CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				object obj = null;
				string text2 = text.Trim();
				if (text2.Length == 0)
				{
					obj = Color.Empty;
				}
				else
				{
					obj = ColorConverter.GetNamedColor(text2);
					if (obj == null)
					{
						if (culture == null)
						{
							culture = CultureInfo.CurrentCulture;
						}
						char c = culture.TextInfo.ListSeparator[0];
						bool flag = true;
						
						if (text2.IndexOf(c) == -1)
						{
							if (text2.Length >= 2 && (text2[0] == '\'' || text2[0] == '"'))
							{
								char arg_AC_0 = text2[0];
								string expr_9F = text2;
								if (arg_AC_0 == expr_9F[expr_9F.Length - 1])
								{
									obj = Color.FromName(text2.Substring(1, text2.Length - 2));
									flag = false;
									goto IL_147;
								}
							}
							if ((text2.Length == 7 && text2[0] == '#') || (text2.Length == 8 && (text2.StartsWith("0x") || text2.StartsWith("0X"))) || (text2.Length == 8 && (text2.StartsWith("&h") || text2.StartsWith("&H"))))
							{
								obj = Color.FromArgb(-16777216 | (int)int.Parse(text2, culture));
							}
						}
						IL_147:
						if (obj == null)
						{
							string[] array = text2.Split(new char[]
							{
								c
							});
							int[] array2 = new int[array.Length];
							for (int i = 0; i < array2.Length; i++)
							{
                                array2[i] = int.Parse(array[i], culture);
							}
							switch (array2.Length)
							{
							case 1:
								obj = Color.FromArgb(array2[0]);
								break;
							case 3:
								obj = Color.FromArgb(array2[0], array2[1], array2[2]);
								break;
							case 4:
								obj = Color.FromArgb(array2[0], array2[1], array2[2], array2[3]);
								break;
							}
							flag = true;
						}
						if (obj != null & flag)
						{
							int num = ((Color)obj).ToArgb();
							foreach (Color color in ColorConverter.Colors.Values)
							{
								if (color.ToArgb() == num)
								{
									obj = color;
									break;
								}
							}
						}
					}
					if (obj == null)
					{
						throw new ArgumentException();
					}
				}
				return obj;
			}
            throw new ArgumentException();
        }

		/// <summary>Converts the specified object to another type. </summary>
		/// <returns>An <see cref="T:System.Object" /> representing the converted value.</returns>
		/// <param name="context">A formatter context. Use this object to extract additional information about the environment from which this converter is being invoked. Always check whether this value is null. Also, properties on the context object may return null. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to represent the color. </param>
		/// <param name="value">The object to convert. </param>
		/// <param name="destinationType">The type to convert the object to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destinationtype" /> is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public object ConvertTo(CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (value is Color)
			{
				if (destinationType == typeof(string))
				{
					Color left = (Color)value;
					if (left == Color.Empty)
					{
						return string.Empty;
					}
					if (left.IsKnownColor)
					{
						return left.Name;
					}
					if (left.IsNamedColor)
					{
						return "'" + left.Name + "'";
					}
					if (culture == null)
					{
						culture = CultureInfo.CurrentCulture;
					}
					string arg_13D_0 = culture.TextInfo.ListSeparator + " ";
					
					int num = 0;
					string[] array;
					if (left.A < 255)
					{
						array = new string[4];
                        array[num++] = left.A.ToString(culture);
					}
					else
					{
						array = new string[3];
					}
                    array[num++] = left.R.ToString(culture);
					array[num++] = left.G.ToString(culture);
                    array[num++] = left.B.ToString(culture);
                    return string.Join(arg_13D_0, array);
				}
				
			}
            throw new ArgumentException();
        }

		private static void FillConstants(Dictionary<string, Color> hash, Type enumType)
		{
            PropertyInfo[] properties = enumType.GetTypeInfo().DeclaredProperties.ToArray();
            
            for (int i = 0; i < properties.Length; i++)
			{
				PropertyInfo propertyInfo = properties[i];
				if (propertyInfo.PropertyType == typeof(Color))
				{
                    MethodInfo getMethod = propertyInfo.GetMethod;
                    if (getMethod != null)
                    {
                        hash[propertyInfo.Name] = (Color)propertyInfo.GetValue(null);
					}
				}
			}
		}

	}
}
