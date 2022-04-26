﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;

namespace WFcruzlara
{
    internal class BasicCalculator
    {
        public BasicCalculator()
        {
        }

        public string Sum(double val_1, double val_2, ref double res)
        {
            res = val_1 + val_2;
            return "Suma de dos valores";
        }
        
        public string Subtraction(double val_1, double val_2, ref double res)
        {
            res = val_1 - val_2;
            return "Resta de dos valores";
        }
        
        public string Multiplication(double val_1, double val_2, ref double res)
        {
            res = val_1 * val_2;
            return "Multiplicación de dos valores";
        }
        
        public string Division(double val_1, double val_2, ref double res)
        {
            res = val_1 / val_2;
            return "División de dos valores";
        }

        public string Exponential(double val_1, double val_2, ref double res)
        {
            res = Math.Pow(val_1, val_2);
            return "Valor 1 elevado al valor 2";
        }
        
        public string Factorial(double val_1, ref double res)
        {
            double factorial = 1;

            while (val_1 > 0)
            {
                factorial *= val_1;
                val_1--;
            }

            res = factorial;
            return "Factorial de un número";
        }

        public string SenFunction(double val_1, ref double res)
        {
            res = Math.Sin(val_1);
            return "Función seno de un número";
        }
        public string CosFunction(double val_1, ref double res)
        {
            res = Math.Cos(val_1);
            return "Función coseno de un número";
        }

        public string TanFunction(double val_1, ref double res)
        {
            res = Math.Tan(val_1);
            return "Función tangente de un número";
        }

        public string CotFunction(double val_1, ref double res)
        {
            res = 1 / Math.Tan(val_1);
            return "Función cotangente de un número";
        }
        
        public string SecFunction(double val_1, ref double res)
        {
            res = 1 / Math.Cos(val_1);
            return "Función secante de un número";
        }
        
        public string CscFunction(double val_1, ref double res)
        {
            res = 1 / Math.Sin(val_1);
            return "Función cosecante de un número";
        }

        public string SenhFunction(double val_1, ref double res)
        {
            res = Math.Sinh(val_1);
            return "Función seno hiperbólico de un número";
        }
        public string CoshFunction(double val_1, ref double res)
        {
            res = Math.Cosh(val_1);
            return "Función coseno hiperbólico de un número";
        }

        public string TanhFunction(double val_1, ref double res)
        {
            res = Math.Tanh(val_1);
            return "Función tangente hiperbólica de un número";
        }

        public string CothFunction(double val_1, ref double res)
        {
            res = 1 / Math.Tanh(val_1);
            return "Función cotangente hiperbólica de un número";
        }

        public string SechFunction(double val_1, ref double res)
        {
            res = 1 / Math.Cosh(val_1);
            return "Función secante hiperbólica de un número";
        }

        public string CschFunction(double val_1, ref double res)
        {
            res = 1 / Math.Sin(val_1);
            return "Función cosecante hiperbólica de un número";
        }

        public string ElevateTo(double value, double exponent, ref double result)
        {
            result = Math.Pow(value, exponent);
            return "Valor elevado a la " + exponent + "a potencia";
        }

        public string MultiplyX10ElaveteTo(double value, double exponent, ref double result)
        {
            result = value * Math.Pow(10, exponent);
            return "Valor multiplicado x10 a la " + exponent + "a potencia";
        }

        public double ParseFunction(double x, string fx)
        {
            ExpressionParser parserFx = new ExpressionParser();
            parserFx.Values.Add("x", x);
            return parserFx.Parse(fx);
        }

        public string CalculateFunction(double x, string fx, ref double res)
        {
            res = ParseFunction(x, fx);
            return "Evaluación de f(x)";
        }

        public double ParseFunctionXY(double x, double y, string fxy)
        {
            ExpressionParser parserFxy = new ExpressionParser();
            parserFxy.Values.Add("x", x);
            parserFxy.Values.Add("y", y);
            return parserFxy.Parse(fxy);
        }

        public string CalculateFunctionXY(double x, double y, string fxy, ref double result)
        {
            result = ParseFunctionXY(x, y, fxy);
            return "Evaluación de f(x,y)";
        }

        public double parsedFunction(double x, string fx)
        {
            ExpressionParser parser1 = new ExpressionParser();
            parser1.Values.Add("x", x);
            return parser1.Parse(fx);
        }
        public double parsedFunctionY(double x, double y, string fx)
        {
            ExpressionParser parser1 = new ExpressionParser();
            parser1.Values.Add("x", x);
            parser1.Values.Add("y", y);
            return parser1.Parse(fx);
        }
    }
}