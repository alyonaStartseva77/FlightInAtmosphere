using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightInAtmosphere.Classes
{
    static class FlightObject
    {
        static public double t, vx, vy, x, y, v0, a, y0, k, s, m;

        static public void InitialProperties()
        {
            k = 0.5 * Environment.C * s * Environment.rho / m;

            vx = v0 * Math.Cos(a * Math.PI / 180);
            vy = v0 * Math.Sin(a * Math.PI / 180);

            t = 0;
            x = 0;
            y = y0;
        }

        static public void MakeStep()
        {
            t += SimulationModel.TIME_STEP;
            vx = vx - k * vx * Math.Sqrt(vx * vx + vy * vy) * SimulationModel.TIME_STEP;
            vy = vy - (Environment.g + k * vy * Math.Sqrt(vx * vx + vy * vy)) * SimulationModel.TIME_STEP;

            x = x + vx * SimulationModel.TIME_STEP;
            y = y + vy * SimulationModel.TIME_STEP;
        }
    }
}
