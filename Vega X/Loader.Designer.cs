namespace Vega_X
{
	// Token: 0x02000005 RID: 5
	public partial class Loader : global::ComponentFactory.Krypton.Toolkit.KryptonForm
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000049D0 File Offset: 0x00002BD0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004A10 File Offset: 0x00002C10
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vega_X.Loader));
			this.label2 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button5 = new global::System.Windows.Forms.Button();
			this.pbar = new global::CircularProgressBar.CircularProgressBar();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(12, 305);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(133, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Loading APIs . . . ";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(90, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(165, 30);
			this.label1.TabIndex = 3;
			this.label1.Text = "Vega X - Loader";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.panel2.BackColor = global::System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel2.BackgroundImage");
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Location = new global::System.Drawing.Point(3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(48, 40);
			this.panel2.TabIndex = 12;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(24, 305);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(97, 21);
			this.label3.TabIndex = 13;
			this.label3.Text = "Opening . . .";
			this.label3.Visible = false;
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button5.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button5.Location = new global::System.Drawing.Point(205, 278);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(139, 48);
			this.button5.TabIndex = 14;
			this.button5.Text = "Skip Loading";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.pbar.AnimationFunction = global::WinFormAnimation.KnownAnimationFunctions.Liner;
			this.pbar.AnimationSpeed = 100;
			this.pbar.BackColor = global::System.Drawing.Color.Transparent;
			this.pbar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 54.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.pbar.ForeColor = global::System.Drawing.Color.White;
			this.pbar.InnerColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.pbar.InnerMargin = 2;
			this.pbar.InnerWidth = -1;
			this.pbar.Location = new global::System.Drawing.Point(64, 55);
			this.pbar.MarqueeAnimationSpeed = 2000;
			this.pbar.Name = "pbar";
			this.pbar.OuterColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.pbar.OuterMargin = -25;
			this.pbar.OuterWidth = 26;
			this.pbar.ProgressColor = global::System.Drawing.Color.Black;
			this.pbar.ProgressWidth = 18;
			this.pbar.SecondaryFont = new global::System.Drawing.Font("Microsoft Sans Serif", 36f);
			this.pbar.Size = new global::System.Drawing.Size(211, 206);
			this.pbar.StartAngle = 270;
			this.pbar.Step = 1;
			this.pbar.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pbar.SubscriptColor = global::System.Drawing.Color.FromArgb(166, 166, 166);
			this.pbar.SubscriptMargin = new global::System.Windows.Forms.Padding(10, -35, 0, 0);
			this.pbar.SubscriptText = "";
			this.pbar.SuperscriptColor = global::System.Drawing.Color.FromArgb(166, 166, 166);
			this.pbar.SuperscriptMargin = new global::System.Windows.Forms.Padding(10, 35, 0, 0);
			this.pbar.SuperscriptText = "";
			this.pbar.TabIndex = 15;
			this.pbar.TextMargin = new global::System.Windows.Forms.Padding(8, 8, 0, 0);
			this.pbar.Value = 50;
			this.pbar.Click += new global::System.EventHandler(this.pbar_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			base.ClientSize = new global::System.Drawing.Size(355, 338);
			base.Controls.Add(this.pbar);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Loader";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.StateCommon.Border.DrawBorders = global::ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.All;
			base.StateCommon.Border.Rounding = 10;
			this.Text = "Loader";
			base.Load += new global::System.EventHandler(this.Loader_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000029 RID: 41
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000030 RID: 48
		private global::CircularProgressBar.CircularProgressBar pbar;
	}
}
