namespace tasarımsüreçleri
{
	partial class Form4
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(555, 422);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Havalandırma Kontrolü";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(226, 422);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Sıcaklık Kontrolü\r\n";
			// 
			// button2
			// 
			this.button2.Image = global::tasarımsüreçleri.Properties.Resources.havalandırma2;
			this.button2.Location = new System.Drawing.Point(481, 155);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(250, 250);
			this.button2.TabIndex = 7;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Image = global::tasarımsüreçleri.Properties.Resources.sıcaklık2;
			this.button1.Location = new System.Drawing.Point(142, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(250, 250);
			this.button1.TabIndex = 6;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::tasarımsüreçleri.Properties.Resources.arkaplan2;
			this.ClientSize = new System.Drawing.Size(873, 590);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form4";
			this.Text = "Form4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}