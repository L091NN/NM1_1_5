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
            this.stepTable = new System.Windows.Forms.DataGridView();
            this.iСolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k5Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k6Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.Page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepTable)).BeginInit();
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
            this.Page1.Controls.Add(this.stepTable);
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
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Page1.Size = new System.Drawing.Size(1292, 677);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Задача";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(1163, 58);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 47);
            this.CalculateButton.TabIndex = 24;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // VtextBox
            // 
            this.VtextBox.Location = new System.Drawing.Point(193, 64);
            this.VtextBox.Name = "VtextBox";
            this.VtextBox.Size = new System.Drawing.Size(121, 20);
            this.VtextBox.TabIndex = 23;
            this.VtextBox.Text = "1,0";
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
            // RtextBox
            // 
            this.RtextBox.Location = new System.Drawing.Point(193, 38);
            this.RtextBox.Name = "RtextBox";
            this.RtextBox.Size = new System.Drawing.Size(121, 20);
            this.RtextBox.TabIndex = 21;
            this.RtextBox.Text = "2,0";
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
            // LtextBox
            // 
            this.LtextBox.Location = new System.Drawing.Point(193, 11);
            this.LtextBox.Name = "LtextBox";
            this.LtextBox.Size = new System.Drawing.Size(121, 20);
            this.LtextBox.TabIndex = 19;
            this.LtextBox.Text = "0,5";
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
            // EtextBox
            // 
            this.EtextBox.Location = new System.Drawing.Point(38, 88);
            this.EtextBox.Name = "EtextBox";
            this.EtextBox.Size = new System.Drawing.Size(121, 20);
            this.EtextBox.TabIndex = 17;
            this.EtextBox.Text = "0,005";
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
            // HtextBox
            // 
            this.HtextBox.Location = new System.Drawing.Point(38, 63);
            this.HtextBox.Name = "HtextBox";
            this.HtextBox.Size = new System.Drawing.Size(121, 20);
            this.HtextBox.TabIndex = 15;
            this.HtextBox.Text = "0,0001";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Location = new System.Drawing.Point(6, 68);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(25, 13);
            this.h.TabIndex = 14;
            this.h.Text = "h  =";
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
            this.IoTextBox.Text = "-1";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
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
            this.Page2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Page2.Size = new System.Drawing.Size(1292, 677);
            this.Page2.TabIndex = 2;
            this.Page2.Text = "Справка";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // stepTable
            // 
            this.stepTable.BackgroundColor = System.Drawing.Color.Plum;
            this.stepTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stepTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iСolumn,
            this.hiColumn,
            this.xiColumn,
            this.yiColumn,
            this.sColumn,
            this.k1Column,
            this.k2Column,
            this.k3Column,
            this.k4Column,
            this.k5Column,
            this.k6Column});
            this.stepTable.Location = new System.Drawing.Point(9, 128);
            this.stepTable.Name = "stepTable";
            this.stepTable.Size = new System.Drawing.Size(624, 498);
            this.stepTable.TabIndex = 25;
            // 
            // iСolumn
            // 
            this.iСolumn.HeaderText = "i";
            this.iСolumn.Name = "iСolumn";
            // 
            // hiColumn
            // 
            this.hiColumn.HeaderText = "hi";
            this.hiColumn.Name = "hiColumn";
            // 
            // xiColumn
            // 
            this.xiColumn.HeaderText = "xi";
            this.xiColumn.Name = "xiColumn";
            // 
            // yiColumn
            // 
            this.yiColumn.HeaderText = "yi";
            this.yiColumn.Name = "yiColumn";
            // 
            // sColumn
            // 
            this.sColumn.HeaderText = "S";
            this.sColumn.Name = "sColumn";
            // 
            // k1Column
            // 
            this.k1Column.HeaderText = "k1";
            this.k1Column.Name = "k1Column";
            // 
            // k2Column
            // 
            this.k2Column.HeaderText = "k2";
            this.k2Column.Name = "k2Column";
            // 
            // k3Column
            // 
            this.k3Column.HeaderText = "k3";
            this.k3Column.Name = "k3Column";
            // 
            // k4Column
            // 
            this.k4Column.HeaderText = "k4";
            this.k4Column.Name = "k4Column";
            // 
            // k5Column
            // 
            this.k5Column.HeaderText = "k5";
            this.k5Column.Name = "k5Column";
            // 
            // k6Column
            // 
            this.k6Column.HeaderText = "k6";
            this.k6Column.Name = "k6Column";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1296, 690);
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
            ((System.ComponentModel.ISupportInitialize)(this.stepTable)).EndInit();
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
        private System.Windows.Forms.DataGridView stepTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn iСolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn k1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn k3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn k4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn k5Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn k6Column;
    }
}

