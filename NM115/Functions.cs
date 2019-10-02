using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace NM115
{
    public class Functions
    {
        public class CircuitCurrentSetting
        {
            public double V { set; get; }
            public double L { set; get; }
            public double R { set; get; }

            public CircuitCurrentSetting(double _L = 1, double _R = 1, double _V = 0)
            {
                L = _L;
                R = _R;
                V = _V;
            }

            public double Function(double _T, double _I)
            {
                double I = (V - R * _I) / L;
                return I;
            }
        }
    }
}
