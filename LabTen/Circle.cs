using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen
{
    class Circle
    {
        private double radius;
        public double Radius { get { return Radius; } set { Radius = value; } }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateCircumference()
        {
            return ((this.radius * 2) * Math.PI);
        }

        public string CalculateFormattedCircumference()
        {
            return FormateNumber(CalculateCircumference());
        }
        
        public double CalculateArea()
        {
            return (this.radius * this.radius * Math.PI);
        }

        public string CalculatedFormattedArea()
        {
            return FormateNumber(CalculateArea());
        }

        private string FormateNumber(double x)
        {
            return (Math.Round(x, 2) + "");
        }

    }
}
