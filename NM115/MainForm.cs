using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;


namespace NM115
{
	public partial class MainWindow : Form
	{
        FelbergMethod FM = new FelbergMethod();
        public Functions.CircuitCurrentSetting fCCS = new Functions.CircuitCurrentSetting();

        GraphPane graphPane;

        public MainWindow()
		{
            InitializeComponent();

			XoTextBox.Text = "0";
			IoTextBox.Text = "0.314";
		}


		double ExtractNumber(string str)
		{			
			bool isFloating = false;

			for (int i = 0; i < str.Length; ++i)
			{
				if (!char.IsDigit(str[i]))
				{
					if (str[i] == '.' && i > 0 && !isFloating)
					{
						isFloating = true;
						continue;
					}

					str = str.Remove(i--, 1);
				}
			}
			return str.Length == 0 ? 0.0 : double.Parse(str);
		}




		private void XoTextBox_TextChanged(object sender, EventArgs e)
		{
			double number = ExtractNumber(((TextBox)sender).Text);
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
