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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form14 frm = new Form14();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form15 frm = new Form15();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}
	}
}
