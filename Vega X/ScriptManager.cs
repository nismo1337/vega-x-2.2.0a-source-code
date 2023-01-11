using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyExploits;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000C RID: 12
	public partial class ScriptManager : Form
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x00002413 File Offset: 0x00000613
		public ScriptManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00025388 File Offset: 0x00023588
		private void ScriptManager_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
			this.table = new DataTable();
			this.table.Columns.Add("Title", typeof(string));
			this.table.Columns.Add("Scripts", typeof(string));
			this.dataGridView1.DataSource = this.table;
			this.dataGridView1.Columns["Scripts"].Visible = false;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002087 File Offset: 0x00000287
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00025418 File Offset: 0x00023618
		private void button8_Click(object sender, EventArgs e)
		{
			this.table.Rows.Add(new object[]
			{
				this.richTextBox1.Text,
				this.richTextBox2.Text
			});
			this.richTextBox1.Clear();
			this.richTextBox2.Clear();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002441 File Offset: 0x00000641
		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("To use the script manager, first add a *SCRIPT TITLE* and a *SCRIPT*. Then press *SAVE*. Your script will save to the *SCRIPT LIST*. To retrieve a script, select it from the *SCRIPT LIST* and press the *OPEN SCRIPT* button. Then you can execute it with the *EXECUTE SCRIPT* button. Enjoy! ");
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000244F File Offset: 0x0000064F
		private void button4_Click(object sender, EventArgs e)
		{
			this.module.ExecuteScript(this.richTextBox2.Text);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00025474 File Offset: 0x00023674
		private void button3_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.richTextBox2.Text);
					}
				}
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002087 File Offset: 0x00000287
		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002469 File Offset: 0x00000669
		private void button1_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Clear();
			this.richTextBox2.Clear();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00025504 File Offset: 0x00023704
		private void button6_Click(object sender, EventArgs e)
		{
			int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
			bool flag = rowIndex > -1;
			if (flag)
			{
				this.richTextBox1.Text = this.table.Rows[rowIndex].ItemArray[0].ToString();
				this.richTextBox2.Text = this.table.Rows[rowIndex].ItemArray[1].ToString();
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00025584 File Offset: 0x00023784
		private void button5_Click(object sender, EventArgs e)
		{
			int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
			this.table.Rows[rowIndex].Delete();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000208A File Offset: 0x0000028A
		private void button107_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000255BC File Offset: 0x000237BC
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002484 File Offset: 0x00000684
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000249E File Offset: 0x0000069E
		private void button9_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002087 File Offset: 0x00000287
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0400020B RID: 523
		private Module module = new Module();

		// Token: 0x0400020C RID: 524
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x0400020D RID: 525
		private DataTable table;

		// Token: 0x0400020E RID: 526
		private Point lastPoint;
	}
}
