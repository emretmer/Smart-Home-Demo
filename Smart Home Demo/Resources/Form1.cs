using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasarımsüreçleri.Resources
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Form3 frm = new Form3();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			Form4 frm = new Form4();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			Form5 frm = new Form5();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			Form6 frm = new Form6();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			Form7 frm = new Form7();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}
	}
}
