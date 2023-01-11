using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using EasyExploits;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x02000009 RID: 9
	public partial class ScriptHub : KryptonForm
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00002320 File Offset: 0x00000520
		public ScriptHub()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000791C File Offset: 0x00005B1C
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000234E File Offset: 0x0000054E
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000791C File Offset: 0x00005B1C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000234E File Offset: 0x0000054E
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002087 File Offset: 0x00000287
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002368 File Offset: 0x00000568
		private void ScriptHub_Load_1(object sender, EventArgs e)
		{
			base.TopMost = true;
			this.EXButton.Checked = true;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007980 File Offset: 0x00005B80
		private void button10_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nmQp3H5S");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007A00 File Offset: 0x00005C00
		private void button11_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/AA1sEPj9");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/AA1sEPj9");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007A80 File Offset: 0x00005C80
		private void button17_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/hzhXZCDp");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/hzhXZCDp");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00007B00 File Offset: 0x00005D00
		private void button5_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00007B80 File Offset: 0x00005D80
		private void button15_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/WsTFs9cM");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/WsTFs9cM");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007C00 File Offset: 0x00005E00
		private void button18_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/LOOF-sys/Roblox-Shit/main/SharkBite.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/LOOF-sys/Roblox-Shit/main/SharkBite.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007C80 File Offset: 0x00005E80
		private void button13_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/QaNEaCWQ");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/QaNEaCWQ");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007D00 File Offset: 0x00005F00
		private void button9_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/cjZny0yM");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/cjZny0yM");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00007D80 File Offset: 0x00005F80
		private void button7_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/7xEvhGPt");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/7xEvhGPt");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007E00 File Offset: 0x00006000
		private void button16_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/1f0yt/community/master/imbvc");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/1f0yt/community/master/imbvc");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007E80 File Offset: 0x00006080
		private void button12_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/wwQRd376");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/wwQRd376");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007F00 File Offset: 0x00006100
		private void button8_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/E4xJyXVT");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/E4xJyXVT");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007F80 File Offset: 0x00006180
		private void button14_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/4Jb97VWF");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/4Jb97VWF");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00008000 File Offset: 0x00006200
		private void button4_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/7LHqgGR7");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/7LHqgGR7");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00008080 File Offset: 0x00006280
		private void button3_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/1f0yt/community/master/bbiv");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/1f0yt/community/master/bbiv");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008100 File Offset: 0x00006300
		private void button6_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/RaV9yQPB");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/RaV9yQPB");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002087 File Offset: 0x00000287
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008180 File Offset: 0x00006380
		private void button20_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/fub69UPC");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/fub69UPC");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00008200 File Offset: 0x00006400
		private void button19_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/jGSADZUs");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/jGSADZUs");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00008280 File Offset: 0x00006480
		private void button22_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/wLEJ6YDF");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/wLEJ6YDF");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00008300 File Offset: 0x00006500
		private void button23_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/ubsmRJ0N");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/ubsmRJ0N");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00008380 File Offset: 0x00006580
		private void button24_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/HLVSNhG5");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/HLVSNhG5");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00008400 File Offset: 0x00006600
		private void button21_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/WBux8Zti");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/WBux8Zti");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00008480 File Offset: 0x00006680
		private void button28_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/uJFSy4UM");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/uJFSy4UM");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00008500 File Offset: 0x00006700
		private void button30_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/stN7rtkS");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/stN7rtkS");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00008580 File Offset: 0x00006780
		private void button31_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/h2sR0jjk");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/h2sR0jjk");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008600 File Offset: 0x00006800
		private void button35_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/9kRGN3s6");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/9kRGN3s6");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008680 File Offset: 0x00006880
		private void button33_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/dhx6PWjs");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/dhx6PWjs");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008700 File Offset: 0x00006900
		private void button32_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/x5CEvSQD");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/x5CEvSQD");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008780 File Offset: 0x00006980
		private void button29_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/9BV4CmeQ");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/9BV4CmeQ");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00008800 File Offset: 0x00006A00
		private void button34_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00008880 File Offset: 0x00006A80
		private void button27_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/Strikehubv2z/StormSKz/main/All_in_one");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/Strikehubv2z/StormSKz/main/All_in_one");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008900 File Offset: 0x00006B00
		private void button26_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/rD5LM6wa");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/rD5LM6wa");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00008980 File Offset: 0x00006B80
		private void button25_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/Xvh0r8Y4");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/Xvh0r8Y4");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00008A00 File Offset: 0x00006C00
		private void button39_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/qSU9Af6K");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/qSU9Af6K");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002087 File Offset: 0x00000287
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00008A80 File Offset: 0x00006C80
		private void button40_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/8v5ke3rj");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/8v5ke3rj");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00008B00 File Offset: 0x00006D00
		private void button39_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/632UHBY3");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/632UHBY3");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008B80 File Offset: 0x00006D80
		private void button38_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/PLpP0hv4");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/PLpP0hv4");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00007980 File Offset: 0x00005B80
		private void button36_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nmQp3H5S");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00008C00 File Offset: 0x00006E00
		private void button37_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/cGvhHsmj");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/cGvhHsmj");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008C80 File Offset: 0x00006E80
		private void button41_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/Cl1ckerr/autonigga/main/autofarm.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/Cl1ckerr/autonigga/main/autofarm.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002380 File Offset: 0x00000580
		private void button43_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Patched For Now");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008D00 File Offset: 0x00006F00
		private void button42_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/acsu123/HOHO_H/main/Loading_UI");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/acsu123/HOHO_H/main/Loading_UI");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008D80 File Offset: 0x00006F80
		private void button44_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/AcfRR2rY");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/AcfRR2rY");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008E00 File Offset: 0x00007000
		private void button45_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/Fi6DhyZ5");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/Fi6DhyZ5");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00008D00 File Offset: 0x00006F00
		private void button47_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/acsu123/HOHO_H/main/Loading_UI");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/acsu123/HOHO_H/main/Loading_UI");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00008E80 File Offset: 0x00007080
		private void button48_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/ZTwaS4r6");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/ZTwaS4r6");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00008D00 File Offset: 0x00006F00
		private void button46_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/acsu123/HOHO_H/main/Loading_UI");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/acsu123/HOHO_H/main/Loading_UI");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00008F00 File Offset: 0x00007100
		private void button49_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/destylol/masterhubv311/itachi/Main.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/destylol/masterhubv311/itachi/Main.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00008F80 File Offset: 0x00007180
		private void button50_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/ACaMSi5E");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/ACaMSi5E");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00009000 File Offset: 0x00007200
		private void button38_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/jDimL2uE");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/jDimL2uE");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00009080 File Offset: 0x00007280
		private void button58_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/mmSYPxWr");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/mmSYPxWr");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007980 File Offset: 0x00005B80
		private void button59_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nmQp3H5S");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009100 File Offset: 0x00007300
		private void button60_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/eLu8bfa9");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/eLu8bfa9");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002380 File Offset: 0x00000580
		private void button61_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Patched For Now");
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00009180 File Offset: 0x00007380
		private void button62_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/xXa7KEm9");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/xXa7KEm9");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00009200 File Offset: 0x00007400
		private void button56_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/10FCxUjk");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/10FCxUjk");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00009280 File Offset: 0x00007480
		private void button55_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/6DECeJUZ");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/6DECeJUZ");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008F00 File Offset: 0x00007100
		private void button51_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/destylol/masterhubv311/itachi/Main.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/destylol/masterhubv311/itachi/Main.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00009300 File Offset: 0x00007500
		private void button57_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/7Dvxr2WN");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/7Dvxr2WN");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00008800 File Offset: 0x00006A00
		private void button54_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00009380 File Offset: 0x00007580
		private void button52_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/uXxLXsVb");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/uXxLXsVb");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00009400 File Offset: 0x00007600
		private void button53_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/ynGZffAv");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/ynGZffAv");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00009480 File Offset: 0x00007680
		private void button67_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/kz1Et0kG");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/kz1Et0kG");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00007980 File Offset: 0x00005B80
		private void button66_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nmQp3H5S");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00009500 File Offset: 0x00007700
		private void button65_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/LAMKLyMb");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/LAMKLyMb");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00008800 File Offset: 0x00006A00
		private void button64_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008F00 File Offset: 0x00007100
		private void button63_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/destylol/masterhubv311/itachi/Main.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/destylol/masterhubv311/itachi/Main.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002380 File Offset: 0x00000580
		private void button72_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Patched For Now");
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002380 File Offset: 0x00000580
		private void button71_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Patched For Now");
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00009580 File Offset: 0x00007780
		private void button70_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/jaVGYcQQ");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/jaVGYcQQ");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00009600 File Offset: 0x00007800
		private void button69_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/WchTMzDB");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/WchTMzDB");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00009680 File Offset: 0x00007880
		private void button68_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/m7vj2Fvr");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/m7vj2Fvr");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00009700 File Offset: 0x00007900
		private void button73_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/afLQ5vDy");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/afLQ5vDy");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00009780 File Offset: 0x00007980
		private void button77_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/zP2c3Nqv");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/zP2c3Nqv");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00008D00 File Offset: 0x00006F00
		private void button74_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/acsu123/HOHO_H/main/Loading_UI");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/acsu123/HOHO_H/main/Loading_UI");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00009800 File Offset: 0x00007A00
		private void button76_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/KuriWasTaken/MonkeyScripts/main/JailMonkey.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/KuriWasTaken/MonkeyScripts/main/JailMonkey.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00009880 File Offset: 0x00007A80
		private void button75_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/JoshieGemFinder/gubgub/main/beeswaemfree");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/JoshieGemFinder/gubgub/main/beeswaemfree");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00009900 File Offset: 0x00007B00
		private void button81_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/F17Xe560");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/F17Xe560");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00007980 File Offset: 0x00005B80
		private void button80_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nmQp3H5S");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00009980 File Offset: 0x00007B80
		private void button79_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/ftzpeQYz");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/ftzpeQYz");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009A00 File Offset: 0x00007C00
		private void button78_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/Z6X0JY1H");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/Z6X0JY1H");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009A80 File Offset: 0x00007C80
		private void button83_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/fQRenx8j");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/fQRenx8j");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00009B00 File Offset: 0x00007D00
		private void button86_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/uLe9rWfY");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/uLe9rWfY");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00009B80 File Offset: 0x00007D80
		private void button85_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/Zt9FHBz7");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/Zt9FHBz7");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00009C00 File Offset: 0x00007E00
		private void button84_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nLwctUaw");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nLwctUaw");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002380 File Offset: 0x00000580
		private void button87_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Patched For Now");
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00009C80 File Offset: 0x00007E80
		private void button82_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/D7WZG7H5");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/D7WZG7H5");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00009D00 File Offset: 0x00007F00
		private void button100_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/GwG7JhqH");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/GwG7JhqH");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00009D80 File Offset: 0x00007F80
		private void button101_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/MXv3BZCw");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/MXv3BZCw");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002380 File Offset: 0x00000580
		private void button102_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Patched For Now");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00009E00 File Offset: 0x00008000
		private void button103_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/BlodyXHub/Xeniel_All/main/ForAll");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/BlodyXHub/Xeniel_All/main/ForAll");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007980 File Offset: 0x00005B80
		private void button104_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nmQp3H5S");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00009E80 File Offset: 0x00008080
		private void button98_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/7XKrCZMD");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/7XKrCZMD");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00009F00 File Offset: 0x00008100
		private void button97_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/reddythedev/Reddy-Hub/main/_Loader");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/reddythedev/Reddy-Hub/main/_Loader");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00009F80 File Offset: 0x00008180
		private void button99_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/6wXvMJu9");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/6wXvMJu9");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000A000 File Offset: 0x00008200
		private void button96_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/UhM5xJ06");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/UhM5xJ06");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007980 File Offset: 0x00005B80
		private void button94_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nmQp3H5S");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000A080 File Offset: 0x00008280
		private void button95_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/JQ1Z8Mp2");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/JQ1Z8Mp2");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000A100 File Offset: 0x00008300
		private void button93_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/8Ye1rgN2");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/8Ye1rgN2");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007980 File Offset: 0x00005B80
		private void button92_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/nmQp3H5S");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000A180 File Offset: 0x00008380
		private void button91_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/dCmUBchn");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/dCmUBchn");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000A200 File Offset: 0x00008400
		private void button90_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/7a4xBchJ");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/7a4xBchJ");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000A280 File Offset: 0x00008480
		private void button89_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/pdrEDA2c");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/pdrEDA2c");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000A300 File Offset: 0x00008500
		private void button88_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/joeengo/Future/main/loadstring.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/joeengo/Future/main/loadstring.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000A380 File Offset: 0x00008580
		private void button105_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub2 scriptHub = new ScriptHub2();
			scriptHub.Show();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000208A File Offset: 0x0000028A
		private void button107_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000A3A4 File Offset: 0x000085A4
		private void button106_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub3 scriptHub = new ScriptHub3();
			scriptHub.Show();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000A3C8 File Offset: 0x000085C8
		private void button113_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/Impulseonyoutube/scripts/main/dahood");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/Impulseonyoutube/scripts/main/dahood");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000A448 File Offset: 0x00008648
		private void button114_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/6zP579q2");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/6zP579q2");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000A4C8 File Offset: 0x000086C8
		private void button115_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/f0KVeyqG");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/f0KVeyqG");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000A548 File Offset: 0x00008748
		private void button116_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/8VSzrdUQ");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/8VSzrdUQ");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000A5C8 File Offset: 0x000087C8
		private void button111_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/Jaaaaay2/MahScriptHub/master/AFS%20Remastered");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/Jaaaaay2/MahScriptHub/master/AFS%20Remastered");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000A648 File Offset: 0x00008848
		private void button110_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/JNFM0xpb");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/JNFM0xpb");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000A6C8 File Offset: 0x000088C8
		private void button112_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/CbVhHYNH");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/CbVhHYNH");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000A748 File Offset: 0x00008948
		private void button109_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/Corrupt2625/Revamps/main/SpyHub.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/Corrupt2625/Revamps/main/SpyHub.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000A7C8 File Offset: 0x000089C8
		private void button102_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/qt0CvY9e");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/qt0CvY9e");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000A848 File Offset: 0x00008A48
		private void button108_Click(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/PgRNeLmH");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/PgRNeLmH");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00009880 File Offset: 0x00007A80
		private void button71_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/JoshieGemFinder/gubgub/main/beeswaemfree");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/JoshieGemFinder/gubgub/main/beeswaemfree");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000A8C8 File Offset: 0x00008AC8
		private void button61_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/Z3iAXASr");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/Z3iAXASr");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000A948 File Offset: 0x00008B48
		private void button43_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/reavscripts/sl2_autofarm/main/main.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/reavscripts/sl2_autofarm/main/main.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		private void button33_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://pastebin.com/raw/sepn88HY");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://pastebin.com/raw/sepn88HY");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000AA48 File Offset: 0x00008C48
		private void button30_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/Sinscrips/roblox-scripts/main/surfhaxx.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/Sinscrips/roblox-scripts/main/surfhaxx.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002087 File Offset: 0x00000287
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002087 File Offset: 0x00000287
		private void label9_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002087 File Offset: 0x00000287
		private void label9_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		private void button87_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WRDButton.Checked;
			if (@checked)
			{
				WebClient webClient = new WebClient();
				string script = webClient.DownloadString("https://raw.githubusercontent.com/BLACKGAMER1221/Pet-Simulator-X/main/BK%20Pet.lua");
				this.api.SendLuaScript(script);
			}
			else
			{
				bool checked2 = this.EXButton.Checked;
				if (checked2)
				{
					WebClient webClient2 = new WebClient();
					string script2 = webClient2.DownloadString("https://raw.githubusercontent.com/BLACKGAMER1221/Pet-Simulator-X/main/BK%20Pet.lua");
					this.module.ExecuteScript(script2);
				}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002087 File Offset: 0x00000287
		private void label30_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000791C File Offset: 0x00005B1C
		private void label9_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000234E File Offset: 0x0000054E
		private void label9_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000234E File Offset: 0x0000054E
		private void label9_MouseDown_1(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000791C File Offset: 0x00005B1C
		private void label9_MouseMove_1(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000234E File Offset: 0x0000054E
		private void label9_MouseDown_2(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000791C File Offset: 0x00005B1C
		private void label9_MouseMove_2(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002087 File Offset: 0x00000287
		private void WRDButton_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002087 File Offset: 0x00000287
		private void EXButton_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002087 File Offset: 0x00000287
		private void ScriptHub_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000060 RID: 96
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000061 RID: 97
		private Module module = new Module();

		// Token: 0x04000062 RID: 98
		private Point lastPoint;
	}
}
