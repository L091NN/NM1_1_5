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

            graphPane = zedGraphControl1.GraphPane;
		}


		double ExtractNumber(string str)
		{			
			bool isFloating = false;

			for (int i = 0; i < str.Length; ++i)
			{
				if (!char.IsDigit(str[i]))
				{
					if (str[i] == '.' && i > 0 && !isFloating && str[i] != '-')
					{
						isFloating = true;
						continue;
					}

					str = str.Remove(i--, 1);
				}
			}
			return str.Length == 0 ? 0.0 : double.Parse(str);
		}

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            stepTable.Rows.Clear();
            fCCS.L = double.Parse(LtextBox.Text);
            fCCS.R = double.Parse(RtextBox.Text);
            fCCS.V = double.Parse(VtextBox.Text);
            
            FM.x = double.Parse(XoTextBox.Text);
            FM.v = double.Parse(IoTextBox.Text);
            FM.h = double.Parse(HtextBox.Text);
            FM.eps = double.Parse(EtextBox.Text);

            graphPane.CurveList.Clear();


            PointPairList list = new PointPairList();

            for(int i = 0; i < 700; ++i)
            {
                stepTable.Rows.Add();
                stepTable.Rows[i].SetValues(i, FM.h, FM.x, FM.v, FM.S, 
                FM.k[0], FM.k[1], FM.k[2], FM.k[3], FM.k[4], FM.k[5]);
                FM.StepOptimization(fCCS);
                FM.Step();
                double _x = FM.x;
                double _y = FM.v;

                PointPair pp = new PointPair(_x, _y);

                list.Add(pp);
            }

            LineItem lineItem = graphPane.AddCurve("", list, Color.Red, SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
    }
}
