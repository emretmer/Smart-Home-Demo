using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using tasarımsüreçleri.Resources;

namespace tasarımsüreçleri
{
	public partial class Form0 : Form
	{
		public Form0()
		{
			InitializeComponent();
			textBox2.PasswordChar = '*';
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string id = "grup18";
			string pw = "12345678";
			if (textBox1.Text == id && textBox2.Text == pw)
			{
				Form1 frm = new Form1();
				this.Hide();
				frm.ShowDialog();
				this.Show();
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{

		}
	}
}
