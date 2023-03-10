using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Vega_X
{
	// Token: 0x02000006 RID: 6
	public partial class MiniGame : Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00005198 File Offset: 0x00003398
		public MiniGame()
		{
			this.InitializeComponent();
			base.Paint += this.paintBall;
			this.DoubleBuffered = true;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000051F8 File Offset: 0x000033F8
		private void paintBall(object sender, PaintEventArgs e)
		{
			this.graphics = e.Graphics;
			SolidBrush brush = new SolidBrush(Color.Blue);
			this.graphics.FillEllipse(brush, this.x, this.y, 10, 10);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000523C File Offset: 0x0000343C
		private void MoveBall()
		{
			int num = this.x + this.dx;
			int num2 = this.y + this.dy;
			bool flag = num < -5 || num > base.ClientSize.Width;
			if (flag)
			{
				this.dx = -this.dx;
			}
			bool flag2 = num2 < 0 || num2 > base.ClientSize.Height;
			if (flag2)
			{
				this.dy = -this.dy;
			}
			this.x += this.dx;
			this.y += this.dy;
			base.Invalidate();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000209F File Offset: 0x0000029F
		private void MiniGame_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000021F7 File Offset: 0x000003F7
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.MoveBall();
		}

		// Token: 0x04000031 RID: 49
		private Graphics graphics;

		// Token: 0x04000032 RID: 50
		private int x = 150;

		// Token: 0x04000033 RID: 51
		private int y = 100;

		// Token: 0x04000034 RID: 52
		private int dx = 3;

		// Token: 0x04000035 RID: 53
		private int dy = 2;
	}
}
