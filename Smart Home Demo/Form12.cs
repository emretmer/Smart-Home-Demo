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
	public partial class Form12 : Form
	{
		public Form12()
		{
			InitializeComponent();
			
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{

		}

		private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			int sayi = hScrollBar1.Value;
			label1.Text = sayi.ToString() + "°C";
		}

		private void Form12_Load(object sender, EventArgs e)
		{

		}
	}
}
