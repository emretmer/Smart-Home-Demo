using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasarımsüreçleri
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form8 frm = new Form8();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form9 frm = new Form9();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}
	}
}
