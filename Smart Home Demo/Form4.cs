﻿using System;
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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form12 frm = new Form12();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form13 frm = new Form13();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}
	}
}
