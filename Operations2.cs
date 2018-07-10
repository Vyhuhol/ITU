using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationAI;


namespace MultDiv
{
    public class Mult : Operation
    {
        public double operation(double a, double b)
        {
            return a * b;
        }
        public string name
        {
            get
            {
                return "*";
            }
        }
    }

    public class Div : Operation
    {
        public double operation(double a, double b)
        {
            return a/b;
        }
        public string name
        {
            get
            {
                return "/";
            }
        }
    }
}

