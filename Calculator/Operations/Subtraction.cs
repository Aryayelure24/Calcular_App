﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class Subtraction : IOperation
    {
        public double Execute(double a, double b)
        {
            return a - b;
        }
        public double Execute(double num1)
        {
            throw new NotImplementedException("Substraction is not possible with one variable");
        }
    }
}
