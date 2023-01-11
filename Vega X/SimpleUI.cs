using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyExploits;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000D RID: 13
	public partial class SimpleUI : Form
	{
		// Token: 0x06000207 RID: 519 RVA: 0x000024AD File Offset: 0x000006AD
		public SimpleUI()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002094 File Offset: 0x00000294
		private void button10_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000024DB File Offset: 0x000006DB
		private void button5_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00026984 File Offset: 0x00024B84
		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000024EA File Offset: 0x000006EA
		private void button3_Click(object sender, EventArgs e)
		{
			this.module.ExecuteScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002504 File Offset: 0x00000704
		private void button4_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Clear();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002513 File Offset: 0x00000713
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000269D0 File Offset: 0x00024BD0
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000209F File Offset: 0x0000029F
		private void SimpleUI_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_MouseUp(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000269D0 File Offset: 0x00024BD0
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002513 File Offset: 0x00000713
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00026A34 File Offset: 0x00024C34
		private void button6_Click(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002087 File Offset: 0x00000287
		private void fastColoredTextBox1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000225 RID: 549
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000226 RID: 550
		private Module module = new Module();

		// Token: 0x04000227 RID: 551
		private Point lastPoint;
	}
}
