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
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();
		}

		private void Form8_Load(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = "C:\\Users\\Emre Tümer\\Downloads\\canlı kamera.mp4";
		}

		private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
		{

		}
	}
}
