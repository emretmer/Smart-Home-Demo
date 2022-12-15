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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form10 frm = new Form10();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form11 frm = new Form11();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}
	}
}
