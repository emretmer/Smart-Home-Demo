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
	public partial class Form9 : Form
	{
		public Form9()
		{
			InitializeComponent();
		}

		private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
		{

		}

		private void Form9_Load(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = "C:\\Users\\Emre Tümer\\Downloads\\kamera kaydı.mp4";
		}
	}
}
