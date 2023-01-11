using System;
using System.Windows.Forms;

namespace Vega_X
{
	// Token: 0x02000010 RID: 16
	internal static class Program
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0000287C File Offset: 0x00000A7C
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Loader());
		}
	}
}
