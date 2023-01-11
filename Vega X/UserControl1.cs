using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Vega_X
{
	// Token: 0x0200000E RID: 14
	public class UserControl1 : UserControl
	{
		// Token: 0x06000218 RID: 536 RVA: 0x0000252D File Offset: 0x0000072D
		public UserControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002087 File Offset: 0x00000287
		private void fastColoredTextBox1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00027728 File Offset: 0x00025928
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00027768 File Offset: 0x00025968
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UserControl1));
			this.fastColoredTextBox1 = new FastColoredTextBox();
			this.contextMenuStrip1 = new ContextMenuStrip(this.components);
			((ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			base.SuspendLayout();
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
			this.fastColoredTextBox1.AutoScrollMinSize = new Size(507, 126);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BackColor = Color.FromArgb(50, 50, 50);
			this.fastColoredTextBox1.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
			this.fastColoredTextBox1.CharHeight = 14;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.CommentPrefix = "--";
			this.fastColoredTextBox1.Cursor = Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
			this.fastColoredTextBox1.Dock = DockStyle.Fill;
			this.fastColoredTextBox1.Font = new Font("Courier New", 9.5f);
			this.fastColoredTextBox1.ForeColor = Color.White;
			this.fastColoredTextBox1.IndentBackColor = Color.FromArgb(45, 45, 45);
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Language = Language.Lua;
			this.fastColoredTextBox1.LeftBracket = '(';
			this.fastColoredTextBox1.LeftBracket2 = '{';
			this.fastColoredTextBox1.Location = new Point(0, 0);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new Padding(0);
			this.fastColoredTextBox1.RightBracket = ')';
			this.fastColoredTextBox1.RightBracket2 = '}';
			this.fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
			this.fastColoredTextBox1.ServiceColors = (ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.Size = new Size(669, 251);
			this.fastColoredTextBox1.TabIndex = 24;
			this.fastColoredTextBox1.Text = componentResourceManager.GetString("fastColoredTextBox1.Text");
			this.fastColoredTextBox1.Zoom = 100;
			this.fastColoredTextBox1.Load += this.fastColoredTextBox1_Load;
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(61, 4);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.fastColoredTextBox1);
			base.Name = "UserControl1";
			base.Size = new Size(669, 251);
			((ISupportInitialize)this.fastColoredTextBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000234 RID: 564
		private IContainer components = null;

		// Token: 0x04000235 RID: 565
		private FastColoredTextBox fastColoredTextBox1;

		// Token: 0x04000236 RID: 566
		private ContextMenuStrip contextMenuStrip1;
	}
}
