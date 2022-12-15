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
	public partial class Form13 : Form
	{
		public Form13()
		{
			InitializeComponent();
		}

		private void Form13_Load(object sender, EventArgs e)
		{

		}

		private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			int sayi = hScrollBar1.Value;
			label1.Text = sayi.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
