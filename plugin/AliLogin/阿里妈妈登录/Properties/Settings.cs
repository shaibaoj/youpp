using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace 阿里妈妈登录.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings settings_0;

		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		static Settings()
		{
			Settings.settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
		}

		public Settings()
		{
		}
	}
}