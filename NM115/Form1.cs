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

        GraphPane graphPane;

        public Form1()
        {
            InitializeComponent();

            graphPane = zedGraphControl1.GraphPane;
            DrawSineCurve();
        }

        private void DrawSineCurve()
        {
            PointPairList _pointPairList = new PointPairList();

            for (int _angle = 0; _angle <= 360; _angle += 10)
            {
                double _x = _angle;
                double _y = Math.Log(Math.PI * _x / 180.0);
                PointPair _pointPair = new PointPair(_x, _y);

                _pointPairList.Add(_pointPair);
            }

            LineItem _lineItem = graphPane.AddCurve("Sine Curve", _pointPairList, Color.Purple, SymbolType.None);

            zedGraphControl1.AxisChange();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
