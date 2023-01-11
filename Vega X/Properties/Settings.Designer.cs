using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Vega_X.Properties
{
	// Token: 0x02000012 RID: 18
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0002B460 File Offset: 0x00029660
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400027B RID: 635
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
