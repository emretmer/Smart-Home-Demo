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
	public partial class Form15 : Form
	{
		public Form15()
		{
			InitializeComponent();
		}

		private void Form15_Load(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int num = rnd.Next(30);
			label2.Text = num.ToString();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
