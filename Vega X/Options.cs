using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using EasyExploits;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x02000007 RID: 7
	public partial class Options : KryptonForm
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002201 File Offset: 0x00000401
		public Options()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005440 File Offset: 0x00003640
		private void button1_Click(object sender, EventArgs e)
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

		// Token: 0x0600003B RID: 59 RVA: 0x0000209F File Offset: 0x0000029F
		private void button7_Click(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000222F File Offset: 0x0000042F
		private void button3_Click(object sender, EventArgs e)
		{
			base.TopMost = false;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005498 File Offset: 0x00003698
		private void button4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://the-shed.dev/scripts/sbp.lua");
			this.module.ExecuteScript(script);
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000054D4 File Offset: 0x000036D4
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000223A File Offset: 0x0000043A
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000223A File Offset: 0x0000043A
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002087 File Offset: 0x00000287
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000054D4 File Offset: 0x000036D4
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005538 File Offset: 0x00003738
		private void button2_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/sVxD31v1");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000209F File Offset: 0x0000029F
		private void Options_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005538 File Offset: 0x00003738
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/sVxD31v1");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005568 File Offset: 0x00003768
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/pQF6rXMm");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005598 File Offset: 0x00003798
		private void button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/SiqScdtW");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002087 File Offset: 0x00000287
		private void button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002087 File Offset: 0x00000287
		private void button11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002254 File Offset: 0x00000454
		private void button8_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://1f03.net/");
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002262 File Offset: 0x00000462
		private void button9_Click(object sender, EventArgs e)
		{
			Process.Start("https://glot.io/snippets/f1tt9okm5w");
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002087 File Offset: 0x00000287
		private void button10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002094 File Offset: 0x00000294
		private void button10_Click_1(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000055C8 File Offset: 0x000037C8
		private void button11_Click_1(object sender, EventArgs e)
		{
			SimpleUI simpleUI = new SimpleUI();
			simpleUI.Show();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000055E4 File Offset: 0x000037E4
		private void button12_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/D4dWs2Vc");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005614 File Offset: 0x00003814
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			VegaX vegaX = Application.OpenForms.OfType<VegaX>().FirstOrDefault<VegaX>();
			bool flag = vegaX != null;
			bool flag2 = flag;
			if (flag2)
			{
				vegaX.TopMost = this.checkBox3.Checked;
				base.TopMost = false;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002087 File Offset: 0x00000287
		private void button3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002270 File Offset: 0x00000470
		private void button7_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCPnCsR8_hY_z7tceY5-0KSA?sub_confirmation=1");
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000565C File Offset: 0x0000385C
		private void button3_Click_2(object sender, EventArgs e)
		{
			MiniGame miniGame = new MiniGame();
			miniGame.Show();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000227E File Offset: 0x0000047E
		private void button13_Click(object sender, EventArgs e)
		{
			Process.Start("https://pastebin.com/raw/cFWfNhmW");
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000208A File Offset: 0x0000028A
		private void button7_Click_2(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000228C File Offset: 0x0000048C
		private void button14_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Kill Roblox: Closes Roblox | Attach Method 2: A Faster Attaching Method | Boost FPS: Limits Graphics | Bypass AC: Bypasses *MOST* Anti-Cheats | TopMost: Puts Vega On Top Of Other Programs | Anti-AFK: Prevents Getting Kicked For Inactivity");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000229A File Offset: 0x0000049A
		private void button16_Click(object sender, EventArgs e)
		{
			Process.Start("https://linktr.ee/1f0");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022A8 File Offset: 0x000004A8
		private void button15_Click(object sender, EventArgs e)
		{
			MessageBox.Show("1_F0", "Vega X | Credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000208A File Offset: 0x0000028A
		private void button7_Click_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000229A File Offset: 0x0000049A
		private void button17_Click(object sender, EventArgs e)
		{
			Process.Start("https://linktr.ee/1f0");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002087 File Offset: 0x00000287
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005678 File Offset: 0x00003878
		private void button6_Click(object sender, EventArgs e)
		{
			FlappyVega flappyVega = new FlappyVega();
			flappyVega.Show();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005694 File Offset: 0x00003894
		private void button18_Click(object sender, EventArgs e)
		{
			AdjustableScripts adjustableScripts = new AdjustableScripts();
			adjustableScripts.Show();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000022BE File Offset: 0x000004BE
		private void button19_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Everything Seems To Be Working Fine.", "Vega X | Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000022D4 File Offset: 0x000004D4
		private void button20_Click(object sender, EventArgs e)
		{
			this.module.ExecuteScript(this.richTextBox2.Text);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022EE File Offset: 0x000004EE
		private void button21_Click(object sender, EventArgs e)
		{
			this.richTextBox2.Clear();
		}

		// Token: 0x04000038 RID: 56
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000039 RID: 57
		private Module module = new Module();

		// Token: 0x0400003A RID: 58
		private Point lastPoint;
	}
}
