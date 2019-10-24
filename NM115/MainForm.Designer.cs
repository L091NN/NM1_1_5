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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.VtextBox = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.Label();
            this.RtextBox = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.Label();
            this.LtextBox = new System.Windows.Forms.TextBox();
            this.L = new System.Windows.Forms.Label();
            this.EtextBox = new System.Windows.Forms.TextBox();
            this.E = new System.Windows.Forms.Label();
            this.HtextBox = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.Label();
            this.I0 = new System.Windows.Forms.Label();
            this.IoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.Page2 = new System.Windows.Forms.TabPage();
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
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1733, 862);
            this.TabControl.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.CalculateButton);
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
            this.Page1.Margin = new System.Windows.Forms.Padding(4);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(4);
            this.Page1.Size = new System.Drawing.Size(1725, 839);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Задача";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(1551, 71);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(134, 58);
            this.CalculateButton.TabIndex = 24;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // VtextBox
            // 
            this.VtextBox.Location = new System.Drawing.Point(257, 79);
            this.VtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.VtextBox.Name = "VtextBox";
            this.VtextBox.Size = new System.Drawing.Size(160, 22);
            this.VtextBox.TabIndex = 23;
            this.VtextBox.Text = "0,0";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(221, 78);
            this.V.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(29, 17);
            this.V.TabIndex = 22;
            this.V.Text = "V =";
            // 
            // RtextBox
            // 
            this.RtextBox.Location = new System.Drawing.Point(257, 47);
            this.RtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RtextBox.Name = "RtextBox";
            this.RtextBox.Size = new System.Drawing.Size(160, 22);
            this.RtextBox.TabIndex = 21;
            this.RtextBox.Text = "5,0";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(220, 49);
            this.R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(30, 17);
            this.R.TabIndex = 20;
            this.R.Text = "R =";
            // 
            // LtextBox
            // 
            this.LtextBox.Location = new System.Drawing.Point(257, 14);
            this.LtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LtextBox.Name = "LtextBox";
            this.LtextBox.Size = new System.Drawing.Size(160, 22);
            this.LtextBox.TabIndex = 19;
            this.LtextBox.Text = "1.0";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(220, 17);
            this.L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(28, 17);
            this.L.TabIndex = 18;
            this.L.Text = "L =";
            // 
            // EtextBox
            // 
            this.EtextBox.Location = new System.Drawing.Point(51, 108);
            this.EtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EtextBox.Name = "EtextBox";
            this.EtextBox.Size = new System.Drawing.Size(160, 22);
            this.EtextBox.TabIndex = 17;
            this.EtextBox.Text = "0,00001";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(8, 112);
            this.E.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(29, 17);
            this.E.TabIndex = 16;
            this.E.Text = "E =";
            // 
            // HtextBox
            // 
            this.HtextBox.Location = new System.Drawing.Point(51, 78);
            this.HtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HtextBox.Name = "HtextBox";
            this.HtextBox.Size = new System.Drawing.Size(160, 22);
            this.HtextBox.TabIndex = 15;
            this.HtextBox.Text = "0,001";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Location = new System.Drawing.Point(8, 84);
            this.h.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(32, 17);
            this.h.TabIndex = 14;
            this.h.Text = "h  =";
            // 
            // I0
            // 
            this.I0.AutoSize = true;
            this.I0.Location = new System.Drawing.Point(4, 49);
            this.I0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.I0.Name = "I0";
            this.I0.Size = new System.Drawing.Size(35, 17);
            this.I0.TabIndex = 8;
            this.I0.Text = "Io = ";
            // 
            // IoTextBox
            // 
            this.IoTextBox.Location = new System.Drawing.Point(51, 46);
            this.IoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IoTextBox.Name = "IoTextBox";
            this.IoTextBox.Size = new System.Drawing.Size(160, 22);
            this.IoTextBox.TabIndex = 6;
            this.IoTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xo =";
            // 
            // XoTextBox
            // 
            this.XoTextBox.Location = new System.Drawing.Point(51, 14);
            this.XoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.XoTextBox.Name = "XoTextBox";
            this.XoTextBox.Size = new System.Drawing.Size(160, 22);
            this.XoTextBox.TabIndex = 4;
            this.XoTextBox.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(833, 613);
            this.dataGridView1.TabIndex = 1;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(852, 158);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(833, 613);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // Page2
            // 
            this.Page2.Location = new System.Drawing.Point(4, 19);
            this.Page2.Margin = new System.Windows.Forms.Padding(4);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(4);
            this.Page2.Size = new System.Drawing.Size(1725, 839);
            this.Page2.TabIndex = 2;
            this.Page2.Text = "Справка";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1728, 849);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button CalculateButton;
    }
}

