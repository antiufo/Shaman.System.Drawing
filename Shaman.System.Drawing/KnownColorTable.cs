using System;

namespace System.Drawing
{
	internal static class KnownColorTable
	{
		private static int[] colorTable;

		private static string[] colorNameTable;

		private const int AlphaShift = 24;

		private const int RedShift = 16;

		private const int GreenShift = 8;

		private const int BlueShift = 0;

		private const int Win32RedShift = 0;

		private const int Win32GreenShift = 8;

		private const int Win32BlueShift = 16;

#if !NETSTANDARD20
		public static Color ArgbToKnownColor(int targetARGB)
		{
			KnownColorTable.EnsureColorTable();
			for (int i = 0; i < KnownColorTable.colorTable.Length; i++)
			{
				if (KnownColorTable.colorTable[i] == targetARGB)
				{
					Color result = Color.FromKnownColor((KnownColor)i);
					if (!result.IsSystemColor)
					{
						return result;
					}
				}
			}
			return Color.FromArgb(targetARGB);
		}
#endif
		private static void EnsureColorTable()
		{
			if (KnownColorTable.colorTable == null)
			{
				KnownColorTable.InitColorTable();
			}
		}

		private static void InitColorTable()
		{
			int[] arg_1B_0 = new int[175];
			KnownColorTable.UpdateSystemColors(arg_1B_0);
			arg_1B_0[27] = 16777215;
			arg_1B_0[28] = -984833;
			arg_1B_0[29] = -332841;
			arg_1B_0[30] = -16711681;
			arg_1B_0[31] = -8388652;
			arg_1B_0[32] = -983041;
			arg_1B_0[33] = -657956;
			arg_1B_0[34] = -6972;
			arg_1B_0[35] = -16777216;
			arg_1B_0[36] = -5171;
			arg_1B_0[37] = -16776961;
			arg_1B_0[38] = -7722014;
			arg_1B_0[39] = -5952982;
			arg_1B_0[40] = -2180985;
			arg_1B_0[41] = -10510688;
			arg_1B_0[42] = -8388864;
			arg_1B_0[43] = -2987746;
			arg_1B_0[44] = -32944;
			arg_1B_0[45] = -10185235;
			arg_1B_0[46] = -1828;
			arg_1B_0[47] = -2354116;
			arg_1B_0[48] = -16711681;
			arg_1B_0[49] = -16777077;
			arg_1B_0[50] = -16741493;
			arg_1B_0[51] = -4684277;
			arg_1B_0[52] = -5658199;
			arg_1B_0[53] = -16751616;
			arg_1B_0[54] = -4343957;
			arg_1B_0[55] = -7667573;
			arg_1B_0[56] = -11179217;
			arg_1B_0[57] = -29696;
			arg_1B_0[58] = -6737204;
			arg_1B_0[59] = -7667712;
			arg_1B_0[60] = -1468806;
			arg_1B_0[61] = -7357301;
			arg_1B_0[62] = -12042869;
			arg_1B_0[63] = -13676721;
			arg_1B_0[64] = -16724271;
			arg_1B_0[65] = -7077677;
			arg_1B_0[66] = -60269;
			arg_1B_0[67] = -16728065;
			arg_1B_0[68] = -9868951;
			arg_1B_0[69] = -14774017;
			arg_1B_0[70] = -5103070;
			arg_1B_0[71] = -1296;
			arg_1B_0[72] = -14513374;
			arg_1B_0[73] = -65281;
			arg_1B_0[74] = -2302756;
			arg_1B_0[75] = -460545;
			arg_1B_0[76] = -10496;
			arg_1B_0[77] = -2448096;
			arg_1B_0[78] = -8355712;
			arg_1B_0[79] = -16744448;
			arg_1B_0[80] = -5374161;
			arg_1B_0[81] = -983056;
			arg_1B_0[82] = -38476;
			arg_1B_0[83] = -3318692;
			arg_1B_0[84] = -11861886;
			arg_1B_0[85] = -16;
			arg_1B_0[86] = -989556;
			arg_1B_0[87] = -1644806;
			arg_1B_0[88] = -3851;
			arg_1B_0[89] = -8586240;
			arg_1B_0[90] = -1331;
			arg_1B_0[91] = -5383962;
			arg_1B_0[92] = -1015680;
			arg_1B_0[93] = -2031617;
			arg_1B_0[94] = -329006;
			arg_1B_0[95] = -2894893;
			arg_1B_0[96] = -7278960;
			arg_1B_0[97] = -18751;
			arg_1B_0[98] = -24454;
			arg_1B_0[99] = -14634326;
			arg_1B_0[100] = -7876870;
			arg_1B_0[101] = -8943463;
			arg_1B_0[102] = -5192482;
			arg_1B_0[103] = -32;
			arg_1B_0[104] = -16711936;
			arg_1B_0[105] = -13447886;
			arg_1B_0[106] = -331546;
			arg_1B_0[107] = -65281;
			arg_1B_0[108] = -8388608;
			arg_1B_0[109] = -10039894;
			arg_1B_0[110] = -16777011;
			arg_1B_0[111] = -4565549;
			arg_1B_0[112] = -7114533;
			arg_1B_0[113] = -12799119;
			arg_1B_0[114] = -8689426;
			arg_1B_0[115] = -16713062;
			arg_1B_0[116] = -12004916;
			arg_1B_0[117] = -3730043;
			arg_1B_0[118] = -15132304;
			arg_1B_0[119] = -655366;
			arg_1B_0[120] = -6943;
			arg_1B_0[121] = -6987;
			arg_1B_0[122] = -8531;
			arg_1B_0[123] = -16777088;
			arg_1B_0[124] = -133658;
			arg_1B_0[125] = -8355840;
			arg_1B_0[126] = -9728477;
			arg_1B_0[127] = -23296;
			arg_1B_0[128] = -47872;
			arg_1B_0[129] = -2461482;
			arg_1B_0[130] = -1120086;
			arg_1B_0[131] = -6751336;
			arg_1B_0[132] = -5247250;
			arg_1B_0[133] = -2396013;
			arg_1B_0[134] = -4139;
			arg_1B_0[135] = -9543;
			arg_1B_0[136] = -3308225;
			arg_1B_0[137] = -16181;
			arg_1B_0[138] = -2252579;
			arg_1B_0[139] = -5185306;
			arg_1B_0[140] = -8388480;
			arg_1B_0[141] = -65536;
			arg_1B_0[142] = -4419697;
			arg_1B_0[143] = -12490271;
			arg_1B_0[144] = -7650029;
			arg_1B_0[145] = -360334;
			arg_1B_0[146] = -744352;
			arg_1B_0[147] = -13726889;
			arg_1B_0[148] = -2578;
			arg_1B_0[149] = -6270419;
			arg_1B_0[150] = -4144960;
			arg_1B_0[151] = -7876885;
			arg_1B_0[152] = -9807155;
			arg_1B_0[153] = -9404272;
			arg_1B_0[154] = -1286;
			arg_1B_0[155] = -16711809;
			arg_1B_0[156] = -12156236;
			arg_1B_0[157] = -2968436;
			arg_1B_0[158] = -16744320;
			arg_1B_0[159] = -2572328;
			arg_1B_0[160] = -40121;
			arg_1B_0[161] = -12525360;
			arg_1B_0[162] = -1146130;
			arg_1B_0[163] = -663885;
			arg_1B_0[164] = -1;
			arg_1B_0[165] = -657931;
			arg_1B_0[166] = -256;
			arg_1B_0[167] = -6632142;
			KnownColorTable.colorTable = arg_1B_0;
		}

		private static void EnsureColorNameTable()
		{
			if (KnownColorTable.colorNameTable == null)
			{
				KnownColorTable.InitColorNameTable();
			}
		}

		private static void InitColorNameTable()
		{
			string[] expr_0A = new string[175];
			expr_0A[1] = "ActiveBorder";
			expr_0A[2] = "ActiveCaption";
			expr_0A[3] = "ActiveCaptionText";
			expr_0A[4] = "AppWorkspace";
			expr_0A[168] = "ButtonFace";
			expr_0A[169] = "ButtonHighlight";
			expr_0A[170] = "ButtonShadow";
			expr_0A[5] = "Control";
			expr_0A[6] = "ControlDark";
			expr_0A[7] = "ControlDarkDark";
			expr_0A[8] = "ControlLight";
			expr_0A[9] = "ControlLightLight";
			expr_0A[10] = "ControlText";
			expr_0A[11] = "Desktop";
			expr_0A[171] = "GradientActiveCaption";
			expr_0A[172] = "GradientInactiveCaption";
			expr_0A[12] = "GrayText";
			expr_0A[13] = "Highlight";
			expr_0A[14] = "HighlightText";
			expr_0A[15] = "HotTrack";
			expr_0A[16] = "InactiveBorder";
			expr_0A[17] = "InactiveCaption";
			expr_0A[18] = "InactiveCaptionText";
			expr_0A[19] = "Info";
			expr_0A[20] = "InfoText";
			expr_0A[21] = "Menu";
			expr_0A[173] = "MenuBar";
			expr_0A[174] = "MenuHighlight";
			expr_0A[22] = "MenuText";
			expr_0A[23] = "ScrollBar";
			expr_0A[24] = "Window";
			expr_0A[25] = "WindowFrame";
			expr_0A[26] = "WindowText";
			expr_0A[27] = "Transparent";
			expr_0A[28] = "AliceBlue";
			expr_0A[29] = "AntiqueWhite";
			expr_0A[30] = "Aqua";
			expr_0A[31] = "Aquamarine";
			expr_0A[32] = "Azure";
			expr_0A[33] = "Beige";
			expr_0A[34] = "Bisque";
			expr_0A[35] = "Black";
			expr_0A[36] = "BlanchedAlmond";
			expr_0A[37] = "Blue";
			expr_0A[38] = "BlueViolet";
			expr_0A[39] = "Brown";
			expr_0A[40] = "BurlyWood";
			expr_0A[41] = "CadetBlue";
			expr_0A[42] = "Chartreuse";
			expr_0A[43] = "Chocolate";
			expr_0A[44] = "Coral";
			expr_0A[45] = "CornflowerBlue";
			expr_0A[46] = "Cornsilk";
			expr_0A[47] = "Crimson";
			expr_0A[48] = "Cyan";
			expr_0A[49] = "DarkBlue";
			expr_0A[50] = "DarkCyan";
			expr_0A[51] = "DarkGoldenrod";
			expr_0A[52] = "DarkGray";
			expr_0A[53] = "DarkGreen";
			expr_0A[54] = "DarkKhaki";
			expr_0A[55] = "DarkMagenta";
			expr_0A[56] = "DarkOliveGreen";
			expr_0A[57] = "DarkOrange";
			expr_0A[58] = "DarkOrchid";
			expr_0A[59] = "DarkRed";
			expr_0A[60] = "DarkSalmon";
			expr_0A[61] = "DarkSeaGreen";
			expr_0A[62] = "DarkSlateBlue";
			expr_0A[63] = "DarkSlateGray";
			expr_0A[64] = "DarkTurquoise";
			expr_0A[65] = "DarkViolet";
			expr_0A[66] = "DeepPink";
			expr_0A[67] = "DeepSkyBlue";
			expr_0A[68] = "DimGray";
			expr_0A[69] = "DodgerBlue";
			expr_0A[70] = "Firebrick";
			expr_0A[71] = "FloralWhite";
			expr_0A[72] = "ForestGreen";
			expr_0A[73] = "Fuchsia";
			expr_0A[74] = "Gainsboro";
			expr_0A[75] = "GhostWhite";
			expr_0A[76] = "Gold";
			expr_0A[77] = "Goldenrod";
			expr_0A[78] = "Gray";
			expr_0A[79] = "Green";
			expr_0A[80] = "GreenYellow";
			expr_0A[81] = "Honeydew";
			expr_0A[82] = "HotPink";
			expr_0A[83] = "IndianRed";
			expr_0A[84] = "Indigo";
			expr_0A[85] = "Ivory";
			expr_0A[86] = "Khaki";
			expr_0A[87] = "Lavender";
			expr_0A[88] = "LavenderBlush";
			expr_0A[89] = "LawnGreen";
			expr_0A[90] = "LemonChiffon";
			expr_0A[91] = "LightBlue";
			expr_0A[92] = "LightCoral";
			expr_0A[93] = "LightCyan";
			expr_0A[94] = "LightGoldenrodYellow";
			expr_0A[95] = "LightGray";
			expr_0A[96] = "LightGreen";
			expr_0A[97] = "LightPink";
			expr_0A[98] = "LightSalmon";
			expr_0A[99] = "LightSeaGreen";
			expr_0A[100] = "LightSkyBlue";
			expr_0A[101] = "LightSlateGray";
			expr_0A[102] = "LightSteelBlue";
			expr_0A[103] = "LightYellow";
			expr_0A[104] = "Lime";
			expr_0A[105] = "LimeGreen";
			expr_0A[106] = "Linen";
			expr_0A[107] = "Magenta";
			expr_0A[108] = "Maroon";
			expr_0A[109] = "MediumAquamarine";
			expr_0A[110] = "MediumBlue";
			expr_0A[111] = "MediumOrchid";
			expr_0A[112] = "MediumPurple";
			expr_0A[113] = "MediumSeaGreen";
			expr_0A[114] = "MediumSlateBlue";
			expr_0A[115] = "MediumSpringGreen";
			expr_0A[116] = "MediumTurquoise";
			expr_0A[117] = "MediumVioletRed";
			expr_0A[118] = "MidnightBlue";
			expr_0A[119] = "MintCream";
			expr_0A[120] = "MistyRose";
			expr_0A[121] = "Moccasin";
			expr_0A[122] = "NavajoWhite";
			expr_0A[123] = "Navy";
			expr_0A[124] = "OldLace";
			expr_0A[125] = "Olive";
			expr_0A[126] = "OliveDrab";
			expr_0A[127] = "Orange";
			expr_0A[128] = "OrangeRed";
			expr_0A[129] = "Orchid";
			expr_0A[130] = "PaleGoldenrod";
			expr_0A[131] = "PaleGreen";
			expr_0A[132] = "PaleTurquoise";
			expr_0A[133] = "PaleVioletRed";
			expr_0A[134] = "PapayaWhip";
			expr_0A[135] = "PeachPuff";
			expr_0A[136] = "Peru";
			expr_0A[137] = "Pink";
			expr_0A[138] = "Plum";
			expr_0A[139] = "PowderBlue";
			expr_0A[140] = "Purple";
			expr_0A[141] = "Red";
			expr_0A[142] = "RosyBrown";
			expr_0A[143] = "RoyalBlue";
			expr_0A[144] = "SaddleBrown";
			expr_0A[145] = "Salmon";
			expr_0A[146] = "SandyBrown";
			expr_0A[147] = "SeaGreen";
			expr_0A[148] = "SeaShell";
			expr_0A[149] = "Sienna";
			expr_0A[150] = "Silver";
			expr_0A[151] = "SkyBlue";
			expr_0A[152] = "SlateBlue";
			expr_0A[153] = "SlateGray";
			expr_0A[154] = "Snow";
			expr_0A[155] = "SpringGreen";
			expr_0A[156] = "SteelBlue";
			expr_0A[157] = "Tan";
			expr_0A[158] = "Teal";
			expr_0A[159] = "Thistle";
			expr_0A[160] = "Tomato";
			expr_0A[161] = "Turquoise";
			expr_0A[162] = "Violet";
			expr_0A[163] = "Wheat";
			expr_0A[164] = "White";
			expr_0A[165] = "WhiteSmoke";
			expr_0A[166] = "Yellow";
			expr_0A[167] = "YellowGreen";
			KnownColorTable.colorNameTable = expr_0A;
		}

		public static int KnownColorToArgb(KnownColor color)
		{
			KnownColorTable.EnsureColorTable();
			if (color <= KnownColor.MenuHighlight)
			{
				return KnownColorTable.colorTable[(int)color];
			}
			return 0;
		}

		public static string KnownColorToName(KnownColor color)
		{
			KnownColorTable.EnsureColorNameTable();
			if (color <= KnownColor.MenuHighlight)
			{
				return KnownColorTable.colorNameTable[(int)color];
			}
			return null;
		}

		private static int SystemColorToArgb(int index)
		{
            return DefaultSystemColors[index];
		}
        private static int[] DefaultSystemColors = new int[] {
            13158600,
0,
13743257,
14405055,
15790320,
16777215,
6579300,
0,
0,
0,
11842740,
16578548,
11250603,
16750899,
16777215,
15790320,
10526880,
7171437,
0,
0,
16777215,
6908265,
14935011,
0,
14811135,
0,
13395456,
15389113,
15918295,
16750899,
15790320,
        };

		private static int Encode(int alpha, int red, int green, int blue)
		{
			return red << 16 | green << 8 | blue | alpha << 24;
		}

		private static int FromWin32Value(int value)
		{
			return KnownColorTable.Encode(255, value & 255, value >> 8 & 255, value >> 16 & 255);
		}


		private static void UpdateSystemColors(int[] colorTable)
		{
			colorTable[1] = KnownColorTable.SystemColorToArgb(10);
			colorTable[2] = KnownColorTable.SystemColorToArgb(2);
			colorTable[3] = KnownColorTable.SystemColorToArgb(9);
			colorTable[4] = KnownColorTable.SystemColorToArgb(12);
			colorTable[168] = KnownColorTable.SystemColorToArgb(15);
			colorTable[169] = KnownColorTable.SystemColorToArgb(20);
			colorTable[170] = KnownColorTable.SystemColorToArgb(16);
			colorTable[5] = KnownColorTable.SystemColorToArgb(15);
			colorTable[6] = KnownColorTable.SystemColorToArgb(16);
			colorTable[7] = KnownColorTable.SystemColorToArgb(21);
			colorTable[8] = KnownColorTable.SystemColorToArgb(22);
			colorTable[9] = KnownColorTable.SystemColorToArgb(20);
			colorTable[10] = KnownColorTable.SystemColorToArgb(18);
			colorTable[11] = KnownColorTable.SystemColorToArgb(1);
			colorTable[171] = KnownColorTable.SystemColorToArgb(27);
			colorTable[172] = KnownColorTable.SystemColorToArgb(28);
			colorTable[12] = KnownColorTable.SystemColorToArgb(17);
			colorTable[13] = KnownColorTable.SystemColorToArgb(13);
			colorTable[14] = KnownColorTable.SystemColorToArgb(14);
			colorTable[15] = KnownColorTable.SystemColorToArgb(26);
			colorTable[16] = KnownColorTable.SystemColorToArgb(11);
			colorTable[17] = KnownColorTable.SystemColorToArgb(3);
			colorTable[18] = KnownColorTable.SystemColorToArgb(19);
			colorTable[19] = KnownColorTable.SystemColorToArgb(24);
			colorTable[20] = KnownColorTable.SystemColorToArgb(23);
			colorTable[21] = KnownColorTable.SystemColorToArgb(4);
			colorTable[173] = KnownColorTable.SystemColorToArgb(30);
			colorTable[174] = KnownColorTable.SystemColorToArgb(29);
			colorTable[22] = KnownColorTable.SystemColorToArgb(7);
			colorTable[23] = KnownColorTable.SystemColorToArgb(0);
			colorTable[24] = KnownColorTable.SystemColorToArgb(5);
			colorTable[25] = KnownColorTable.SystemColorToArgb(6);
			colorTable[26] = KnownColorTable.SystemColorToArgb(8);
		}
	}
}
