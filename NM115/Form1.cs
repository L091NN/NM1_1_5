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

    public partial class Form1 : Form
    {
        FelbergMethod FM = new FelbergMethod();
        public Functions.CircuitCurrentSetting fCCS = new Functions.CircuitCurrentSetting();

        GraphPane graphPane;

        public Form1()
        {
            InitializeComponent();

            graphPane = zedGraphControl1.GraphPane;
        }

        private void Draw()
        {
            PointPairList _pointPairList = new PointPairList();
            fCCS.L = 0.5;
            fCCS.R = 2;
            fCCS.V = 1;

            FM.x = 0;
            FM.v = -1;
            FM.h = 0.0001;
            FM.eps = 0.005;

            for (int i = 0;i < 700; i++)
            {
                FM.StepOptimization(fCCS);
                FM.Step();
                double _x = FM.x;
                double _y = FM.v;
                PointPair _pointPair = new PointPair(_x, _y);

                _pointPairList.Add(_pointPair);
            }
            LineItem _lineItem = graphPane.AddCurve("", _pointPairList, Color.Red, SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
