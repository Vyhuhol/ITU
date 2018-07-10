using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OperationAI;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string CurrentDir = Path.GetDirectoryName(
                Assembly.GetEntryAssembly().Location);

            string PlugDir = Path.Combine(CurrentDir, "Plugins");
            
            string[] PlugAssemblies = Directory.GetFiles(PlugDir, "*.dll");

            Dictionary<String, Operation> ListOfOperations = new Dictionary<String, Operation>();

            foreach (string file in PlugAssemblies)
            {
                Assembly assembly = Assembly.LoadFrom(file);
                Type[] types = assembly.GetTypes();
                foreach (Type t in types)
                {
                    Operation op = (Operation)Activator.CreateInstance(t);
                    ListOfOperations.Add(op.name, op);
                }
            }

            int i, j;
            double a, b;
            string name, str;

            str = Console.ReadLine();
            i = str.IndexOf(' ');
            a = int.Parse(str.Substring(0, i));
            j = i+1;
            i = str.IndexOf(' ', j);
            b = int.Parse(str.Substring(j, i-j));
            name = str.Substring(i+1, str.Length-i-1);

            Console.Write(ListOfOperations[name].operation(a, b));
            Console.ReadKey();
        }
    
    }
}
