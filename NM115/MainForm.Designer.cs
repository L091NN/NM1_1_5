namespace NM115
{
	partial class MainWindow
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.I0 = new System.Windows.Forms.Label();
            this.IoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.h = new System.Windows.Forms.Label();
            this.HtextBox = new System.Windows.Forms.TextBox();
            this.E = new System.Windows.Forms.Label();
            this.EtextBox = new System.Windows.Forms.TextBox();
            this.L = new System.Windows.Forms.Label();
            this.LtextBox = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.Label();
            this.RtextBox = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.Label();
            this.VtextBox = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.Page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Page1);
            this.TabControl.Controls.Add(this.Page2);
            this.TabControl.ItemSize = new System.Drawing.Size(20, 15);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1300, 700);
            this.TabControl.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.VtextBox);
            this.Page1.Controls.Add(this.V);
            this.Page1.Controls.Add(this.RtextBox);
            this.Page1.Controls.Add(this.R);
            this.Page1.Controls.Add(this.LtextBox);
            this.Page1.Controls.Add(this.L);
            this.Page1.Controls.Add(this.EtextBox);
            this.Page1.Controls.Add(this.E);
            this.Page1.Controls.Add(this.HtextBox);
            this.Page1.Controls.Add(this.h);
            this.Page1.Controls.Add(this.I0);
            this.Page1.Controls.Add(this.IoTextBox);
            this.Page1.Controls.Add(this.label1);
            this.Page1.Controls.Add(this.XoTextBox);
            this.Page1.Controls.Add(this.dataGridView1);
            this.Page1.Controls.Add(this.zedGraphControl1);
            this.Page1.Location = new System.Drawing.Point(4, 19);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(1292, 677);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Задача";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // I0
            // 
            this.I0.AutoSize = true;
            this.I0.Location = new System.Drawing.Point(3, 40);
            this.I0.Name = "I0";
            this.I0.Size = new System.Drawing.Size(28, 13);
            this.I0.TabIndex = 8;
            this.I0.Text = "Io = ";
            // 
            // IoTextBox
            // 
            this.IoTextBox.Location = new System.Drawing.Point(38, 37);
            this.IoTextBox.Name = "IoTextBox";
            this.IoTextBox.Size = new System.Drawing.Size(121, 20);
            this.IoTextBox.TabIndex = 6;
            this.IoTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xo =";
            // 
            // XoTextBox
            // 
            this.XoTextBox.Location = new System.Drawing.Point(38, 11);
            this.XoTextBox.Name = "XoTextBox";
            this.XoTextBox.Size = new System.Drawing.Size(121, 20);
            this.XoTextBox.TabIndex = 4;
            this.XoTextBox.Text = "0";
            this.XoTextBox.TextChanged += new System.EventHandler(this.XoTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 498);
            this.dataGridView1.TabIndex = 1;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(639, 128);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(625, 498);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // Page2
            // 
            this.Page2.Location = new System.Drawing.Point(4, 19);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(1292, 677);
            this.Page2.TabIndex = 2;
            this.Page2.Text = "Справка";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Location = new System.Drawing.Point(6, 68);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(25, 13);
            this.h.TabIndex = 14;
            this.h.Text = "h  =";
            this.h.Click += new System.EventHandler(this.label3_Click);
            // 
            // HtextBox
            // 
            this.HtextBox.Location = new System.Drawing.Point(38, 63);
            this.HtextBox.Name = "HtextBox";
            this.HtextBox.Size = new System.Drawing.Size(121, 20);
            this.HtextBox.TabIndex = 15;
            this.HtextBox.Text = "0,001";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(6, 91);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(23, 13);
            this.E.TabIndex = 16;
            this.E.Text = "E =";
            // 
            // EtextBox
            // 
            this.EtextBox.Location = new System.Drawing.Point(38, 88);
            this.EtextBox.Name = "EtextBox";
            this.EtextBox.Size = new System.Drawing.Size(121, 20);
            this.EtextBox.TabIndex = 17;
            this.EtextBox.Text = "0,00001";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(165, 14);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(22, 13);
            this.L.TabIndex = 18;
            this.L.Text = "L =";
            // 
            // LtextBox
            // 
            this.LtextBox.Location = new System.Drawing.Point(193, 11);
            this.LtextBox.Name = "LtextBox";
            this.LtextBox.Size = new System.Drawing.Size(121, 20);
            this.LtextBox.TabIndex = 19;
            this.LtextBox.Text = "1.0";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(165, 40);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(24, 13);
            this.R.TabIndex = 20;
            this.R.Text = "R =";
            // 
            // RtextBox
            // 
            this.RtextBox.Location = new System.Drawing.Point(193, 38);
            this.RtextBox.Name = "RtextBox";
            this.RtextBox.Size = new System.Drawing.Size(121, 20);
            this.RtextBox.TabIndex = 21;
            this.RtextBox.Text = "5,0";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(166, 63);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(23, 13);
            this.V.TabIndex = 22;
            this.V.Text = "V =";
            // 
            // VtextBox
            // 
            this.VtextBox.Location = new System.Drawing.Point(193, 64);
            this.VtextBox.Name = "VtextBox";
            this.VtextBox.Size = new System.Drawing.Size(121, 20);
            this.VtextBox.TabIndex = 23;
            this.VtextBox.Text = "0,0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1280, 657);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "NumericalMethods";
            this.TabControl.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage Page1;
		private System.Windows.Forms.TabPage Page2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ZedGraph.ZedGraphControl zedGraphControl1;
		private System.Windows.Forms.TextBox IoTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox XoTextBox;
        private System.Windows.Forms.TextBox HtextBox;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.TextBox EtextBox;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.TextBox VtextBox;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.TextBox RtextBox;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.TextBox LtextBox;
        protected internal System.Windows.Forms.Label I0;
    }
}

