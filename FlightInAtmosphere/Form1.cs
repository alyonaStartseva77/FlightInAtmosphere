using System;
using FlightInAtmosphere.Classes;

namespace FlightInAtmosphere
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void InitialObject()
        {
            FlightObject.a = (double)numericAngle.Value;
            FlightObject.v0 = (double)numericSpeed.Value;
            FlightObject.y0 = (double)numericHeight.Value;
            FlightObject.m = (double)numericWeight.Value;
            FlightObject.s = (double)numericSquare.Value;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InitialObject();
            FlightObject.InitialProperties();

            chart.Series[0].Points.Clear();
            chart.Series[0].Points.AddXY(FlightObject.x, FlightObject.y);

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            FlightObject.MakeStep();

            chart.Series[0].Points.AddXY(FlightObject.x, FlightObject.y);
            if (FlightObject.y <= 0) timer.Stop();
        }
    }
}
