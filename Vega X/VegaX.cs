using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using EasyExploits;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000F RID: 15
	public partial class VegaX : KryptonForm
	{
		// Token: 0x0600021C RID: 540
		public VegaX()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600021D RID: 541
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600021E RID: 542
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600021F RID: 543
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000220 RID: 544
		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do You Really Want To Close Vega X?", "Vega X | Execution", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Application.Exit();
				return;
			}
			bool flag = dialogResult == DialogResult.No;
		}

		// Token: 0x06000221 RID: 545
		private void panel2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Made By 1_F0", "Credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000222 RID: 546
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000223 RID: 547
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000224 RID: 548
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000225 RID: 549
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000226 RID: 550
		private void button6_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(fastColoredTextBox.Text);
					}
				}
			}
		}

		// Token: 0x06000227 RID: 551
		private void button8_Click(object sender, EventArgs e)
		{
			(this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox).Text = "";
		}

		// Token: 0x06000228 RID: 552
		private void button7_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000229 RID: 553
		private void button5_Click(object sender, EventArgs e)
		{
			new Options().Show();
		}

		// Token: 0x0600022A RID: 554
		private void VegaX_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
			string text = "Scriptbox " + (this.TabControl1.TabCount + 1).ToString();
			UserControl1 userControl = new UserControl1();
			userControl.Dock = DockStyle.Fill;
			TabPage tabPage = new TabPage(text);
			tabPage.Controls.Add(userControl);
			this.TabControl1.TabPages.Add(tabPage);
			base.TopMost = true;
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
			this.pictureBox1.AllowDrop = true;
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.EasyExploitRadioButton.Checked = true;
		}

		// Token: 0x0600022B RID: 555
		private void button9_Click(object sender, EventArgs e)
		{
			new ScriptManager().Show();
		}

		// Token: 0x0600022C RID: 556
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			(this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox).Text = File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem));
		}

		// Token: 0x0600022D RID: 557
		private void button3_Click(object sender, EventArgs e)
		{
			if (this.WrdRadioButton.Checked)
			{
				FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.api.SendLuaScript(fastColoredTextBox.Text);
				return;
			}
			if (this.EasyExploitRadioButton.Checked)
			{
				FastColoredTextBox fastColoredTextBox2 = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.module.ExecuteScript(fastColoredTextBox2.Text);
			}
		}

		// Token: 0x0600022E RID: 558
		private void button11_Click(object sender, EventArgs e)
		{
			this.api.LaunchExploit();
		}

		// Token: 0x0600022F RID: 559
		private void button4_Click(object sender, EventArgs e)
		{
			new ScriptHub().Show();
		}

		// Token: 0x06000230 RID: 560
		private void button12_Click(object sender, EventArgs e)
		{
			string text = "Scriptbox" + (this.TabControl1.TabCount + 1).ToString();
			UserControl1 userControl = new UserControl1();
			userControl.Dock = DockStyle.Fill;
			TabPage tabPage = new TabPage(text);
			tabPage.Controls.Add(userControl);
			this.TabControl1.TabPages.Add(tabPage);
		}

		// Token: 0x06000231 RID: 561
		private void RTab_Click(object sender, EventArgs e)
		{
			this.TabControl1.TabPages.Remove(this.TabControl1.SelectedTab);
		}

		// Token: 0x06000232 RID: 562
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000233 RID: 563
		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000234 RID: 564
		private void TabControl1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000235 RID: 565
		private void panel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000236 RID: 566
		private void listBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000237 RID: 567
		private void VegaX_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000238 RID: 568
		private void executeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex != -1)
			{
				this.api.SendLuaScript(File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString()));
				this.api.SendLuaCScript(File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString()));
			}
		}

		// Token: 0x06000239 RID: 569
		private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			if (this.listBox1.SelectedIndex != -1)
			{
				fastColoredTextBox.Text = File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString());
				return;
			}
			MessageBox.Show("Please select a script from the list before trying to loading it in tab.", "Name");
		}

		// Token: 0x0600023A RID: 570
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600023B RID: 571
		private void VegaX_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x0600023C RID: 572
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600023D RID: 573
		private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600023E RID: 574
		private void redThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.DarkRed;
		}

		// Token: 0x0600023F RID: 575
		private void orangeThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Orange;
		}

		// Token: 0x06000240 RID: 576
		private void yellowThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Yellow;
		}

		// Token: 0x06000241 RID: 577
		private void greenThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Green;
		}

		// Token: 0x06000242 RID: 578
		private void blueThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Blue;
		}

		// Token: 0x06000243 RID: 579
		private void purpleThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Purple;
		}

		// Token: 0x06000244 RID: 580
		private void blackThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Black;
		}

		// Token: 0x06000245 RID: 581
		private void pinkThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Pink;
		}

		// Token: 0x06000246 RID: 582
		private void whiteThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.White;
		}

		// Token: 0x06000247 RID: 583
		private void dEFAULTTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = this.button12.BackColor;
			this.panel1.BackColor = this.button13.BackColor;
		}

		// Token: 0x06000248 RID: 584
		private void toolStripSeparator6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000249 RID: 585
		private void cUSTOMTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600024A RID: 586
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600024B RID: 587
		private void pictureBox1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		// Token: 0x0600024C RID: 588
		private void pictureBox1_DragDrop(object sender, DragEventArgs e)
		{
			object data = e.Data.GetData(DataFormats.FileDrop);
			if (data != null)
			{
				string[] array = data as string[];
				if (array.Length != 0)
				{
					this.pictureBox1.Image = Image.FromFile(array[0]);
				}
			}
		}

		// Token: 0x0600024D RID: 589
		private void rEMOVECUSTOMTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do You Really Want To Remove Your Custom Theme?", "Vega X | Themes", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.pictureBox1.Image = null;
				return;
			}
			bool flag = dialogResult == DialogResult.No;
		}

		// Token: 0x0600024E RID: 590
		private void lightBlueThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.LightBlue;
		}

		// Token: 0x0600024F RID: 591
		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.checkBox1.CheckState == CheckState.Checked)
			{
				Form.ActiveForm.Opacity = (double)this.trackBar1.Value / 10.0;
			}
			if (this.checkBox1.CheckState == CheckState.Unchecked)
			{
				Form.ActiveForm.Opacity = (double)this.trackBar2.Value / 10.0;
			}
		}

		// Token: 0x06000250 RID: 592
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			if (base.Opacity < 1.0)
			{
				base.Opacity += 0.15;
				return;
			}
			this.timer1.Stop();
		}

		// Token: 0x06000251 RID: 593
		private void toolStripSeparator15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000252 RID: 594
		private void lightBlueToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.CornflowerBlue;
		}

		// Token: 0x06000253 RID: 595
		private void deepRedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.OrangeRed;
		}

		// Token: 0x06000254 RID: 596
		private void lightGreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.DarkSeaGreen;
		}

		// Token: 0x06000255 RID: 597
		private void dEFAULTCOLORToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.panel1.BackColor = this.button13.BackColor;
		}

		// Token: 0x06000256 RID: 598
		private void dimRedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.IndianRed;
		}

		// Token: 0x06000257 RID: 599
		private void brightPurpleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.MediumPurple;
		}

		// Token: 0x06000258 RID: 600
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000259 RID: 601
		private void grayThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Gray;
		}

		// Token: 0x0600025A RID: 602
		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Red;
		}

		// Token: 0x0600025B RID: 603
		private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Orange;
		}

		// Token: 0x0600025C RID: 604
		private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Yellow;
		}

		// Token: 0x0600025D RID: 605
		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Green;
		}

		// Token: 0x0600025E RID: 606
		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Blue;
		}

		// Token: 0x0600025F RID: 607
		private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Purple;
		}

		// Token: 0x06000260 RID: 608
		private void darkGreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.DarkGreen;
		}

		// Token: 0x06000261 RID: 609
		private void lightBlueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.LightBlue;
		}

		// Token: 0x06000262 RID: 610
		private void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Black;
		}

		// Token: 0x06000263 RID: 611
		private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Pink;
		}

		// Token: 0x06000264 RID: 612
		private void tanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Tan;
		}

		// Token: 0x06000265 RID: 613
		private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.White;
		}

		// Token: 0x06000266 RID: 614
		private void dragAnyImageIntoTheBlankSpaceToAddACustomThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000267 RID: 615
		private void cUSTOMTHEMEToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Drag And Drop Any Image/GIF File Next To The 'Transparent' Checkbox To Use A Custom Theme.");
		}

		// Token: 0x06000268 RID: 616
		private void tRANSPARENTTEXTBOXToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000269 RID: 617
		private void onToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TabControl1.SendToBack();
		}

		// Token: 0x0600026A RID: 618
		private void offToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TabControl1.BringToFront();
		}

		// Token: 0x0600026B RID: 619
		private void button14_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
				this.api.SendLuaScript(fastColoredTextBox.Text);
				this.api.SendLuaCScript(fastColoredTextBox.Text);
			}
		}

		// Token: 0x0600026C RID: 620
		private void button15_Click(object sender, EventArgs e)
		{
			new ScriptHub().Show();
		}

		// Token: 0x0600026D RID: 621
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600026E RID: 622
		private void WrdRadioButton_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600026F RID: 623
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.Black;
		}

		// Token: 0x06000270 RID: 624
		private void EasyExploitRadioButton_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000271 RID: 625
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000272 RID: 626
		private void button4_Click_1(object sender, EventArgs e)
		{
			(this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox).Text = "";
		}

		// Token: 0x06000273 RID: 627
		private void panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000274 RID: 628
		private void panel4_Click(object sender, EventArgs e)
		{
			(this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox).Text = "";
		}

		// Token: 0x06000275 RID: 629
		private void panel3_Click(object sender, EventArgs e)
		{
			if (this.WrdRadioButton.Checked)
			{
				FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.api.SendLuaScript(fastColoredTextBox.Text);
				return;
			}
			if (this.EasyExploitRadioButton.Checked)
			{
				FastColoredTextBox fastColoredTextBox2 = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.module.ExecuteScript(fastColoredTextBox2.Text);
			}
		}

		// Token: 0x06000276 RID: 630
		private void button8_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000277 RID: 631
		private void panel5_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000278 RID: 632
		private void button6_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(fastColoredTextBox.Text);
					}
				}
			}
		}

		// Token: 0x06000279 RID: 633
		private void panel6_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(fastColoredTextBox.Text);
					}
				}
			}
		}

		// Token: 0x0600027A RID: 634
		private void button7_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
				this.api.SendLuaScript(fastColoredTextBox.Text);
				this.api.SendLuaCScript(fastColoredTextBox.Text);
			}
		}

		// Token: 0x0600027B RID: 635
		private void panel7_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
				this.api.SendLuaScript(fastColoredTextBox.Text);
				this.api.SendLuaCScript(fastColoredTextBox.Text);
			}
		}

		// Token: 0x0600027C RID: 636
		private void button14_Click_1(object sender, EventArgs e)
		{
			new Options().Show();
		}

		// Token: 0x0600027D RID: 637
		private void panel8_Click(object sender, EventArgs e)
		{
			new Options().Show();
		}

		// Token: 0x0600027E RID: 638
		private void panel9_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600027F RID: 639
		private void panel9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000280 RID: 640
		private void button16_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000281 RID: 641
		private void button5_Click_1(object sender, EventArgs e)
		{
			if (this.WrdRadioButton.Checked)
			{
				this.api.LaunchExploit();
				return;
			}
			if (this.EasyExploitRadioButton.Checked)
			{
				this.module.LaunchExploit();
			}
		}

		// Token: 0x06000282 RID: 642
		private void panel10_Click(object sender, EventArgs e)
		{
			if (this.WrdRadioButton.Checked)
			{
				this.api.LaunchExploit();
				return;
			}
			if (this.EasyExploitRadioButton.Checked)
			{
				this.module.LaunchExploit();
			}
		}

		// Token: 0x06000283 RID: 643
		private void button10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000284 RID: 644
		private void panel12_Paint(object sender, PaintEventArgs e)
		{
			this.panel12.BackColor = this.rButton8.BackColor;
		}

		// Token: 0x06000285 RID: 645
		private void button10_Click_1(object sender, EventArgs e)
		{
			new SimpleUI().Show();
		}

		// Token: 0x06000286 RID: 646
		private void panel12_Click(object sender, EventArgs e)
		{
			new SimpleUI().Show();
		}

		// Token: 0x06000287 RID: 647
		private void panel13_Click(object sender, EventArgs e)
		{
			new ScriptManager().Show();
		}

		// Token: 0x06000288 RID: 648
		private void panel14_Click(object sender, EventArgs e)
		{
			new ScriptHub().Show();
		}

		// Token: 0x06000289 RID: 649
		private void button11_Click_1(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x0600028A RID: 650
		private void panel9_Leave(object sender, EventArgs e)
		{
		}

		// Token: 0x0600028B RID: 651
		private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x0600028C RID: 652
		private void panel10_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600028D RID: 653
		private void panel7_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600028E RID: 654
		private void panel14_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600028F RID: 655
		private void rButton1_Click(object sender, EventArgs e)
		{
			if (this.WrdRadioButton.Checked)
			{
				this.api.LaunchExploit();
				return;
			}
			if (this.EasyExploitRadioButton.Checked)
			{
				this.module.LaunchExploit();
			}
		}

		// Token: 0x06000290 RID: 656
		private void rButton2_Click(object sender, EventArgs e)
		{
			if (this.WrdRadioButton.Checked)
			{
				FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.api.SendLuaScript(fastColoredTextBox.Text);
				return;
			}
			if (this.EasyExploitRadioButton.Checked)
			{
				FastColoredTextBox fastColoredTextBox2 = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.module.ExecuteScript(fastColoredTextBox2.Text);
			}
		}

		// Token: 0x06000291 RID: 657
		private void rButton3_Click(object sender, EventArgs e)
		{
			(this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox).Text = "";
		}

		// Token: 0x06000292 RID: 658
		private void rButton4_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
				this.api.SendLuaScript(fastColoredTextBox.Text);
				this.api.SendLuaCScript(fastColoredTextBox.Text);
			}
		}

		// Token: 0x06000293 RID: 659
		private void rButton5_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(fastColoredTextBox.Text);
					}
				}
			}
		}

		// Token: 0x06000294 RID: 660
		private void rButton6_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000295 RID: 661
		private void rButton7_Click(object sender, EventArgs e)
		{
			new Options().Show();
		}

		// Token: 0x06000296 RID: 662
		private void rButton8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000297 RID: 663
		private void rButton8_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000298 RID: 664
		private void rButton9_Click(object sender, EventArgs e)
		{
			new ScriptManager().Show();
		}

		// Token: 0x06000299 RID: 665
		private void rButton10_Click(object sender, EventArgs e)
		{
			new SimpleUI().Show();
		}

		// Token: 0x0600029A RID: 666
		private void rButton11_Click(object sender, EventArgs e)
		{
			string text = "Scriptbox" + (this.TabControl1.TabCount + 1).ToString();
			UserControl1 userControl = new UserControl1();
			userControl.Dock = DockStyle.Fill;
			TabPage tabPage = new TabPage(text);
			tabPage.Controls.Add(userControl);
			this.TabControl1.TabPages.Add(tabPage);
		}

		// Token: 0x0600029B RID: 667
		private void rButton11_Click_1(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x0600029C RID: 668
		private void rButton8_Click_2(object sender, EventArgs e)
		{
			new ScriptHub().Show();
		}

		// Token: 0x0600029D RID: 669
		private void rButton8_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600029E RID: 670
		private void rButton8_DragOver(object sender, DragEventArgs e)
		{
			this.panel14.BackColor = Color.DimGray;
		}

		// Token: 0x0600029F RID: 671
		private void rButton8_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A0 RID: 672
		private void panel11_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060002A1 RID: 673
		private void transparentTextBoxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			(this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox).BackColor = Color.Transparent;
		}

		// Token: 0x060002A2 RID: 674
		private void themesbutton_SelectedColorChanged(object sender, ColorEventArgs e)
		{
			Form.ActiveForm.BackColor = this.themesbutton.SelectedColor;
		}

		// Token: 0x060002A3 RID: 675
		private void themesbutton_StyleChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A4 RID: 676
		private void themesbutton_BackColorChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A5 RID: 677
		private void themesbutton_PaletteChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A6 RID: 678
		private void timer2_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A7 RID: 679
		private void themesbutton_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060002A8 RID: 680
		private void button3_Click_1(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.FromArgb(45, 45, 45);
			this.panel1.BackColor = Color.FromArgb(60, 60, 60);
			this.themesbutton.SelectedColor = Color.FromArgb(45, 45, 45);
			this.pictureBox1.Image = null;
		}

		// Token: 0x060002A9 RID: 681
		private void button4_Click_2(object sender, EventArgs e)
		{
			this.contextMenuStrip1.Show(this.button4, 0, this.button4.Height);
		}

		// Token: 0x04000237 RID: 567
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000238 RID: 568
		private Module module = new Module();

		// Token: 0x04000239 RID: 569
		private Point lastPoint;
	}
}
