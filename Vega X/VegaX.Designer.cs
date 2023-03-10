namespace Vega_X
{
	// Token: 0x0200000F RID: 15
	public partial class VegaX : global::ComponentFactory.Krypton.Toolkit.KryptonForm
	{
		// Token: 0x060002AA RID: 682
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002AB RID: 683
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vega_X.VegaX));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.EasyExploitRadioButton = new global::System.Windows.Forms.RadioButton();
			this.WrdRadioButton = new global::System.Windows.Forms.RadioButton();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button11 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.TabControl1 = new global::System.Windows.Forms.TabControl();
			this.RTab = new global::System.Windows.Forms.Button();
			this.button12 = new global::System.Windows.Forms.Button();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator11 = new global::System.Windows.Forms.ToolStripSeparator();
			this.topBarPanelColorsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.lightBlueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deepRedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lightGreenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dimRedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.brightPurpleToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator17 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator14 = new global::System.Windows.Forms.ToolStripSeparator();
			this.tRANSPARENTTEXTBOXToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.onToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.offToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator10 = new global::System.Windows.Forms.ToolStripSeparator();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.trackBar2 = new global::System.Windows.Forms.TrackBar();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.button13 = new global::System.Windows.Forms.Button();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.panel6 = new global::System.Windows.Forms.Panel();
			this.panel7 = new global::System.Windows.Forms.Panel();
			this.panel8 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel10 = new global::System.Windows.Forms.Panel();
			this.panel11 = new global::System.Windows.Forms.Panel();
			this.panel12 = new global::System.Windows.Forms.Panel();
			this.panel13 = new global::System.Windows.Forms.Panel();
			this.panel14 = new global::System.Windows.Forms.Panel();
			this.ATab = new global::System.Windows.Forms.Button();
			this.rButton10 = new global::Vega_X.RButton();
			this.rButton9 = new global::Vega_X.RButton();
			this.rButton8 = new global::Vega_X.RButton();
			this.rButton7 = new global::Vega_X.RButton();
			this.rButton6 = new global::Vega_X.RButton();
			this.rButton5 = new global::Vega_X.RButton();
			this.rButton4 = new global::Vega_X.RButton();
			this.rButton3 = new global::Vega_X.RButton();
			this.rButton2 = new global::Vega_X.RButton();
			this.rButton1 = new global::Vega_X.RButton();
			this.themesbutton = new global::ComponentFactory.Krypton.Toolkit.KryptonColorButton();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.panel1.Controls.Add(this.EasyExploitRadioButton);
			this.panel1.Controls.Add(this.WrdRadioButton);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button11);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(815, 43);
			this.panel1.TabIndex = 0;
			this.panel1.Click += new global::System.EventHandler(this.panel1_Click);
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.EasyExploitRadioButton.AutoSize = true;
			this.EasyExploitRadioButton.Location = new global::System.Drawing.Point(138, 13);
			this.EasyExploitRadioButton.Name = "EasyExploitRadioButton";
			this.EasyExploitRadioButton.Size = new global::System.Drawing.Size(59, 17);
			this.EasyExploitRadioButton.TabIndex = 325;
			this.EasyExploitRadioButton.Text = "EX API";
			this.EasyExploitRadioButton.UseVisualStyleBackColor = true;
			this.EasyExploitRadioButton.CheckedChanged += new global::System.EventHandler(this.EasyExploitRadioButton_CheckedChanged);
			this.WrdRadioButton.AutoSize = true;
			this.WrdRadioButton.Location = new global::System.Drawing.Point(62, 13);
			this.WrdRadioButton.Name = "WrdRadioButton";
			this.WrdRadioButton.Size = new global::System.Drawing.Size(72, 17);
			this.WrdRadioButton.TabIndex = 324;
			this.WrdRadioButton.Text = "WRD API";
			this.WrdRadioButton.UseVisualStyleBackColor = true;
			this.WrdRadioButton.CheckedChanged += new global::System.EventHandler(this.WrdRadioButton_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Ivory;
			this.label2.Location = new global::System.Drawing.Point(56, 8);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0, 25);
			this.label2.TabIndex = 21;
			this.label2.Visible = false;
			this.button11.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button11.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button11.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button11.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button11.Location = new global::System.Drawing.Point(636, 6);
			this.button11.Name = "button11";
			this.button11.Size = new global::System.Drawing.Size(89, 30);
			this.button11.TabIndex = 41;
			this.button11.Text = "Refresh Scripts";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new global::System.EventHandler(this.button11_Click_1);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new global::System.Drawing.Point(732, 4);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(30, 36);
			this.button2.TabIndex = 4;
			this.button2.Text = "—";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new global::System.Drawing.Point(768, 3);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(42, 37);
			this.button1.TabIndex = 3;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label1.Location = new global::System.Drawing.Point(331, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(125, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Vega X - v2.2.0a cracked by nismo1337";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			this.label1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
			this.panel2.BackColor = global::System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel2.BackgroundImage");
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Location = new global::System.Drawing.Point(2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(48, 39);
			this.panel2.TabIndex = 1;
			this.panel2.Click += new global::System.EventHandler(this.panel2_Click);
			this.panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = global::System.Drawing.SystemColors.Control;
			this.checkBox1.Location = new global::System.Drawing.Point(702, 315);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(83, 17);
			this.checkBox1.TabIndex = 22;
			this.checkBox1.Text = "Transparent";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged_1);
			this.listBox1.BackColor = global::System.Drawing.Color.FromArgb(57, 57, 57);
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(686, 73);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(116, 182);
			this.listBox1.TabIndex = 9;
			this.listBox1.Click += new global::System.EventHandler(this.listBox1_Click);
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.TabControl1.Location = new global::System.Drawing.Point(73, 46);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new global::System.Drawing.Size(607, 268);
			this.TabControl1.TabIndex = 24;
			this.TabControl1.SelectedIndexChanged += new global::System.EventHandler(this.TabControl1_SelectedIndexChanged);
			this.TabControl1.Click += new global::System.EventHandler(this.TabControl1_Click);
			this.RTab.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.RTab.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.RTab.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.RTab.ForeColor = global::System.Drawing.SystemColors.Control;
			this.RTab.Location = new global::System.Drawing.Point(748, 47);
			this.RTab.Name = "RTab";
			this.RTab.Size = new global::System.Drawing.Size(54, 22);
			this.RTab.TabIndex = 26;
			this.RTab.Text = "- Tab";
			this.RTab.UseVisualStyleBackColor = false;
			this.RTab.Click += new global::System.EventHandler(this.RTab_Click);
			this.button12.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button12.Location = new global::System.Drawing.Point(792, 100);
			this.button12.Name = "button12";
			this.button12.Size = new global::System.Drawing.Size(10, 10);
			this.button12.TabIndex = 27;
			this.button12.Text = "button12";
			this.button12.UseVisualStyleBackColor = false;
			this.contextMenuStrip1.BackColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.contextMenuStrip1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripSeparator11,
				this.topBarPanelColorsToolStripMenuItem,
				this.toolStripSeparator14,
				this.tRANSPARENTTEXTBOXToolStripMenuItem,
				this.toolStripSeparator10
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(188, 66);
			this.contextMenuStrip1.MouseLeave += new global::System.EventHandler(this.contextMenuStrip1_MouseLeave);
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new global::System.Drawing.Size(184, 6);
			this.topBarPanelColorsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripSeparator2,
				this.lightBlueToolStripMenuItem,
				this.deepRedToolStripMenuItem,
				this.lightGreenToolStripMenuItem,
				this.dimRedToolStripMenuItem,
				this.toolStripMenuItem1,
				this.brightPurpleToolStripMenuItem,
				this.toolStripSeparator17
			});
			this.topBarPanelColorsToolStripMenuItem.ForeColor = global::System.Drawing.SystemColors.Control;
			this.topBarPanelColorsToolStripMenuItem.Name = "topBarPanelColorsToolStripMenuItem";
			this.topBarPanelColorsToolStripMenuItem.Size = new global::System.Drawing.Size(187, 22);
			this.topBarPanelColorsToolStripMenuItem.Text = "TopBar / Panel Colors";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(145, 6);
			this.lightBlueToolStripMenuItem.Name = "lightBlueToolStripMenuItem";
			this.lightBlueToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.lightBlueToolStripMenuItem.Text = "Light Blue";
			this.lightBlueToolStripMenuItem.Click += new global::System.EventHandler(this.lightBlueToolStripMenuItem_Click_1);
			this.deepRedToolStripMenuItem.Name = "deepRedToolStripMenuItem";
			this.deepRedToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.deepRedToolStripMenuItem.Text = "Bright Orange";
			this.deepRedToolStripMenuItem.Click += new global::System.EventHandler(this.deepRedToolStripMenuItem_Click);
			this.lightGreenToolStripMenuItem.Name = "lightGreenToolStripMenuItem";
			this.lightGreenToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.lightGreenToolStripMenuItem.Text = "Light Green";
			this.lightGreenToolStripMenuItem.Click += new global::System.EventHandler(this.lightGreenToolStripMenuItem_Click);
			this.dimRedToolStripMenuItem.Name = "dimRedToolStripMenuItem";
			this.dimRedToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.dimRedToolStripMenuItem.Text = "Dim Red";
			this.dimRedToolStripMenuItem.Click += new global::System.EventHandler(this.dimRedToolStripMenuItem_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(148, 22);
			this.toolStripMenuItem1.Text = "Black";
			this.toolStripMenuItem1.Click += new global::System.EventHandler(this.toolStripMenuItem1_Click);
			this.brightPurpleToolStripMenuItem.Name = "brightPurpleToolStripMenuItem";
			this.brightPurpleToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.brightPurpleToolStripMenuItem.Text = "Bright Purple";
			this.brightPurpleToolStripMenuItem.Click += new global::System.EventHandler(this.brightPurpleToolStripMenuItem_Click);
			this.toolStripSeparator17.Name = "toolStripSeparator17";
			this.toolStripSeparator17.Size = new global::System.Drawing.Size(145, 6);
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new global::System.Drawing.Size(184, 6);
			this.tRANSPARENTTEXTBOXToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripSeparator5,
				this.onToolStripMenuItem,
				this.offToolStripMenuItem,
				this.toolStripSeparator6
			});
			this.tRANSPARENTTEXTBOXToolStripMenuItem.ForeColor = global::System.Drawing.SystemColors.Control;
			this.tRANSPARENTTEXTBOXToolStripMenuItem.Name = "tRANSPARENTTEXTBOXToolStripMenuItem";
			this.tRANSPARENTTEXTBOXToolStripMenuItem.Size = new global::System.Drawing.Size(187, 22);
			this.tRANSPARENTTEXTBOXToolStripMenuItem.Text = "REMOVE TEXT BOX";
			this.tRANSPARENTTEXTBOXToolStripMenuItem.Click += new global::System.EventHandler(this.tRANSPARENTTEXTBOXToolStripMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(88, 6);
			this.onToolStripMenuItem.Name = "onToolStripMenuItem";
			this.onToolStripMenuItem.Size = new global::System.Drawing.Size(91, 22);
			this.onToolStripMenuItem.Text = "On";
			this.onToolStripMenuItem.Click += new global::System.EventHandler(this.onToolStripMenuItem_Click);
			this.offToolStripMenuItem.Name = "offToolStripMenuItem";
			this.offToolStripMenuItem.Size = new global::System.Drawing.Size(91, 22);
			this.offToolStripMenuItem.Text = "Off";
			this.offToolStripMenuItem.Click += new global::System.EventHandler(this.offToolStripMenuItem_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(88, 6);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new global::System.Drawing.Size(184, 6);
			this.trackBar1.Location = new global::System.Drawing.Point(792, 276);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new global::System.Drawing.Size(10, 45);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.Value = 7;
			this.trackBar2.Location = new global::System.Drawing.Point(776, 276);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new global::System.Drawing.Size(10, 45);
			this.trackBar2.TabIndex = 30;
			this.trackBar2.Value = 10;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick_1);
			this.button13.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button13.Location = new global::System.Drawing.Point(776, 191);
			this.button13.Name = "button13";
			this.button13.Size = new global::System.Drawing.Size(10, 10);
			this.button13.TabIndex = 31;
			this.button13.Text = "button13";
			this.button13.UseVisualStyleBackColor = false;
			this.panel3.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel3.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel3.BackgroundImage");
			this.panel3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Location = new global::System.Drawing.Point(142, 329);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(36, 34);
			this.panel3.TabIndex = 2;
			this.panel3.Click += new global::System.EventHandler(this.panel3_Click);
			this.panel3.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			this.panel4.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel4.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel4.BackgroundImage");
			this.panel4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel4.Location = new global::System.Drawing.Point(238, 328);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(36, 34);
			this.panel4.TabIndex = 3;
			this.panel4.Click += new global::System.EventHandler(this.panel4_Click);
			this.panel4.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			this.panel5.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel5.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel5.BackgroundImage");
			this.panel5.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel5.Location = new global::System.Drawing.Point(18, 124);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(37, 36);
			this.panel5.TabIndex = 4;
			this.panel5.Click += new global::System.EventHandler(this.panel5_Click);
			this.panel6.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel6.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel6.BackgroundImage");
			this.panel6.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel6.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel6.Location = new global::System.Drawing.Point(18, 192);
			this.panel6.Name = "panel6";
			this.panel6.Size = new global::System.Drawing.Size(38, 38);
			this.panel6.TabIndex = 5;
			this.panel6.Click += new global::System.EventHandler(this.panel6_Click);
			this.panel7.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel7.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel7.BackgroundImage");
			this.panel7.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel7.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel7.Location = new global::System.Drawing.Point(19, 261);
			this.panel7.Name = "panel7";
			this.panel7.Size = new global::System.Drawing.Size(38, 35);
			this.panel7.TabIndex = 6;
			this.panel7.Click += new global::System.EventHandler(this.panel7_Click);
			this.panel7.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
			this.panel8.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel8.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel8.BackgroundImage");
			this.panel8.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel8.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel8.Location = new global::System.Drawing.Point(17, 57);
			this.panel8.Name = "panel8";
			this.panel8.Size = new global::System.Drawing.Size(39, 37);
			this.panel8.TabIndex = 6;
			this.panel8.Click += new global::System.EventHandler(this.panel8_Click);
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Location = new global::System.Drawing.Point(-1, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(816, 389);
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
			this.pictureBox1.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
			this.panel10.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel10.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel10.BackgroundImage");
			this.panel10.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel10.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel10.Location = new global::System.Drawing.Point(35, 323);
			this.panel10.Name = "panel10";
			this.panel10.Size = new global::System.Drawing.Size(41, 42);
			this.panel10.TabIndex = 8;
			this.panel10.Click += new global::System.EventHandler(this.panel10_Click);
			this.panel10.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
			this.panel11.BackColor = global::System.Drawing.Color.Transparent;
			this.panel11.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel11.BackgroundImage");
			this.panel11.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel11.Location = new global::System.Drawing.Point(275, 315);
			this.panel11.Name = "panel11";
			this.panel11.Size = new global::System.Drawing.Size(65, 73);
			this.panel11.TabIndex = 2;
			this.panel11.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
			this.panel12.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel12.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel12.BackgroundImage");
			this.panel12.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel12.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel12.Location = new global::System.Drawing.Point(603, 325);
			this.panel12.Name = "panel12";
			this.panel12.Size = new global::System.Drawing.Size(39, 37);
			this.panel12.TabIndex = 9;
			this.panel12.Click += new global::System.EventHandler(this.panel12_Click);
			this.panel12.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
			this.panel13.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel13.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel13.BackgroundImage");
			this.panel13.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel13.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel13.Location = new global::System.Drawing.Point(480, 324);
			this.panel13.Name = "panel13";
			this.panel13.Size = new global::System.Drawing.Size(41, 39);
			this.panel13.TabIndex = 10;
			this.panel13.Click += new global::System.EventHandler(this.panel13_Click);
			this.panel14.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.panel14.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel14.BackgroundImage");
			this.panel14.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel14.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel14.Location = new global::System.Drawing.Point(354, 323);
			this.panel14.Name = "panel14";
			this.panel14.Size = new global::System.Drawing.Size(47, 43);
			this.panel14.TabIndex = 11;
			this.panel14.Click += new global::System.EventHandler(this.panel14_Click);
			this.panel14.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
			this.ATab.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.ATab.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ATab.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ATab.ForeColor = global::System.Drawing.SystemColors.Control;
			this.ATab.Location = new global::System.Drawing.Point(688, 47);
			this.ATab.Name = "ATab";
			this.ATab.Size = new global::System.Drawing.Size(57, 22);
			this.ATab.TabIndex = 25;
			this.ATab.Text = "+ Tab";
			this.ATab.UseVisualStyleBackColor = false;
			this.ATab.Click += new global::System.EventHandler(this.button12_Click);
			this.rButton10.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton10.FlatAppearance.BorderSize = 0;
			this.rButton10.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton10.ForeColor = global::System.Drawing.Color.White;
			this.rButton10.Location = new global::System.Drawing.Point(564, 320);
			this.rButton10.Name = "rButton10";
			this.rButton10.Size = new global::System.Drawing.Size(116, 62);
			this.rButton10.TabIndex = 50;
			this.rButton10.Text = "Simple UI";
			this.rButton10.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton10.UseVisualStyleBackColor = false;
			this.rButton10.Click += new global::System.EventHandler(this.rButton10_Click);
			this.rButton9.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton9.FlatAppearance.BorderSize = 0;
			this.rButton9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton9.ForeColor = global::System.Drawing.Color.White;
			this.rButton9.Location = new global::System.Drawing.Point(442, 320);
			this.rButton9.Name = "rButton9";
			this.rButton9.Size = new global::System.Drawing.Size(116, 62);
			this.rButton9.TabIndex = 49;
			this.rButton9.Text = "Script Manager";
			this.rButton9.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton9.UseVisualStyleBackColor = false;
			this.rButton9.Click += new global::System.EventHandler(this.rButton9_Click);
			this.rButton8.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton8.FlatAppearance.BorderSize = 0;
			this.rButton8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton8.ForeColor = global::System.Drawing.Color.White;
			this.rButton8.Location = new global::System.Drawing.Point(319, 320);
			this.rButton8.Name = "rButton8";
			this.rButton8.Size = new global::System.Drawing.Size(117, 62);
			this.rButton8.TabIndex = 48;
			this.rButton8.Text = "Script Hub";
			this.rButton8.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton8.UseVisualStyleBackColor = false;
			this.rButton8.Click += new global::System.EventHandler(this.rButton8_Click_2);
			this.rButton8.DragOver += new global::System.Windows.Forms.DragEventHandler(this.rButton8_DragOver);
			this.rButton8.Enter += new global::System.EventHandler(this.rButton8_Enter);
			this.rButton8.MouseHover += new global::System.EventHandler(this.rButton8_MouseHover);
			this.rButton7.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton7.FlatAppearance.BorderSize = 0;
			this.rButton7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton7.ForeColor = global::System.Drawing.Color.White;
			this.rButton7.Location = new global::System.Drawing.Point(6, 50);
			this.rButton7.Name = "rButton7";
			this.rButton7.Size = new global::System.Drawing.Size(61, 62);
			this.rButton7.TabIndex = 46;
			this.rButton7.Text = "Options";
			this.rButton7.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton7.UseVisualStyleBackColor = false;
			this.rButton7.Click += new global::System.EventHandler(this.rButton7_Click);
			this.rButton6.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton6.FlatAppearance.BorderSize = 0;
			this.rButton6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton6.ForeColor = global::System.Drawing.Color.White;
			this.rButton6.Location = new global::System.Drawing.Point(6, 118);
			this.rButton6.Name = "rButton6";
			this.rButton6.Size = new global::System.Drawing.Size(61, 62);
			this.rButton6.TabIndex = 45;
			this.rButton6.Text = "Open File";
			this.rButton6.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton6.UseVisualStyleBackColor = false;
			this.rButton6.Click += new global::System.EventHandler(this.rButton6_Click);
			this.rButton5.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton5.FlatAppearance.BorderSize = 0;
			this.rButton5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton5.ForeColor = global::System.Drawing.Color.White;
			this.rButton5.Location = new global::System.Drawing.Point(6, 186);
			this.rButton5.Name = "rButton5";
			this.rButton5.Size = new global::System.Drawing.Size(61, 62);
			this.rButton5.TabIndex = 44;
			this.rButton5.Text = "Save File";
			this.rButton5.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton5.UseVisualStyleBackColor = false;
			this.rButton5.Click += new global::System.EventHandler(this.rButton5_Click);
			this.rButton4.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton4.FlatAppearance.BorderSize = 0;
			this.rButton4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton4.ForeColor = global::System.Drawing.Color.White;
			this.rButton4.Location = new global::System.Drawing.Point(6, 254);
			this.rButton4.Name = "rButton4";
			this.rButton4.Size = new global::System.Drawing.Size(63, 62);
			this.rButton4.TabIndex = 43;
			this.rButton4.Text = "Exec File";
			this.rButton4.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton4.UseVisualStyleBackColor = false;
			this.rButton4.Click += new global::System.EventHandler(this.rButton4_Click);
			this.rButton3.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton3.FlatAppearance.BorderSize = 0;
			this.rButton3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton3.ForeColor = global::System.Drawing.Color.White;
			this.rButton3.Location = new global::System.Drawing.Point(216, 321);
			this.rButton3.Name = "rButton3";
			this.rButton3.Size = new global::System.Drawing.Size(78, 62);
			this.rButton3.TabIndex = 42;
			this.rButton3.Text = "Clear Text";
			this.rButton3.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton3.UseVisualStyleBackColor = false;
			this.rButton3.Click += new global::System.EventHandler(this.rButton3_Click);
			this.rButton2.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton2.FlatAppearance.BorderSize = 0;
			this.rButton2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton2.ForeColor = global::System.Drawing.Color.White;
			this.rButton2.Location = new global::System.Drawing.Point(110, 321);
			this.rButton2.Name = "rButton2";
			this.rButton2.Size = new global::System.Drawing.Size(100, 62);
			this.rButton2.TabIndex = 41;
			this.rButton2.Text = "Execute Script";
			this.rButton2.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton2.UseVisualStyleBackColor = false;
			this.rButton2.Click += new global::System.EventHandler(this.rButton2_Click);
			this.rButton1.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.rButton1.FlatAppearance.BorderSize = 0;
			this.rButton1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.rButton1.ForeColor = global::System.Drawing.Color.White;
			this.rButton1.Location = new global::System.Drawing.Point(7, 319);
			this.rButton1.Name = "rButton1";
			this.rButton1.Size = new global::System.Drawing.Size(98, 62);
			this.rButton1.TabIndex = 0;
			this.rButton1.Text = "Attach";
			this.rButton1.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.rButton1.UseVisualStyleBackColor = false;
			this.rButton1.Click += new global::System.EventHandler(this.rButton1_Click);
			this.themesbutton.EmptyBorderColor = global::System.Drawing.Color.Transparent;
			this.themesbutton.Location = new global::System.Drawing.Point(688, 337);
			this.themesbutton.Name = "themesbutton";
			this.themesbutton.SelectedColor = global::System.Drawing.Color.White;
			this.themesbutton.Size = new global::System.Drawing.Size(116, 45);
			this.themesbutton.StateCommon.Back.Color1 = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StateCommon.Back.Color2 = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StateCommon.Border.Color1 = global::System.Drawing.Color.Transparent;
			this.themesbutton.StateCommon.Border.Color2 = global::System.Drawing.Color.Transparent;
			this.themesbutton.StateCommon.Border.DrawBorders = global::ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.All;
			this.themesbutton.StateCommon.Border.Rounding = 13;
			this.themesbutton.StateCommon.Content.ShortText.Color1 = global::System.Drawing.Color.White;
			this.themesbutton.StateCommon.Content.ShortText.Color2 = global::System.Drawing.Color.White;
			this.themesbutton.StateNormal.Content.Image.ImageColorMap = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StateNormal.Content.Image.ImageColorTo = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StatePressed.Back.Color1 = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StatePressed.Back.Color2 = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StatePressed.Content.Image.ImageColorMap = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StatePressed.Content.Image.ImageColorTo = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StateTracking.Back.Color1 = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StateTracking.Back.Color2 = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StateTracking.Content.Image.ImageColorMap = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.StateTracking.Content.Image.ImageColorTo = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.themesbutton.TabIndex = 51;
			this.themesbutton.Values.Text = "UI Theme";
			this.themesbutton.SelectedColorChanged += new global::System.EventHandler<global::ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.themesbutton_SelectedColorChanged);
			this.themesbutton.PaletteChanged += new global::System.EventHandler(this.themesbutton_PaletteChanged);
			this.themesbutton.BackColorChanged += new global::System.EventHandler(this.themesbutton_BackColorChanged);
			this.themesbutton.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.themesbutton_MouseClick);
			this.themesbutton.StyleChanged += new global::System.EventHandler(this.themesbutton_StyleChanged);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button3.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button3.Location = new global::System.Drawing.Point(686, 287);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(116, 22);
			this.button3.TabIndex = 52;
			this.button3.Text = "Default Theme";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click_1);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button4.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button4.Location = new global::System.Drawing.Point(686, 261);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(116, 23);
			this.button4.TabIndex = 53;
			this.button4.Text = "Top Bar Theme";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click_2);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			base.ClientSize = new global::System.Drawing.Size(816, 389);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.themesbutton);
			base.Controls.Add(this.panel12);
			base.Controls.Add(this.rButton10);
			base.Controls.Add(this.panel13);
			base.Controls.Add(this.rButton9);
			base.Controls.Add(this.panel14);
			base.Controls.Add(this.rButton8);
			base.Controls.Add(this.panel8);
			base.Controls.Add(this.rButton7);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.rButton6);
			base.Controls.Add(this.panel6);
			base.Controls.Add(this.rButton5);
			base.Controls.Add(this.panel7);
			base.Controls.Add(this.rButton4);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.rButton3);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.rButton2);
			base.Controls.Add(this.panel10);
			base.Controls.Add(this.rButton1);
			base.Controls.Add(this.panel11);
			base.Controls.Add(this.RTab);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.ATab);
			base.Controls.Add(this.TabControl1);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button12);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.trackBar1);
			base.Controls.Add(this.trackBar2);
			base.Controls.Add(this.button13);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "VegaX";
			base.Opacity = 0.0;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.StateCommon.Border.DrawBorders = global::ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.All;
			base.StateCommon.Border.Rounding = 10;
			this.Text = "Vega X";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.VegaX_FormClosing);
			base.Load += new global::System.EventHandler(this.VegaX_Load);
			base.Click += new global::System.EventHandler(this.VegaX_Click);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400023A RID: 570
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400023C RID: 572
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400023D RID: 573
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400023E RID: 574
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400023F RID: 575
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000240 RID: 576
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000241 RID: 577
		private global::System.Windows.Forms.TabControl TabControl1;

		// Token: 0x04000242 RID: 578
		private global::System.Windows.Forms.Button RTab;

		// Token: 0x04000243 RID: 579
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000244 RID: 580
		private global::System.Windows.Forms.Button button12;

		// Token: 0x04000245 RID: 581
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000246 RID: 582
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator11;

		// Token: 0x04000247 RID: 583
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000248 RID: 584
		private global::System.Windows.Forms.TrackBar trackBar1;

		// Token: 0x04000249 RID: 585
		private global::System.Windows.Forms.TrackBar trackBar2;

		// Token: 0x0400024A RID: 586
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400024B RID: 587
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator14;

		// Token: 0x0400024C RID: 588
		private global::System.Windows.Forms.ToolStripMenuItem topBarPanelColorsToolStripMenuItem;

		// Token: 0x0400024D RID: 589
		private global::System.Windows.Forms.ToolStripMenuItem lightBlueToolStripMenuItem;

		// Token: 0x0400024E RID: 590
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

		// Token: 0x0400024F RID: 591
		private global::System.Windows.Forms.ToolStripMenuItem deepRedToolStripMenuItem;

		// Token: 0x04000250 RID: 592
		private global::System.Windows.Forms.ToolStripMenuItem lightGreenToolStripMenuItem;

		// Token: 0x04000251 RID: 593
		private global::System.Windows.Forms.Button button13;

		// Token: 0x04000252 RID: 594
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator17;

		// Token: 0x04000253 RID: 595
		private global::System.Windows.Forms.ToolStripMenuItem dimRedToolStripMenuItem;

		// Token: 0x04000254 RID: 596
		private global::System.Windows.Forms.ToolStripMenuItem brightPurpleToolStripMenuItem;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Forms.ToolStripMenuItem tRANSPARENTTEXTBOXToolStripMenuItem;

		// Token: 0x04000256 RID: 598
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;

		// Token: 0x04000258 RID: 600
		private global::System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;

		// Token: 0x04000259 RID: 601
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x0400025A RID: 602
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x0400025B RID: 603
		private global::System.Windows.Forms.RadioButton EasyExploitRadioButton;

		// Token: 0x0400025C RID: 604
		private global::System.Windows.Forms.RadioButton WrdRadioButton;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x0400025E RID: 606
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400025F RID: 607
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000260 RID: 608
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000261 RID: 609
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x04000262 RID: 610
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000263 RID: 611
		private global::System.Windows.Forms.Panel panel8;

		// Token: 0x04000264 RID: 612
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000265 RID: 613
		private global::System.Windows.Forms.Panel panel10;

		// Token: 0x04000266 RID: 614
		private global::System.Windows.Forms.Panel panel11;

		// Token: 0x04000267 RID: 615
		private global::System.Windows.Forms.Panel panel12;

		// Token: 0x04000268 RID: 616
		private global::System.Windows.Forms.Panel panel13;

		// Token: 0x04000269 RID: 617
		private global::System.Windows.Forms.Button button11;

		// Token: 0x0400026A RID: 618
		private global::System.Windows.Forms.Panel panel14;

		// Token: 0x0400026B RID: 619
		private global::Vega_X.RButton rButton1;

		// Token: 0x0400026C RID: 620
		private global::Vega_X.RButton rButton2;

		// Token: 0x0400026D RID: 621
		private global::Vega_X.RButton rButton3;

		// Token: 0x0400026E RID: 622
		private global::Vega_X.RButton rButton4;

		// Token: 0x0400026F RID: 623
		private global::Vega_X.RButton rButton5;

		// Token: 0x04000270 RID: 624
		private global::Vega_X.RButton rButton6;

		// Token: 0x04000271 RID: 625
		private global::Vega_X.RButton rButton7;

		// Token: 0x04000272 RID: 626
		private global::Vega_X.RButton rButton8;

		// Token: 0x04000273 RID: 627
		private global::Vega_X.RButton rButton9;

		// Token: 0x04000274 RID: 628
		private global::Vega_X.RButton rButton10;

		// Token: 0x04000275 RID: 629
		private global::System.Windows.Forms.Button ATab;

		// Token: 0x04000276 RID: 630
		private global::ComponentFactory.Krypton.Toolkit.KryptonColorButton themesbutton;

		// Token: 0x04000277 RID: 631
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000278 RID: 632
		private global::System.Windows.Forms.Button button4;
	}
}
