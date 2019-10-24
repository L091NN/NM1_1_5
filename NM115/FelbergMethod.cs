using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM115
{
    public class FelbergMethod
    {
        public double x { set; get; }
        public double v { set; get; }
        public double h { set; get; }
        public double eps { set; get; }
        public double S { set; get; }

        public double[] k = new double[6];

        public void Step()
        {
            x += h;
            v += h * ((25.0 / 216.0) * k[0] + (1408.0 / 2565.0) * k[2] + (2197.0 / 4104.0) * k[3] - (1.0 / 5.0) * k[4]);
        }

        public void StepOptimization(Functions.CircuitCurrentSetting _fCCS)
        {
            Functions.CircuitCurrentSetting fCCS = new Functions.CircuitCurrentSetting();
            fCCS = _fCCS;
            double xCur, vCur;
            k[0] = fCCS.Function(x, v);

            xCur = x + h / 4.0;
            vCur = v + (h / 4.0) * k[0];
            k[1] = fCCS.Function(xCur, vCur);

            xCur = x + (3.0 * h) / 8.0;
            vCur = v + ((3.0 * k[0] + 9.0 * k[1]) * h) / 32.0;
            k[2] = fCCS.Function(xCur, vCur);

            xCur = x + (12.0 * h) / 13.0;
            vCur = v + ((1932.0 / 2197.0) * k[0] - (7200.0 / 2197.0) * k[1] + (7296.0 / 2197.0) * k[2]) * h;
            k[3] = fCCS.Function(xCur, vCur);

            xCur = x + h;
            vCur = v + ((439.0 / 216.0) * k[0] - 8.0 * k[1] + (3680.0 / 513.0) * k[2] - (845.0 / 4104.0) * k[3]) * h;
            k[4] = fCCS.Function(xCur, vCur);

            xCur = x + h / 2;
            vCur = v + ((-8.0 / 27.0) * k[0] + 2.0 * k[1] - (3544.0 / 2565.0) * k[2] + (1859.0 / 4104.0) * k[3] - (11.0 / 40.0) * k[4]) * h;
            k[5] = fCCS.Function(xCur, vCur);

            double s = h * ((1.0 / 360.0) * k[0] - (128.0 / 4275.0) * k[2] + (127.0 / 6840.0) * k[3] + (1.0 / 50.0) * k[4] + (2.0 / 55.0) * k[5]);

            S = Math.Abs(s);

            if (S > eps)
            {
                h /= 2.0;
                StepOptimization(fCCS);
            }
            else if (S < eps / 64.0)
            {
                h *= 2.0;
                StepOptimization(fCCS);
            }

        }
    }
}
