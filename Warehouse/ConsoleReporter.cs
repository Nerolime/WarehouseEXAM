using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ConsoleReporter : IReporter
    {
        public void NewProduct(string message)
        {
            Console.WriteLine(message);
        }
    }
}
