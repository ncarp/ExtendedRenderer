using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace Office2007Renderer
{
	static class DisplayInformation
	{
		#region FieldsPrivate

		[ThreadStatic]
		private static string m_strColorScheme;
		[ThreadStatic]
		private static bool m_bIsLunaTheme;
		private const string m_strLunaFileName = "luna.msstyles";
		private static bool m_bIsAeroTheme;
		private const string m_strAeroFileName = "aero.msstyles";

		#endregion

		#region Properties

		public static string ColorScheme
		{
			get { return m_strColorScheme; }
		}

		internal static bool IsLunaTheme
		{
			get { return m_bIsLunaTheme; }
		}

		internal static bool IsAeroTheme
		{
			get { return m_bIsAeroTheme; }
		}

		internal static bool IsTerminalServerSession
		{
			get { return SystemInformation.TerminalServerSession; }
		}
		#endregion

		#region MethodsPrivate

		static DisplayInformation()
		{
			SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(DisplayInformation.OnUserPreferenceChanged);
			DisplayInformation.SetScheme();
		}

		private static void OnUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
		{
			DisplayInformation.SetScheme();
		}

		private static void SetScheme()
		{
			DisplayInformation.m_bIsLunaTheme = false;
			if (VisualStyleRenderer.IsSupported)
			{
				m_strColorScheme = VisualStyleInformation.ColorScheme;

				if (!VisualStyleInformation.IsEnabledByUser)
				{
					return;
				}
				StringBuilder stringBuilder = new StringBuilder(0x200);
				NativeMethods.GetCurrentThemeName(stringBuilder, stringBuilder.Capacity, null, 0, null, 0);
				m_bIsLunaTheme = string.Equals(m_strLunaFileName, Path.GetFileName(stringBuilder.ToString()), StringComparison.InvariantCultureIgnoreCase);
				m_bIsAeroTheme = string.Equals(m_strAeroFileName, Path.GetFileName(stringBuilder.ToString()), StringComparison.InvariantCultureIgnoreCase);
			}
			else
			{
				DisplayInformation.m_strColorScheme = null;
			}
		}
		#endregion

		static class NativeMethods
		{
			[DllImport("uxtheme.dll", CharSet = CharSet.Auto)]
			public static extern int GetCurrentThemeName(StringBuilder pszThemeFileName, int dwMaxNameChars, StringBuilder pszColorBuff, int dwMaxColorChars, StringBuilder pszSizeBuff, int cchMaxSizeChars);
		}
	}
}
