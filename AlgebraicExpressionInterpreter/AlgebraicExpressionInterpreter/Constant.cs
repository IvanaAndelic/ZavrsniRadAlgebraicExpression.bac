﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicExpressionInterpreter
{
    public class Constant : IExpression
    {
        private readonly double value;

        public Constant(double value)
        {
            this.value = value;
        }

        public double Interpret(Context context)
        {

            return value;
        }


    }
}