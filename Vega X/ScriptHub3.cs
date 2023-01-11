using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000B RID: 11
	public partial class ScriptHub3 : Form
	{
		// Token: 0x06000176 RID: 374 RVA: 0x000023D6 File Offset: 0x000005D6
		public ScriptHub3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000209F File Offset: 0x0000029F
		private void ScriptHub3_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002087 File Offset: 0x00000287
		private void button15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000208A File Offset: 0x0000028A
		private void button9_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000023F9 File Offset: 0x000005F9
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0001C734 File Offset: 0x0001A934
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0001C734 File Offset: 0x0001A934
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000023F9 File Offset: 0x000005F9
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002087 File Offset: 0x00000287
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000A380 File Offset: 0x00008580
		private void button7_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub2 scriptHub = new ScriptHub2();
			scriptHub.Show();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00013DB0 File Offset: 0x00011FB0
		private void button6_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001C798 File Offset: 0x0001A998
		private void button93_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7Dvxr2WN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001C7C8 File Offset: 0x0001A9C8
		private void button92_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/50Fx94Mf");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0001C7F8 File Offset: 0x0001A9F8
		private void button13_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/HxiEuLU0");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001C828 File Offset: 0x0001AA28
		private void button91_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Ki9MdWhp");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001C858 File Offset: 0x0001AA58
		private void button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/jv68vmUE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001C888 File Offset: 0x0001AA88
		private void button4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WzykCZ3f");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001C8B8 File Offset: 0x0001AAB8
		private void button21_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/BJR0qrVt");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
		private void button20_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nXjKtdvk");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001C918 File Offset: 0x0001AB18
		private void button19_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/BunnySalf/Hentai/main/MHEEHUB");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0001C948 File Offset: 0x0001AB48
		private void button18_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/BGu7tyrg");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001C978 File Offset: 0x0001AB78
		private void button12_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
		private void button8_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/y2mXFhC0");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001C9D8 File Offset: 0x0001ABD8
		private void button11_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/g9g9H95T");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001CA08 File Offset: 0x0001AC08
		private void button3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/xd4p5qQN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001CA38 File Offset: 0x0001AC38
		private void button14_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/KmjuMx3m");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001CA68 File Offset: 0x0001AC68
		private void button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/e4KvBszD");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001CA98 File Offset: 0x0001AC98
		private void button10_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://paste.ee/r/I20HH/0");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001CAC8 File Offset: 0x0001ACC8
		private void button28_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/YpEXtdJy");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		private void button29_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/KpaR8t5M");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001CB28 File Offset: 0x0001AD28
		private void button25_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/U29siiLB");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001CB58 File Offset: 0x0001AD58
		private void button24_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/mpZiCUsi");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001CB88 File Offset: 0x0001AD88
		private void button23_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/jDCpKDyV");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001CBB8 File Offset: 0x0001ADB8
		private void button27_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Mq4FTHB1");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001CBE8 File Offset: 0x0001ADE8
		private void button22_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LH2hH9Ru");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001CC18 File Offset: 0x0001AE18
		private void button16_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ArgFS8v5");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001CC48 File Offset: 0x0001AE48
		private void button15_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ygwcfXck");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001CC78 File Offset: 0x0001AE78
		private void button26_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/t6Wg9jkL");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
		private void button31_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://paste.ee/r/qbfoU/0");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		private void button32_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3zUavF4g");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001CD08 File Offset: 0x0001AF08
		private void button33_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/6YQ8YmB4");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001CD38 File Offset: 0x0001AF38
		private void button30_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/JTR8eQQE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001CD68 File Offset: 0x0001AF68
		private void button44_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/F2kjkhip");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001CD98 File Offset: 0x0001AF98
		private void button45_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7xVaeDvQ");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001CDC8 File Offset: 0x0001AFC8
		private void button46_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/8gyLj9mx");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
		private void button43_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/VECiYAqd");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001CE28 File Offset: 0x0001B028
		private void button41_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/uzjXFG6u");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001CE58 File Offset: 0x0001B058
		private void button40_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GsnRLKgE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001CE88 File Offset: 0x0001B088
		private void button39_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/efukZQnW");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001CEB8 File Offset: 0x0001B0B8
		private void button38_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/SatDWeF6");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001CEE8 File Offset: 0x0001B0E8
		private void button37_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/4dJtXW7T");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001CF18 File Offset: 0x0001B118
		private void button36_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/YNkWWyAu");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001CF48 File Offset: 0x0001B148
		private void button35_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/y2yFfXw3");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001CF78 File Offset: 0x0001B178
		private void button34_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/yxv9CbfX");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		private void button42_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LVRZBuES");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002087 File Offset: 0x00000287
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		private void button49_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/W9WFjykQ");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001D008 File Offset: 0x0001B208
		private void button51_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/QzaGGr3B");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001D038 File Offset: 0x0001B238
		private void button48_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/S7g4vVH6");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001D068 File Offset: 0x0001B268
		private void button47_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/cD8eWK4K");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00005440 File Offset: 0x00003640
		private void button50_Click(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "RobloxPlayerBeta";
				bool flag2 = flag;
				if (flag2)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001D098 File Offset: 0x0001B298
		private void button54_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001D098 File Offset: 0x0001B298
		private void button55_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001D098 File Offset: 0x0001B298
		private void button56_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001D098 File Offset: 0x0001B298
		private void button53_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001D098 File Offset: 0x0001B298
		private void button52_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		private void button67_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/hPxNj094");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button66_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001D128 File Offset: 0x0001B328
		private void button65_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Tg7VZkDm");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button62_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button61_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button60_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button59_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button58_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button57_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001D098 File Offset: 0x0001B298
		private void button63_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001D098 File Offset: 0x0001B298
		private void button64_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001D158 File Offset: 0x0001B358
		private void button71_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ZAjeQsqV");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button73_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button70_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button69_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		private void button68_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button72_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button77_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button79_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button76_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button75_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button74_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button83_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button85_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button82_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001D1B8 File Offset: 0x0001B3B8
		private void button81_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/itwzEm75");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0001D188 File Offset: 0x0001B388
		private void button80_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
		private void button78_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GCPUsDzh");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001D218 File Offset: 0x0001B418
		private void button84_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/vY3eMhzX");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001D248 File Offset: 0x0001B448
		private void button89_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/mHHWDbbz");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001D278 File Offset: 0x0001B478
		private void button90_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/VjVT44dh");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		private void button94_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		private void button88_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		private void button87_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		private void button86_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001D2D8 File Offset: 0x0001B4D8
		private void button98_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ycrDXnRU");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001D308 File Offset: 0x0001B508
		private void button100_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WgnTh2Js");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0001D338 File Offset: 0x0001B538
		private void button99_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LRJjFxZE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0001D368 File Offset: 0x0001B568
		private void button97_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/n4HbYaBg");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001D398 File Offset: 0x0001B598
		private void button96_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/0QWEisXk");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0001CBE8 File Offset: 0x0001ADE8
		private void button95_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LH2hH9Ru");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0001D3C8 File Offset: 0x0001B5C8
		private void button114_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/RCYV2fTq");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0001D3F8 File Offset: 0x0001B5F8
		private void button115_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/BSAWq4B7");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001D428 File Offset: 0x0001B628
		private void button116_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/RECwMzDZ");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001D458 File Offset: 0x0001B658
		private void button113_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/sQa24JwK");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0001D488 File Offset: 0x0001B688
		private void button112_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/NuJkRZU8");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		private void button111_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/L75chtXt");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0001D4E8 File Offset: 0x0001B6E8
		private void button110_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/Historia00012/HISTORIAHUB/main/BSS%20FREE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001D518 File Offset: 0x0001B718
		private void button109_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/hhXLbMSj");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001D548 File Offset: 0x0001B748
		private void button108_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/M1ycsJvj");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001D578 File Offset: 0x0001B778
		private void button107_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Jbwm8cHr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
		private void button106_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/2B87nBmn");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001D5D8 File Offset: 0x0001B7D8
		private void button105_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/k5TJREte");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0001D608 File Offset: 0x0001B808
		private void button104_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/i7eC3vXy");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0001D638 File Offset: 0x0001B838
		private void button103_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5cPi1vG2");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001D668 File Offset: 0x0001B868
		private void button102_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5uJMZRGn");
			this.api.SendLuaScript(script);
		}

		// Token: 0x04000184 RID: 388
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000185 RID: 389
		private Point lastPoint;
	}
}
