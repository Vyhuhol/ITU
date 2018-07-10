using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationAI;


namespace AddSuub
{
    public class Add: Operation
    {
        public double operation(double a, double b)
        {
            return a + b;
        }
        public string name
        {
            get
            {
                return "+";
            }
        }
    }

    public class Sub : Operation
    {
        public double operation(double a, double b)
        {
            return a - b;
        }
        public string name
        {
            get
            {
                return "-";
            }
        }
    }
}
