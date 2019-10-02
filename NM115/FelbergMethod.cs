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

        public double[] k = new double[6];

        public void Step()
        {
            x += h;
            v += h * ((25 / 216.0) * k[0] + (1408 / 2565.0) * k[2] + (2197.0 / 4104.0) * k[3] - (1 / 5.0) * k[4]);
        }

        public void StepOptimization(Functions.CircuitCurrentSetting _fCCS)
        {
            Functions.CircuitCurrentSetting fCCS = new Functions.CircuitCurrentSetting();
            fCCS = _fCCS;
            double xCur, vCur;
            k[0] = fCCS.Function(x, v);

            xCur = x + h / 4;
            vCur = v + (h / 4) * k[0];
            k[1] = fCCS.Function(xCur, vCur);

            xCur = x + (3 * h) / 8;
            vCur = v + ((3 * k[0] + 9 * k[1]) * h) / 32;
            k[2] = fCCS.Function(xCur, vCur);

            xCur = x + (12 * h) / 13;
            vCur = v + ((1932 / 2197) * k[0] - (7200 / 2197) * k[1] + (7296 / 2197) * k[2]) * h;
            k[3] = fCCS.Function(xCur, vCur);

            xCur = x + h;
            vCur = v + ((439 / 216) * k[0] - 8 * k[1] + (3680 / 513) * k[2] - (845 / 4104) * k[3]) * h;
            k[4] = fCCS.Function(xCur, vCur);

            xCur = x + h / 2;
            vCur = v + ((-8 / 27) * k[0] + 2 * k[1] - (3544 / 2565) * k[2] + (1859 / 4104) * k[3] - (11 / 40) * k[4]) * h;
            k[5] = fCCS.Function(xCur, vCur);

            double S;
            S = h * ((1 / 360.0) * k[0] - (128 / 4275.0) * k[2] + (127 / 6840.0) * k[3] + (1 / 50.0) * k[4] + (2 / 55.0) * k[5]);

            if (Math.Abs(S) > eps)
            {
                h /= 2;
                StepOptimization(fCCS);
            }
            else if (Math.Abs(S) < eps / 64)
            {
                h *= 2;
                StepOptimization(fCCS);
            }

        }
    }
}
