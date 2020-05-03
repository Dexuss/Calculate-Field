using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FieldCalculator.Models
{
    public class FieldCalculatorViewModel
    {
        public string InputData { get; set; }
        public double Score { get; set; }
        public string choosedFigure;
        public double a, b, c;

        public void SplitInputData(string inputData)
        {
            if (!String.IsNullOrEmpty(inputData))
            {
                String[] elements = System.Text.RegularExpressions.Regex.Split(inputData.Trim(), " ");
                if (elements.Length > 0)
                {
                    Double.TryParse(elements[0], out a);
                }
                if (elements.Length > 1)
                {
                    Double.TryParse(elements[1], out b);
                }
                if (elements.Length > 2)
                {
                    Double.TryParse(elements[2], out c);
                }
            }
        }

        public double Figure1(double a)
        {
            //kwadrat
            Score = a * a;
            return Score;
        }

        public double Figure1(double a, double b)
        {
            //prostokąt, równoległobok
            Score = a * b;
            return Score;
        }

        public double Figure1(double a, double b, double c)
        {
            //trapez
            Score = ((a + b) * c) / 2;
            return Score;
        }

        public double Figure2(double a)
        {
            //koło
            Score = Math.PI * a;
            return Score;
        }

        public double Figure2(double a, double b)
        {
            //trójkąt
            Score = (a / 2) * b;
            return Score;
        }

        public double Figure3(double a, double b)
        {
            //romb
            Score = (a * b) / 2;
            return Score;
        }
    }
}