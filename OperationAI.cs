using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationAI
{
    public interface Operation
    {
        double operation(double a, double b);
        string name { get; }
    }
}
