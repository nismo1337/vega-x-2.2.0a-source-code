using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CircularProgressBar;
using ComponentFactory.Krypton.Toolkit;
using WinFormAnimation;

namespace Vega_X
{
	// Token: 0x02000005 RID: 5
	public partial class Loader : KryptonForm
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000021AC File Offset: 0x000003AC
		public Loader()
		{
			this.InitializeComponent();
			this.pbar.Value = 0;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000021D1 File Offset: 0x000003D1
		private void Loader_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
			this.timer1.Enabled = true;
			this.timer1.Interval = 60;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000048A4 File Offset: 0x00002AA4
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.pbar.PerformStep();
			this.pbar.Text = this.pbar.Value.ToString() + "%";
			bool flag = this.pbar.Value >= 100;
			if (flag)
			{
				this.timer1.Enabled = false;
				this.timer1.Stop();
				base.Hide();
				Thread.Sleep(500);
				VegaX vegaX = new VegaX();
				vegaX.Show();
			}
			bool flag2 = this.pbar.Value >= 65;
			if (flag2)
			{
				this.label3.Visible = true;
				this.label2.Visible = false;
			}
			this.pbar.Value = this.pbar.Value;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002087 File Offset: 0x00000287
		private void progressBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002087 File Offset: 0x00000287
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004988 File Offset: 0x00002B88
		private void button5_Click(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
			this.timer1.Stop();
			base.Hide();
			Thread.Sleep(500);
			VegaX vegaX = new VegaX();
			vegaX.Show();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002087 File Offset: 0x00000287
		private void pbar_Click(object sender, EventArgs e)
		{
		}
	}
}
